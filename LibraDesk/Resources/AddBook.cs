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


namespace LibraDesk.Resources
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            SideBarControl sideBar = new SideBarControl();
            sideBar.Dock = DockStyle.Left;
            this.Controls.Add(sideBar);


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string author = AuthorTextBox.Text;
            string category = categoryTextBox.Text;
            string status = statusTextBox.Text;
            string tags = tagsTextBox.Text;

            if (!int.TryParse(quantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid number for quantity.");
                return;
            }

            var connection = DBConnection.GetConnection();
            try
            {
                connection.Open();

                string query = $"INSERT INTO Books (Title, Author, Category, Quantity, Status, Tags) " +
                               $"VALUES ('{title}', '{author}', '{category}', {quantity}, '{status}', '{tags}')";
                MessageBox.Show("Query being executed: \n" + query);

                MySqlCommand cmd = new MySqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Book added successfully!\n\nInserted:\nTitle: {title}\nAuthor: {author}\nCategory: {category}\nQuantity: {quantity}\nStatus: {status}\nTags: {tags}");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
