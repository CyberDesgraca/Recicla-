using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Recicla_
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void BtnAtividade_Click(object sender, EventArgs e)
        {
            var atividade = new Atividade();
            atividade.Show();
            this.Hide();
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            // verifica sessão
            if (string.IsNullOrWhiteSpace(Sessao.Email))
            {
                MessageBox.Show("Ops! Parece que você não está logado. Faça seu login para ver seus pontos 👋", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // consulta nome e pontos pelo email da sessão
            try
            {
                var conexao = new Conexao();
                using var conn = conexao.OpenConnection();
                const string sql = @"
                    SELECT NOMEUSER, COALESCE(PONTOUSER, 0) AS PONTOUSER
                    FROM USUARIO
                    WHERE EMAILUSER = @Email
                    LIMIT 1;";
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", Sessao.Email.Trim());

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var nome = reader.IsDBNull(reader.GetOrdinal("NOMEUSER")) ? "Amigo" : reader.GetString("NOMEUSER");
                    var pontos = reader.IsDBNull(reader.GetOrdinal("PONTOUSER")) ? 0 : reader.GetInt32("PONTOUSER");

                    // mostra MessageBox com nome e pontos em tom mais amigável
                    var titulo = "Seus Pontos";
                    var texto = $"{nome},\n\nVocê possui {pontos:N0} pontos 🎉\nContinue reciclando e ajudando o planeta ♻️";
                    MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // abre formulário Ponto normalmente (descomente se quiser abrir a tela)
                    // Ponto ponto = new Ponto();
                    // ponto.Show();
                    // this.Hide();
                }
                else
                {
                    MessageBox.Show("Humm... não encontramos um cadastro com esse e‑mail. Verifique seu login ou cadastre‑se 😊", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! Não foi possível carregar seus pontos agora. Tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // opcional: escrever no console para debug
                Console.Error.WriteLine($"Erro ao consultar usuário: {ex}");
            }
        }
    }
}
