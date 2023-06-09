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
        // String st = "";
        private Book b = null; //change
        private Student Student = null;
        private string sn = "";
        
   
        public StudentBorrowActinos(string s, Book b, Student Stud)
        {           
            //this.st = st;
            this.b = b;
            this.Student = Stud;
            this.sn = s;
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
           /* BookCrudTitle.Text = b.get_title().ToString();
            this.b = Program.seekBook(sn);
            lb_ISBN_value.Text = sn;
            lb_AuthorValue.Text = b.get_author();
            lb_PublishYearValue.Text = b.get_PYear().ToString();
            lb_LangueageValue.Text = b.get_lang().ToString();
            lb_RatingValue.Text = b.get_rating().ToString();
            BookCrudTitle.Text = b.get_title();*/
        }

        private void bookHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory(Student);
            formStudentBookHistory.Show();
            this.Hide();
        }


        private void ratingControl1_Click(object sender, EventArgs e)
        {
           // switch (RatingStars.Value)
            {
                //case 1:
                        
                    
              //  case 2:



            }
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

       

    }
}

