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
            LibraDesk.Resources.AddBook addBookForm = new LibraDesk.Resources.AddBook();
            addBookForm.Show();

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            LibraDesk.Dashboard dashboardForm = new LibraDesk.Dashboard();
            dashboardForm.Show();


        }
    }
}


