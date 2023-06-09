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
        private Book b; 
        private Student Student = null;
        private DateTime StartDate;
        public System.Collections.Generic.List<BookHistory> History;

        public StudentBorrowActinos(Book b, Student Stud, DateTime sd)
        {
            this.b = b;
            this.Student = Stud;
            this.StartDate = sd;
            InitializeComponent();
        }



        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(Student);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void StudentBorrow_Load(object sender, EventArgs e)
        {
            BookCrudTitle.Text = b.get_title().ToString();
            TitleLB.Text = b.get_title(); // y do we need the book title here as well?
            ISBNLB.Text = b.get_sNumber();
            AuthorLB.Text = b.get_author();
            PublishYearLB.Text = b.get_PYear().ToString();
            LanguageLB.Text = b.get_lang().ToString();
            lb_RatingValue.Text = b.get_rating().ToString();
        }

        private void bookHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory(Student);
            formStudentBookHistory.Show();
            this.Hide();
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void RatingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_StartDate() == this.StartDate && bh.get_book() == this.b && bh.get_student() == this.Student)
                {
                    bh.set_rate(int.Parse(RatingCB.Text));
                    bh.update_BookHistory();
                }
                break;
            }

        }
    }
}

