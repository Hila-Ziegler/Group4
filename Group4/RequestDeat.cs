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
        RequestType requestType;
        BookHistory bookHistory;
        
        public RequestDeat(Request r, Librarian l)
        {
            this.r = r;
            this.librarian = l;
            InitializeComponent();
        }

        public RequestDeat( Student st, Copy c, RequestType rt, Librarian l, BookHistory bh)
        {
            this.requestType = rt;
            this.student = st;
            this.copy = c;
            this.librarian = l;
            this.bookHistory = bh;
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
            Status st = (Status)Enum.Parse(typeof(Status), "Closed");
            this.r.set_status(st);
            this.r.update_Request();
        }

        private void BookCrudUpdateBTN_Click(object sender, EventArgs e)
        {
            this.r.set_status((Status)Enum.Parse(typeof(Status), StatusCombo.Text));
            this.r.set_endDT(DateTime.Now);
            this.r.update_Request();
        }

        private void RequestDeat_Load(object sender, EventArgs e)
        {
/*            if (this.r.get_photoAddress() == "")
            {
                AttachedPhotolbl.Hide();
                AttachedPhotobox.Hide();
            }
            else
            {
                //show picture 
            }*/
            if (this.student == null)
            {
                Sdtxt.Text = this.r.get_startDT().ToString();
                Sidtxt.Text = this.r.get_Student().get_ID().ToString();
                Sntxt.Text = this.r.get_Student().get_name();
                Bsntxt.Text = this.r.get_copy().get_book().get_sNumber().ToString();
                Cntxt.Text = this.r.get_copy().get_copyNum().ToString();
                EndDTtxt.Hide();
                CancelBTN.Hide();
                Uploadbtn.Hide();
                CreateReqbtn.Hide();
                loadEnum();
            }
            else
            {
                if (this.r == null)
                {
                    Sdtxt.Text = DateTime.Now.ToString();
                    Sidtxt.Text = this.student.get_ID().ToString();
                    Sntxt.Text = this.student.get_name();
                    Bsntxt.Text = this.copy.get_book().get_sNumber();
                    CancelBTN.Hide();

                }
                else
                {
                    Sdtxt.Text = this.r.get_startDT().ToString();
                    Sidtxt.Text = this.r.get_Student().get_ID().ToString();
                    Sntxt.Text = this.r.get_Student().get_name();
                    Bsntxt.Text = this.r.get_copy().get_book().get_sNumber().ToString();
                    Cntxt.Text = this.r.get_copy().get_copyNum().ToString();
                    CreateReqbtn.Hide();
                }

                EndDTtxt.Hide();
                UpdateStlbl.Hide();
                StatusCombo.Hide();
                AcceptBTN.Hide();
            }
        }

        private void Bsntxt_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.student == null)
            {
                ManageRequests formManageRequests = new ManageRequests(librarian);
                formManageRequests.Show();
                this.Hide();
            }
            else
            {
                StudentBorrowActinos formStudentBorrowActions = new StudentBorrowActinos(this.bookHistory);
                formStudentBorrowActions.Show();
                this.Hide();
            }

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.student == null)
            {
                LibrarianChooseAction formLibrarianChooseAction = new LibrarianChooseAction(this.librarian);
                formLibrarianChooseAction.Show();
                this.Hide();
            }
            else
            {
                StudentChooseAction formStudentChooseAction = new StudentChooseAction(this.student);
                formStudentChooseAction.Show();
                this.Hide();
            }

        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
/*            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                AttachedPhotobox.Image = new Bitmap(opnfd.FileName);
            }*/
        }

        private void CreateReqbtn_Click(object sender, EventArgs e)
        {
            Request NewR = new Request(this.requestType, DateTime.Now, this.student, this.librarian, DateTime.Now, (Status)Enum.Parse(typeof(Status), "Open"), "", this.copy, true);
        }
    }
}
