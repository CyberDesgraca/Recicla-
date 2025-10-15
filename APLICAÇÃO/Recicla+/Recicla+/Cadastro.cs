using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recicla_
{
    public partial class Cadastro : Form
    {
        Conexao conexao = new Conexao();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void BtnEnviarCadastro_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeCadastro.Text;
            string email = TxtEmailCadastro.Text;
            string senha = TxtSenhaCadastro.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Cadastre as informações corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conn = null;

            try
            {
                conn = conexao.OpenConnection();

                string sql = "INSERT INTO usuario (NOMEUSER, EMAILUSER, SENHAUSER) VALUES (@nome, @email, @senha)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Falha ao cadastrar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Este e-mail já está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Falha na comunicação com o Banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.CloseConnection();
            }

            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
