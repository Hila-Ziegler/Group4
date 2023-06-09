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
        private Student Student = null;
        private DateTime StartDate;
        private Copy c;
        private System.Collections.Generic.List<BookHistory> history;

        public StudentBorrowActinos(Student Stud, DateTime sd, Copy c)
        {
            this.Student = Stud;
            this.StartDate = sd;
            this.c = c;
            this.history = this.getCopyHistory();
            InitializeComponent();
        }
        private System.Collections.Generic.List<BookHistory> getCopyHistory()
        {
            System.Collections.Generic.List<BookHistory> ans = new System.Collections.Generic.List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_copyNum() == c.get_copyNum() && bh.get_book() == c.get_book())
                {
                    ans.Add(bh);
                }
            }

            return ans;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(Student);
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
            int cbRate;
            cbRate = int.Parse(RatingCB.Text);
            string id = Student.get_ID();
            BookHistory record = this.history.Find(history => Student.get_ID() == id && history.get_StartDate() == StartDate);
            record.set_rate(cbRate);
            // can't load data to sql 
            // kill me
            record.update_BookHistory();




            /*   foreach (BookHistory bh in Program.bookHistories)
               {
                   if (bh.get_StartDate() == this.StartDate && bh.get_book() == this.b && bh.get_student() == this.Student)
                   {
                       cbRate = int.Parse(RatingCB.Text);
                       bh.set_rate(cbRate);
                       bh.update_BookHistory();
                       break;
                   }  
               }*/

        }

        private void RequestTimeExtention_Click(object sender, EventArgs e)
        {
            //RequestDeat formRequestDeat = new RequestDeat(this.Student, this.Copy);
            // להוריד את ההערה אחריי העדכון
        }
    }
}

