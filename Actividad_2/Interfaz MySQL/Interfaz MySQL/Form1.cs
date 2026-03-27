using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interfaz_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            string user = txtUsuario.Text;
            string password = txtContrasena.Text;
            string puerto = txtPuerto.Text;
            string database = txtBD.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM catpersonal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDatos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                }
            }

        }
        private string BuildConnectionString(string host, string user, string password, string puerto, string database)
        {
            return $"SERVER={host};PORT={puerto};DATABASE={database};USER ID={user};PASSWORD={password};";
        }
    }
}


