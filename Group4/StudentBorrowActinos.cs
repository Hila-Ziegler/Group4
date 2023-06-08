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
        String st = "";
        Book bo = null; //change
   
        public StudentBorrowActinos(string st, Book b)
        {           
            this.st = st;
            this.bo = b;
            InitializeComponent();
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(st);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void StudentBorrow_Load(object sender, EventArgs e)
        {
            BookCrudTitle.Text = bo.get_title().ToString();
        }

        private void bookHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory(st);
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

