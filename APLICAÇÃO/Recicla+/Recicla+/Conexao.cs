using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Recicla_
{
    public class Conexao
    {
        private readonly string connectionString = "server=localhost;uid=root;pwd=M@sterk3y;database=recicla;port=3306";
        private MySqlConnection conexao;

       
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            try
            {
                conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro MySQL ({ex.Number}): {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro geral: {ex.Message}");
            }
        }

        public void CloseConnection()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }
    }
}
