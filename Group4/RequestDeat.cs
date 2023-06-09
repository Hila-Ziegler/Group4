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
    public partial class RequestDeat : Form
    {
        Request r = null;
        Librarian librarian = null;
        
        public RequestDeat(Request r, Librarian l)
        {
            this.r = r;
            this.librarian = l;
            InitializeComponent();
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void Titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewBook_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookCrudDeleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void BookCrudUpdateBTN_Click(object sender, EventArgs e)
        {

        }

        private void RequestDeat_Load(object sender, EventArgs e)
        {
            Sdtxt.Text = this.r.get_startDT().ToString();
            Sidtxt.Text = this.r.get_Student().get_ID().ToString();
            Sntxt.Text = this.r.get_Student().get_name();
            Bsntxt.Text = this.r.get_copy().get_book().get_sNumber().ToString();
            Cntxt.Text = this.r.get_copy().get_copyNum().ToString();
        }

        private void Bsntxt_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRequests formManageRequests = new ManageRequests(librarian);
            formManageRequests.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction formLibrarianChooseAction = new LibrarianChooseAction(librarian);
            formLibrarianChooseAction.Show();
            this.Hide();
        }
    }
}
