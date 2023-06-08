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
    public partial class AvailableEvent : Form
    {
        string st = "";
        public System.Collections.Generic.List<Event> events = null;
        Student student = null;
        Teacher teacher = null;

        public AvailableEvent( Student stud)
        {            
        //  this.st = st;
          this.student = stud;
          System.Collections.Generic.List<Event> Allevents = Program.events;
          this.events = this.filterEvent(Allevents, st);

            InitializeComponent();
        }

        public AvailableEvent(Teacher teac)
        {
            this.teacher = teac;
            System.Collections.Generic.List<Event> Allevents = Program.events;
            this.events = this.filterEvent(Allevents, st);

            InitializeComponent();
        }
        private System.Collections.Generic.List<Event> filterEvent(System.Collections.Generic.List<Event> li, String sn)
        {
            System.Collections.Generic.List<Event> ans = new System.Collections.Generic.List<Event>();
            if(Program.seekStudent(student.get_ID()) != null)
            {
                foreach (Event e in li)
                {
                    if (e.get_maxGuests() > e.get_currentlyRegistered()) // add filter for event date 
                    {
                        ans.Add(e);
                    }
                }
            }
            if (Program.seekTeacher(teacher.get_ID()) != null)
            {
                foreach (Event e in li)
                {
                   // if (e.get_maxGuests() > e.get_currentlyRegistered()) // add filter for event date 
                   // {
                        ans.Add(e);
                 //   }
                }
            }

            return ans;
        }
        private void update_EventList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.events;
            int i = 0;
            foreach (Event e in this.events)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = e.get_Teacher().get_name();
                    this.dataGridView1.Rows[i].Cells[1].Value = e.get_guestName();
                    this.dataGridView1.Rows[i].Cells[2].Value = e.get_date();
                    this.dataGridView1.Rows[i].Cells[3].Value = e.get_currentlyRegistered();
                    this.dataGridView1.Rows[i].Cells[4].Value = e.get_maxGuests();
                }

                i++;


            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            EventCrud formEventCrud = new EventCrud(st);
            formEventCrud.Show();
            this.Hide();
        }

        private void CreateNewEvent_Click(object sender, EventArgs e)
        {
            EventCrud formEventCrud = new EventCrud(st);
            formEventCrud.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void AvailableEvent_Load(object sender, EventArgs e)
        {
            update_EventList();
            if (Program.seekTeacher(teacher.get_ID()) == null)
            {
                homePageToolStripMenuItem.HideDropDown();
            }

        }
    }
}
