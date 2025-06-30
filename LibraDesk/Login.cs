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

namespace LibraDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = DBConnection.GetConnection();
            try
            {
                conn.Open();
                string email = loginEmail.Text;
                string password = loginPassword.Text;
                string query = $"SELECT * FROM users where email='{email}' and Password= '{password}'";
              
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int userId = reader.GetInt32("UserId");
                    string name = reader.GetString("name");
                    bool membership = reader.GetBoolean("libraryMembership");

                    MessageBox.Show($"Welcome, {name}!");
                    Dashboard dashboard = new Dashboard(name,email,membership);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Your email or password may be wrong");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
