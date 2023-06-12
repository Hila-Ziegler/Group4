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
            TitleLB.Text = c.get_book().get_title(); // y do we need the book title here as well?
            ISBNLB.Text = c.get_book().get_sNumber();
            AuthorLB.Text = c.get_book().get_author();
            PublishYearLB.Text = c.get_book().get_PYear().ToString();
            LanguageLB.Text = c.get_book().get_lang().ToString();
            lb_RatingValue.Text = c.get_book().get_rating().ToString();
        }
        //yes
        //very

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
            bhRecord.update_BookHistory();
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
    }
}

