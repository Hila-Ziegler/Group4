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
        List<Student> clubStudents;// לספור כמה תלמידים במועדון שלי , לעשות בר כמה המועדון שלי קרא ביחס לשאר בית הספר וביחס לשאר המועדונים
        Student student;

        public socialPage(Student stud)
        {
            this.student = stud;
            students= Program.students;
            MyBooklHistory = Program.bookHistories;
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

        private int getReadAmount()
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
                    this.dataGridView1.Rows[i].Cells[1].Value = s.get_age();
                    this.dataGridView1.Rows[i].Cells[2].Value = s.get_club();

                }

                i++;

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void socialPage_Load(object sender, EventArgs e)
        {
            update_socialPage();
            labAge.Text = student.get_age().ToString();
            labClub.Text = student.get_club().ToString();
            labName.Text = student.get_name().ToString();
            labDate.Text = DateTime.Now.ToString();
            labSchoolName.Text = "Morday Hagetaot School";
            labGoal.Text =  this.getReadAmount().ToString()  ;
            progressBar1.Maximum = this.student.get_yearlyGoal();
            progressBar1.Minimum = 0;
            progressBar1.Value =  this.getReadAmount();





        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labGoal_Click(object sender, EventArgs e)
        {

        }
    }
}
