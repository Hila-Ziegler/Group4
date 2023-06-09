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
    public partial class StudentChooseAction : Form
    {

       // String st = "";
        Student student = null;

        public StudentChooseAction(Student stud)
        {
            //st = s;
            student = stud;
            InitializeComponent();
            //this.st = s;
        }


        private void btnBooks_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory(student);
            formStudentBookHistory.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            AvailableEvent formAvailableEvent = new AvailableEvent(student);
            formAvailableEvent.Show();
            this.Hide();

        }

        private void StudentChooseAction_Load(object sender, EventArgs e)
        {
            tlxWalcome.Text = $"Welcome {student.get_name()}";
            foreach (Registration re in Program.registrations)
            {
                if (re.get_oldDate() != "" && re.get_student().get_ID() == this.student.get_ID())
                {
                    EventDateChangedMessage edcm = new EventDateChangedMessage(re);
                    edcm.Show();
                }
            }
;        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            studentAllMessagescs  formstudentAllMessagescs = new studentAllMessagescs(student);
            formstudentAllMessagescs.Show();
            this.Hide();
        }

        private void readingGoalsbtn_Click(object sender, EventArgs e)
        {
            ReadingGoals form30 = new ReadingGoals(this.student);
            form30.Show();
            this.Hide();
        }

        private void btnSocialPage_Click(object sender, EventArgs e)
        {
            socialPage formsocialPage = new socialPage(this.student);
            formsocialPage.Show();
            this.Hide();
        }
    }
}
