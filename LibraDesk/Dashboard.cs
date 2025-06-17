using LibraDesk.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraDesk
{
    public partial class Dashboard : Form
    {
        private string name, email;
        private bool libraryMembership;
        public Dashboard()
        {
            InitializeComponent();
            showSideBar();
        }
       

        public Dashboard(string name, string email, bool libraryMembership)
        {
            InitializeComponent();
            showSideBar();
            this.name = name;
            this.email = email;
            this.libraryMembership = libraryMembership;
            popularData(name, email);
            showStats();
        }

        private void showSideBar()
        {
            SideBarControl sideBar = new SideBarControl();
            sideBar.Dock = DockStyle.Left;
            this.Controls.Add(sideBar);
        }
        private void popularData(string name, string email)
        {
            dashboardName.Text = name;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void booksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadBooksData()
        {
            try
            {
                using (var connection = DBConnection.GetConnection())
                {
                    string query = "SELECT * FROM Books";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        booksList.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showStats()
        {
            LoadBooksData();
            showBookCount();
            showMemberCount();
        }
        private void showBookCount()
        {
            string totalBooksQuery = "SELECT count(*) from books";
            string AvailableBooksQuery = "Select count(*) from books where status='Available'";
            string issuedBookQuery = "SELECT count(*) from books where issuedCount>0";
        
            var connection= DBConnection.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmd= new MySqlCommand(AvailableBooksQuery, connection);
                MySqlCommand cmdIssuedbookCount=new MySqlCommand(issuedBookQuery, connection);
                MySqlCommand cmdtotalBooksQuery=new MySqlCommand(totalBooksQuery, connection);

                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int availableBooks = reader.GetInt32(0);
                    string availability= $"Available Books\n {availableBooks}";
                    MessageBox.Show($"Available Books {availableBooks}");
                    button1.Text = availability;
                }

                connection.Close();connection.Open();
                reader = cmdIssuedbookCount.ExecuteReader();
                if (reader.Read())
                {
                    int issuedBook = reader.GetInt32(0);
                    string issued = $"Books Issued{issuedBook}";
                    button3.Text= issued;
                }

                connection.Close();connection.Open();
                reader = cmdtotalBooksQuery.ExecuteReader();
                if (reader.Read())
                {
                    int totalBooks = reader.GetInt32(0);
                    string total = $"Total Books{totalBooks}";
                    totalBooksButton.Text = total;
                }
                else
                {
                    MessageBox.Show("Reader Error");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show( "Error : " + ex.Message);
            }
        }

        private void totalBooksButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void showMemberCount()
        {
            string memberCountQuery = "Select count(*) from users where libraryMembership=1";
            var connection=DBConnection.GetConnection();
            try
            {
                connection.Open();
                MySqlCommand cmdMemberCount = new MySqlCommand(memberCountQuery, connection);
                MySqlDataReader reader = cmdMemberCount.ExecuteReader();
                if (reader.Read())
                {
                    int memberCount = reader.GetInt32(0);
                    string members = $"Members{memberCount}";
                    button2.Text = members;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message );
            }
        }
       
    }
}
