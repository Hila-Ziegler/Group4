using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class LibrarianChooseAction : Form
    {
        Librarian l = null;
        public LibrarianChooseAction(Librarian l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageBooks form3 = new ManageBooks();
            form3.Show();
            this.Hide();
        }

        private void Action_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRequests formManageRequests = new ManageRequests(l);
            formManageRequests.Show();
            this.Hide();
        }
    }
}
