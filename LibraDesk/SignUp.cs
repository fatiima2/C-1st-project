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
using Org.BouncyCastle.Tls;


namespace LibraDesk
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string email = signUpEmail.Text;
            string name = signUpName.Text;
            string password = signUpPassword.Text;
            string contactNo = signUpContactNo.Text;
            string department=signUpDepartment.Text;
            string semester = signUpSemester.Text;

            var connection = DBConnection.GetConnection();
            try
            {
                connection.Open();
                string query = $"INSERT INTO users(Name,email,Password,contactNo,Department,Semester)"+
                    $"Values('{name}','{email}','{password}','{contactNo}','{department}',{semester})";
              MySqlCommand cmd= new MySqlCommand(query, connection);

                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Signed  Up Successfully");
                    Form1 login = new Form1();
                    this.Hide();
                    login.Show();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
