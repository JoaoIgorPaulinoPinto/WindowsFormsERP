using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Projeto0307.Functions
{
    
    class DBConnection
    {
        private static MySqlConnection conn;
        public static MySqlConnection ConnectToDataBase()
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                return conn;
            }
            else
            {

                try
                {
                    string connStr = "server=localhost;user=root;database=bd_erp;port=3306;password=Joao996083255;";
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    return conn;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados:\n" + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
    
}
