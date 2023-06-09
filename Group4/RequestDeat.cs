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
        Student student = null;
        Copy copy = null;
        
        public RequestDeat(Request r, Librarian l)
        {
            this.r = r;
            this.librarian = l;
            InitializeComponent();
        }

        public RequestDeat( Student st, Copy c)
        {
            this.student = st;
            this.copy = c; // avia add
            InitializeComponent();
        }

        private void loadEnum()
        {
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                string description = EnumHelper.GetDescription(status);
                StatusCombo.Items.Add(description);
            }

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
            //delete or archive? 
        }

        private void BookCrudUpdateBTN_Click(object sender, EventArgs e)
        {
            this.r.set_status((Status)Enum.Parse(typeof(Status), StatusCombo.Text));
            this.r.set_endDT(DateTime.Now);
            this.r.update_Request();
        }

        private void RequestDeat_Load(object sender, EventArgs e)
        {
            if (this.r.get_photoAddress() == null)
            {
                AttachedPhotolbl.Hide();
                AttachedPhotobox.Hide();
            }
            else
            {
                //AttachedPhotobox.Image = Image.FromFile(this.r.get_photoAddress());
            }
            if (this.student == null)
            {
                Sdtxt.Text = this.r.get_startDT().ToString();
                Sidtxt.Text = this.r.get_Student().get_ID().ToString();
                Sntxt.Text = this.r.get_Student().get_name();
                Bsntxt.Text = this.r.get_copy().get_book().get_sNumber().ToString();
                Cntxt.Text = this.r.get_copy().get_copyNum().ToString();
                EndDTtxt.Hide();
                CancelBTN.Hide();
                loadEnum();
            }
            else
            {
                Request NewR = null;
                //transfer type
                Sdtxt.Text = DateTime.Now.ToString();
                NewR.set_startDT(DateTime.Now);
                NewR.set_endDT(DateTime.Now);
                Sidtxt.Text = this.student.get_ID().ToString();
                NewR.set_Student(this.student);
                Sntxt.Text = this.student.get_name();
                Bsntxt.Text = this.copy.get_book().get_sNumber();
                NewR.set_copy(this.copy);
                NewR.set_Librarian(this.librarian);
                //set status
                //photo address
                //NewR.create_Request();
                EndDTtxt.Hide();
                UpdateStlbl.Hide();
                StatusCombo.Hide();
            }
            //archive mode? 
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
