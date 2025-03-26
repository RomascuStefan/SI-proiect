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

namespace SI_proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;port=3306;database=key_management;uid=root;pwd=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    textBox1.Text = "Conectat";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "EXCEPTIE: " + ex.Message;
            }
        }
    }
}
