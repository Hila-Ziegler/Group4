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
    public partial class StudentBorrowActinos : Form
    {
        BookHistory bhRecord;
        Copy c;
        Student student;
        public System.Collections.Generic.List<Librarian> librarians;
        Random rnd = new Random();

        public StudentBorrowActinos(BookHistory bhRecord)
        {
            this.bhRecord = bhRecord;
            this.c = Program.seekCopy(bhRecord.get_book(), bhRecord.get_copyNum());
            this.student = bhRecord.get_student();
            librarians = Program.librarians;
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }
        private void StudentBorrow_Load(object sender, EventArgs e)
        {
            BookCrudTitle.Text = c.get_book().get_title().ToString();
            TitleLB.Text = c.get_book().get_title();
            ISBNLB.Text = c.get_book().get_sNumber();
            AuthorLB.Text = c.get_book().get_author();
            PublishYearLB.Text = c.get_book().get_PYear().ToString();
            LanguageLB.Text = c.get_book().get_lang().ToString();
            lb_RatingValue.Text = c.get_book().get_rating().ToString();

            CancelTimeExtbtn.Hide();
            CancelAltbtn.Hide();


            foreach (Request r in getStudentRequests())
            {
                if(r.get_type().ToString() == "TimeExtention" && r.get_status().ToString() == "Open")
                {
                    RequestTimebtn.Hide();
                    CancelTimeExtbtn.Show();
                }
                if (r.get_type().ToString() == "AlternativeBook" && r.get_status().ToString() == "Open")
                {
                    SuggestAlternativeBook.Hide();
                    CancelAltbtn.Show();
                }

            }
        }

        private List<Request> getStudentRequests()
        {
            List<Request> li = new List<Request>();
            foreach(Request r in Program.requests)
            {
                if (this.student.get_ID() == r.get_Student().get_ID() && this.c.get_book().get_sNumber() == r.get_copy().get_book().get_sNumber() && this.c.get_copyNum() == r.get_copy().get_copyNum())
                {
                    li.Add(r);
                }
            }
            return li;
        }

        private void bookHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory(this.student);
            formStudentBookHistory.Show();
            this.Hide();
        }

        private void RatingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cbRate;
            cbRate = int.Parse(RatingCB.Text);
            bhRecord.set_rate(cbRate);
            bhRecord.get_book().calculateAverageRating();
            bhRecord.update_BookHistory();
            Book b = bhRecord.get_book();
            b.update_Book();
        }

        private void RequestTimeExtention_Click(object sender, EventArgs e)
        {
            RequestType rt = ((RequestType)Enum.Parse(typeof(RequestType), "TimeExtention"));
            int randomNum = rnd.Next(0, librarians.Count);
            Librarian l = librarians[randomNum];
            RequestDeat formRequestDeat = new RequestDeat(this.student, this.c, rt, l, this.bhRecord);
            formRequestDeat.Show();
            this.Hide(); 
        }

        private void SuggestAlternativeBook_Click(object sender, EventArgs e)
        {
            RequestType rt = ((RequestType)Enum.Parse(typeof(RequestType), "AlternativeBook"));
            int randomNum =  rnd.Next(0, librarians.Count);
            Librarian l = librarians[randomNum];
            RequestDeat formRequestDeat = new RequestDeat(this.student, this.c, rt, l, this.bhRecord);
            formRequestDeat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestType rt = ((RequestType)Enum.Parse(typeof(RequestType), "TimeExtention"));
            int randomNum = rnd.Next(0, librarians.Count);
            Librarian l = librarians[randomNum];
            RequestDeat formRequestDeat = new RequestDeat(this.student, this.c, rt, l, this.bhRecord);
            formRequestDeat.Show();
            this.Hide();
        }

        private void CancelTimeExtbtn_Click(object sender, EventArgs e)
        {
            foreach (Request r in Program.requests)
            {
                if (r.get_Student().get_ID() == this.student.get_ID() && r.get_copy().get_book().get_sNumber() == this.c.get_book().get_sNumber() && r.get_copy().get_copyNum() == this.c.get_copyNum() && r.get_status().ToString() == "Open")
                {
                    if (r.get_type().ToString() == "TimeExtention")
                    {
                        Status st = (Status)Enum.Parse(typeof(Status), "Closed");
                        r.set_status(st);
                        r.update_Request();
                        bookHistoryToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

        private void CancelAltbtn_Click(object sender, EventArgs e)
        {
            foreach (Request r in Program.requests)
            {
                if (r.get_Student().get_ID() == this.student.get_ID() && r.get_copy().get_book().get_sNumber() == this.c.get_book().get_sNumber() && r.get_copy().get_copyNum() == this.c.get_copyNum() && r.get_status().ToString() == "Open")
                {
                    if (r.get_type().ToString() == "AlternativeBook")
                    {
                        Status st = (Status)Enum.Parse(typeof(Status), "Closed");
                        r.set_status(st);
                        r.update_Request();
                        bookHistoryToolStripMenuItem_Click(sender, e);
                    }
                }
            }
        }

    }
}

