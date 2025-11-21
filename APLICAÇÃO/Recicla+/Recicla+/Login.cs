using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Recicla_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            string email = TxtEmail.Text.Trim();
            string senha = TxtSenha.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Aten��o", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Conexao conexao = new Conexao();
            MySqlConnection conn = null;
            try
            {
                conn = conexao.OpenConnection();
                string sql = "SELECT CODUSER FROM USUARIO WHERE EMAILUSER = @Email AND SENHAUSER = @Senha LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // salva email na sess�o para uso posterior
                            Sessao.Email = email;

                            // tenta preencher UserId (opcional)
                            try
                            {
                                var val = reader["CODUSER"];
                                if (val != DBNull.Value)
                                    Sessao.UserId = Convert.ToInt32(val);
                            }
                            catch
                            {
                                Sessao.UserId = null;
                            }

                            MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menu menu = new menu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.CloseConnection();
            }
        }
    }
}
