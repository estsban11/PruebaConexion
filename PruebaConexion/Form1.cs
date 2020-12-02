using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PruebaConexion
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(ExtraerCadena.connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label3.Text = connection.ServerVersion;
                label9.Text = connection.Database;
                label5.Text = connection.State.ToString();
                label7.Text = "Sin errores";
                

            }
            catch (Exception ex)
            {

                label7.Text = $"Error: {ex.Message}";
            }
            finally
            {
                connection.Close();
                label6.Text = connection.State.ToString();
            }

            
        }
    }
}
