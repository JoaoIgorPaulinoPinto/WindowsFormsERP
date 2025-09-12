using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto0307.Functions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Projeto0307
{
    public partial class TelaLogin: Form
    {
        MySqlConnection conn;
        public TelaLogin()
        {
            conn = DBConnection.ConnectToDataBase();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TryLogin(txtb_email.Text, txtb_senha.Text))
            {
                LoginSucces();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta!");
                txtb_email.Clear();
                txtb_senha.Clear();
            }
        }
        bool TryLogin(string email, string  senha)
        {
            if (conn.State == ConnectionState.Open)
            {
                using (conn)
                {
                    try
                    {

                        string query = "SELECT * FROM Usuario WHERE email = @email AND senha = @senha";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Senha", senha);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            return count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar: " + ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
          
        }

        void LoginSucces()
        {
            LoadScreen();
        }
        void LoadScreen()
        {
            GerenciadorGeral.CarregarNovaTela<MainScreen>(this);
        }
    }
}
