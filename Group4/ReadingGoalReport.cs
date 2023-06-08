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
    public partial class ReadingGoalReport : Form
    {
        Student s;
        List<BookHistory> allSchoolHistory;
        List<BookHistory> allClubHistory;
        List<Student> allStudents;
        List<Student> clubStudents;


        public ReadingGoalReport(Student s)
        {
            this.s = s;
            this.allSchoolHistory = new List<BookHistory>(Program.bookHistories);
            this.allClubHistory = this.filterClubHistory();
            this.allStudents = new List<Student>(Program.students);
            this.clubStudents = this.filterClubMembers();
            InitializeComponent();
        }

        private List<BookHistory> filterClubHistory()
        {
            List <BookHistory> ans = new List<BookHistory>();
            foreach(BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student().get_club() == s.get_club())
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
                if (st.get_club() == s.get_club())
                {
                    ans.Add(st);

                }
            }
            return ans;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void homePAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction sca = new StudentChooseAction(this.s);
            sca.Show();
            this.Hide();
        }

        private void ReadingGoalReport_Load(object sender, EventArgs e)
        {
            label8.Text = "Generated on:\n" +DateTime.Now.ToString();
            label9.Text = "Morday Hagetaot School";
            label15.Text = this.s.get_name();
            label10.Text = $"Age: {this.s.get_age()}";
            label3.Text = $"You've read {this.getReadAmount()} / {this.s.get_yearlyGoal()} books";
            AverageBookRating.Text = $"Your Average Book Rating is: {this.getMyAverageRating()}";
            label1.Text = $"Your shortest book borrow is: \n{this.getShortestBookBorrow()}";
            label2.Text = $"Your Longest book borrow is: \n{this.getShortestBookBorrow()}";
            label6.Text = $"Average reading goal in school is: {this.getaverageReadingGoalInSchool()}";
            label7.Text = $"Average Reading goal success rate in school is: {this.getaverageSuccessRate("school")}";
            label13.Text = $"Average reading goal in your club is: {this.getaverageReadingGoalInClub()}";
            label14.Text = $"Average Reading goal success rate in your club is: {this.getaverageSuccessRate("club")}";
        }

        private float getMyAverageRating()
        {
            int totalRating = 0;
            int count = 0;
            foreach(BookHistory bh in this.getHistory())
            {
                if (bh.get_EndDate() != bh.get_StartDate())
                {
                    totalRating += bh.get_rate();
                    count++;
                }
            }
            return count!=0 ? (float)(totalRating / count): 0;
        }

        private string getShortestBookBorrow()
        {
            BookHistory shortest = Program.bookHistories[0];
            foreach(BookHistory bh in this.getHistory())
            {
                if (bh.get_EndDate() != bh.get_StartDate())
                {
                    if (bh.get_EndDate() - bh.get_StartDate() < shortest.get_StartDate() - shortest.get_EndDate())
                    {
                        shortest = bh;
                    }
                }
            }
            return getBorrowString(shortest);
        }

        private string getLongestBookBorrow()
        {
            BookHistory longest = Program.bookHistories[0];
            foreach (BookHistory bh in this.getHistory())
            {
                if (bh.get_EndDate() != bh.get_StartDate())
                {
                    if (bh.get_EndDate() - bh.get_StartDate() > longest.get_StartDate() - longest.get_EndDate())
                    {
                        longest = bh;
                    }
                }
            }
            return getBorrowString(longest);
        }


        private string getBorrowString(BookHistory bh)
        {
            int days = (bh.get_StartDate() - bh.get_EndDate()).Days;
            return $"{bh.get_book().get_title()}\nYou took it on {bh.get_StartDate().ToShortDateString()} \nand handed it back after {days} days";
        }

        private int getReadAmount() {
            List<BookHistory> allHistory = this.getHistory();
            return allHistory.Count();
        }

        private List<BookHistory> getHistory()
        {
            List<BookHistory> ans = new List<BookHistory>();
            foreach(BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student() == this.s)
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }

        private float getaverageReadingGoalInSchool()
        {
            return this.averageReadingGoal(this.allStudents);
        }
        private float getaverageReadingGoalInClub()
        {
            return this.averageReadingGoal(this.clubStudents);
        }

        private float getaverageSuccessRate(String s)
        {

            int totalGoal = 0;
            int totalRead = 0;
            if (s == "Schhol") {
                foreach (Student st in this.allStudents)
                {
                    totalGoal += st.get_yearlyGoal();
                }
                foreach (BookHistory bh in this.allSchoolHistory)
                {
                    if (bh.get_EndDate() != bh.get_StartDate())
                    {
                        totalRead++;
                    }
                }
            }
            else if (s == "Club") {
                foreach (Student st in this.clubStudents)
                {
                    totalGoal += st.get_yearlyGoal();
                }
                foreach (BookHistory bh in this.allClubHistory)
                {
                    if (bh.get_EndDate() != bh.get_StartDate())
                    {
                        totalRead++;
                    }
                }
            }
            return totalGoal!=0 ? (float)(totalRead/totalGoal): 0;
        }
        
        private float averageReadingGoal(List<Student> li)
        {
            int totalReadingGoal = 0;
            int count = 0;
            foreach (Student st in li)
            {
                totalReadingGoal += st.get_yearlyGoal();
                count++;
            }
            return count!=0 ? (float)(totalReadingGoal / count): 0;
        }
    }
}
