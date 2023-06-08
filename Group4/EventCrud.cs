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
    public partial class EventCrud : Form
    {
        string st = "";
        Student student = null;
        public EventCrud(Student s)
        {
            InitializeComponent();
            student = s;
            //this.st = st;
        }
        public EventCrud()
        {
            InitializeComponent();
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void Titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void EventCrud_Load(object sender, EventArgs e)
        {

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableEvent formAvailableEvent = new AvailableEvent(student);
            formAvailableEvent.Show();
            this.Hide();
        }
    }
}
