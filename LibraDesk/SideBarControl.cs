using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraDesk
{
    public partial class SideBarControl : UserControl
    {
        public SideBarControl()
        {
            InitializeComponent();
        }

        private void SideBarControl_Load(object sender, EventArgs e)
        {

        }
        private void booksButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            LibraDesk.Resources.bookTableForm BookTableForm=new LibraDesk.Resources.bookTableForm();
            BookTableForm.Show();

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            LibraDesk.Dashboard dashboardForm = new LibraDesk.Dashboard();
            dashboardForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}


