using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms; 
using MySql.Data.MySqlClient;

namespace Recicla_
{
    public partial class Atividade : Form
    {
        private readonly string _connectionString = "Server=localhost;Database=recicla;User Id=root;Password=M@sterk3y;";

        public Atividade()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Selecione uma imagem",
                Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = false
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var filePath = ofd.FileName;

            byte[] fileBytes;
            try
            {
                fileBytes = await File.ReadAllBytesAsync(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fileName = Path.GetFileName(filePath);
            var contentType = GetContentType(filePath);

            try
            {
                await SaveImageToDatabaseAsync(fileName, fileBytes, contentType);

                // atualiza pontos usando o email armazenado na Sessao
                await AddPointsToLoggedUserByEmailAsync(1000);

                MessageBox.Show("Imagem enviada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetContentType(string path)
        {
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return ext switch
            {
                ".jpg" or ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".bmp" => "image/bmp",
                _ => "application/octet-stream"
            };
        }

        private async Task SaveImageToDatabaseAsync(string name, byte[] data, string contentType)
        {
            const string sql = @"
                    INSERT INTO Photos (Name, Data, ContentType, CreatedAt)
                    VALUES (@name, @data, @contentType, @createdAt);";

            await using var conn = new MySqlConnection(_connectionString);
            await conn.OpenAsync();

            await using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            var p = new MySqlParameter("@data", MySqlDbType.LongBlob) { Value = data };
            cmd.Parameters.Add(p);
            cmd.Parameters.AddWithValue("@contentType", contentType);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

            await cmd.ExecuteNonQueryAsync();
        }

        private async Task AddPointsToLoggedUserByEmailAsync(int points)
        {
            if (string.IsNullOrEmpty(Sessao.Email))
            {
                MessageBox.Show("Nenhum usuário logado para creditar pontos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await using var conn = new MySqlConnection(_connectionString);
                await conn.OpenAsync();

                const string updateSql = "UPDATE USUARIO SET PONTOUSER = COALESCE(PONTOUSER, 0) + @points WHERE EMAILUSER = @Email";
                await using var cmd = new MySqlCommand(updateSql, conn);
                cmd.Parameters.AddWithValue("@points", points);
                cmd.Parameters.AddWithValue("@Email", Sessao.Email.Trim());

                var affected = await cmd.ExecuteNonQueryAsync();
                if (affected == 0)
                {
                    MessageBox.Show("Não foi possível atualizar pontos (usuário não encontrado pelo email).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar pontos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menu menuForm = new menu();
            menuForm.Show();
            this.Hide();
        }
    }
}