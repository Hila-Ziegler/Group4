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
    public partial class ReadingGoals : Form
    {
        Student s;
        public ReadingGoals(Student s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadingGoalReport rgr = new ReadingGoalReport(this.s);
            rgr.Show();
            this.Hide();
        }

        private void setGoalbtn_Click(object sender, EventArgs e)
        {
            this.s.set_yearlyGoal(int.Parse(numericYearlyGoal.Value.ToString()));
            this.s.update_Student();
        }

        private void ReadingGoals_Load(object sender, EventArgs e)
        {
            if (this.s.get_yearlyGoal() < 10)
            {
                numericYearlyGoal.Value = 2;
            }
            else numericYearlyGoal.Value = 20;
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(s);
            formStudentChooseAction.Show();
            this.Hide();
        }
    }
}
