using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

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


    }
}
