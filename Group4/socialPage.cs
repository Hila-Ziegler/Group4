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
    public partial class socialPage : Form
    {
        List<Student> students;
        List<BookHistory> allClubHistory;
        List<BookHistory> MyBooklHistory;
        List<Book> allBook;
        List<Student> clubStudents;// לספור כמה תלמידים במועדון שלי , לעשות בר כמה המועדון שלי קרא ביחס לשאר בית הספר וביחס לשאר המועדונים
        Student student;




        public socialPage(Student stud)
        {
            this.student = stud;
            students= Program.students;
            MyBooklHistory = Program.bookHistories;
            allBook = Program.books;
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
                if ((bh.get_student() == this.student ) && ((DateTime.Parse(bh.get_StartDate().ToString()).Year) == (DateTime.Parse(DateTime.Now.ToString()).Year)))
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


        private void update_socialPage()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.students;
            int i = 0;
            foreach (Student s in this.students)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = s.get_name();
                    this.dataGridView1.Rows[i].Cells[1].Value = s.get_ID();
                    this.dataGridView1.Rows[i].Cells[2].Value = s.get_age();
                    this.dataGridView1.Rows[i].Cells[3].Value = EnumHelper.GetDescription(s.get_club());

                }

                i++;

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private float get_yearlyGoalfloat()
        {
             return student.get_yearlyGoal();
         }
        private float percentage(float a , float b)
        {
            float f =((a/b) * 100);
            return f;
        }

        private void socialPage_Load(object sender, EventArgs e)
        {
            update_socialPage();
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

            labGoal.Text =  this.getReadAmount().ToString();
            labPercentageAll.Text = $"{(percentage(getReadAmount(),allBook.Count()).ToString("F2"))} %";
            progressBarAllTheTome.Maximum = allBook.Count();
            progressBarAllTheTome.Minimum = 0;
            progressBarAllTheTome.Value = (int)this.getReadAmount();

            progressBarClub.Maximum = this.allBook.Count();
            progressBarClub.Minimum = 0;
            progressBarClub.Value = (int)this.getClubReadAmount();
            labPercentageClub.Text = $"{(percentage(getClubReadAmount(), allBook.Count()).ToString("F2"))} %";








        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labGoal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["StudentName"].Index)
            {                
                int i = e.RowIndex;
                string newStudentId = dataGridView1.Rows[i].Cells[1].Value.ToString();

                if (this.student.get_ID() == newStudentId)
                {
                    IncorrectInformation formIncorrectInformation = new IncorrectInformation("This is your profile\r\nno access ");
                    formIncorrectInformation.Show();
                    
                }

                if (this.student.get_ID() != newStudentId)
                {
                    Student st = Program.seekStudent(newStudentId);

                    FriendSocialPage1 formFriendSocialPage1 = new FriendSocialPage1(st);
                    formFriendSocialPage1.Show();
                    
                }


               
            }    
            
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void progressBarClub_Click(object sender, EventArgs e)
        {

        }

        private void progressBarThisYear_Click(object sender, EventArgs e)
        {

        }

        private void progressBarAllTheTome_Click(object sender, EventArgs e)
        {

        }
    }
}
