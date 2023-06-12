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
    public partial class FriendSocialPage1 : Form
    {
        List<Student> students;
        List<BookHistory> allClubHistory;
        List<BookHistory> MyBooklHistory;
        List<Book> allBook;
        List<Student> clubStudents;// לספור כמה תלמידים במועדון שלי , לעשות בר כמה המועדון שלי קרא ביחס לשאר בית הספר וביחס לשאר המועדונים
        Student student;
        public FriendSocialPage1(Student stud)
        {
            this.student = stud;
           // filterStudent();
            MyBooklHistory = Program.bookHistories;
            allBook = Program.books;
            clubStudents = Program.students;
            this.allClubHistory = this.filterClubHistory();
            this.clubStudents = this.filterClubMembers();
            InitializeComponent();
            
        }

        private List<BookHistory> filterClubHistory()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student().get_club() == student.get_club())
                {
                    ans.Add(bh);


                }
            }
            return ans;
        }
/*        private List<Student> filterStudent()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student().get_club() == student.get_club())
                {
                    ans.Add(bh);


                }
            }
            return ans;
        }*/
        private List<Student> filterClubMembers()
        {
            List<Student> ans = new List<Student>();
            foreach (Student st in Program.students)
            {
                if (st.get_club() == student.get_club())
                {
                    ans.Add(st);

                }
            }
            return ans;
        }

        private float getReadAmount()
        {
            List<BookHistory> allHistory = this.getHistory();
            return allHistory.Count();
        }

        private List<BookHistory> getHistory()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student() == this.student)
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }
        private List<BookHistory> getThisYearHistory()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if ((bh.get_student() == this.student) && ((DateTime.Parse(bh.get_StartDate().ToString()).Year) == (DateTime.Parse(DateTime.Now.ToString()).Year)))
                {
                    ans.Add(bh);

                }
            }
            return ans;
        }
        private float getReadAmountThisYea()
        {
            List<BookHistory> allHistory = this.getThisYearHistory();
            return allHistory.Count();
        }
        private List<BookHistory> getClubHistory()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student().get_club() == this.student.get_club())
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }

        private float getClubReadAmount()
        {
            List<BookHistory> allHistory = this.getClubHistory();
            return allHistory.Count();
        }
        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private float get_yearlyGoalfloat()
        {
            return student.get_yearlyGoal();
        }
        private float percentage(float a, float b)
        {
            float f = ((a / b) * 100);
            return f;
        }
        private void update_FriendSocialPage1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.clubStudents;
            int i = 0;
            foreach (Student s in this.clubStudents)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = s.get_name();

                }

                i++;

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FriendSocialPage1_Load(object sender, EventArgs e)
        {
            update_FriendSocialPage1();
            label4.Text = $"{this.student.get_name().Split(' ')[0]}'s Club Members:";
            labName.Text = student.get_name().ToString();
            labAge.Text = student.get_age().ToString();
            labDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labSchoolName.Text = "Morday Hagetaot School";
            labClub.Text = EnumHelper.GetDescription(student.get_club());
            labThisYearIRead.Text = this.getReadAmountThisYea().ToString();
            lablabThisYearIRead1.Text = $"{(percentage(getReadAmountThisYea(), get_yearlyGoalfloat()).ToString("F2"))} %";

            progressBarThisYear.Maximum = this.student.get_yearlyGoal();
            progressBarThisYear.Minimum = 0;
            progressBarThisYear.Value = (int)this.getReadAmountThisYea();

            labGoal.Text = this.getReadAmount().ToString();
            labPercentageAll.Text = $"{(percentage(getReadAmount(), allBook.Count()).ToString("F2"))} %";
            progressBarAllTheTome.Maximum = allBook.Count();
            progressBarAllTheTome.Minimum = 0;
            progressBarAllTheTome.Value = (int)this.getReadAmount();

            progressBarClub.Maximum = this.allBook.Count();
            progressBarClub.Minimum = 0;
            progressBarClub.Value = (int)this.getClubReadAmount();
            labPercentageClub.Text = $"{(percentage(getClubReadAmount(), allBook.Count()).ToString("F2"))} %";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
