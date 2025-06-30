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

namespace LibraDesk.Resources
{
    public partial class bookTableForm : Form
    {
        public bookTableForm()
        {
            InitializeComponent();
            showSideBar();
        }

        private void bookTableForm_Load(object sender, EventArgs e)
        {
            LoadBooksData();
        }
        private void showSideBar()
        {
            SideBarControl sideBar = new SideBarControl();
            sideBar.Dock = DockStyle.Left;
            this.Controls.Add(sideBar);
        }

        private void booksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void heading_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            LibraDesk.Resources.AddBook addBook = new LibraDesk.Resources.AddBook();
            addBook.Show();
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
                        booksTable.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
