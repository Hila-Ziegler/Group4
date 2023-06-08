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

        public System.Collections.Generic.List<Event> events = null;
        public System.Collections.Generic.List<Event> Oldevents = null;

        Student student = null;
        Teacher teacher = null;

        public AvailableEvent( Student stud)
        {            

          this.student = stud;
          System.Collections.Generic.List<Event> Allevents = Program.events;
          this.events = this.filterEvent(Allevents);
          this.Oldevents = this.FilterOldEvent(Allevents);


            InitializeComponent();
        }

        public AvailableEvent(Teacher teac)
        {
            this.teacher = teac;
            System.Collections.Generic.List<Event> Allevents = Program.events;
            this.events = this.filterEvent(Allevents);
            this.Oldevents = this.FilterOldEvent(Allevents);

            InitializeComponent();
        }
        private System.Collections.Generic.List<Event> filterEvent(System.Collections.Generic.List<Event> li)
        {
            System.Collections.Generic.List<Event> ans = new System.Collections.Generic.List<Event>();
            DateTime currentDateTime1 = DateTime.Now;

            if (student != null )
            {
                foreach (Event e in li)
                {
                    if (e.get_maxGuests() > e.get_currentlyRegistered() && e.get_date() > currentDateTime1) 
                    {
                        ans.Add(e);
                    }
                }
            }
            if (teacher != null)
            {
                foreach (Event e in li)
                {
                     if (e.get_date() > currentDateTime1) 
                     {
                    ans.Add(e);
                    }
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
                    this.dataGridView1.Rows[i].Cells[0].Value = e.get_guestName();
                    this.dataGridView1.Rows[i].Cells[1].Value = e.get_date();
                    this.dataGridView1.Rows[i].Cells[2].Value = e.get_currentlyRegistered();
                    this.dataGridView1.Rows[i].Cells[3].Value = e.get_maxGuests();



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
            if(student != null)
            {
                if (e.ColumnIndex == dataGridView1.Columns["GuestName"].Index)
                {
                    int i = e.RowIndex;
                    string guestName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    DateTime date = DateTime.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    Event ev =Program.seekEvent(date, guestName);
                    EventCrud formEventCrud = new EventCrud( student, ev);
                    formEventCrud.Show();
                    this.Hide();
                 }
            }
            if (teacher != null)
            {
                if (e.ColumnIndex == dataGridView1.Columns["GuestName"].Index)
                {
                    int i = e.RowIndex;
                    string guestName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    DateTime date = DateTime.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    Event ev = Program.seekEvent(date, guestName);
                    EventCrud formEventCrud = new EventCrud("",teacher,ev);
                    formEventCrud.Show();
                    this.Hide();
                }
            }


        }

        private void CreateNewEvent_Click(object sender, EventArgs e)
        {
            EventCrud formEventCrud = new EventCrud("new",teacher);
            formEventCrud.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }
        private System.Collections.Generic.List<Event> FilterOldEvent(System.Collections.Generic.List<Event> li)
        {
            System.Collections.Generic.List<Event> ansOld = new System.Collections.Generic.List<Event>();

            DateTime currentDateTime = DateTime.Now;
            foreach (Event e in li)
            {
                if(e.get_date()< currentDateTime)
                {
                    ansOld.Add(e);
                }

            }
            return ansOld;
        }

        private void update_OldEventList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.Oldevents;
            int i = 0;
            foreach (Event e in this.Oldevents)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = e.get_guestName();
                    this.dataGridView1.Rows[i].Cells[1].Value = e.get_date();
                    this.dataGridView1.Rows[i].Cells[2].Value = e.get_currentlyRegistered();
                    this.dataGridView1.Rows[i].Cells[3].Value = e.get_maxGuests();

                }

                i++;

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void ShowPastEvents_Click(object sender, EventArgs e)
        {
            update_OldEventList();
            btnFutureEvents.Show();
            ShowPastEvents.Hide();
        }
        private void AvailableEvent_Load(object sender, EventArgs e)
        {            
            if (teacher != null) 
            {
                homePageToolStripMenuItem.Visible = false;
            }
            update_EventList();
            btnFutureEvents.Hide();

        }

        private void btnFutureEvents_Click(object sender, EventArgs e)
        {
            update_EventList();
            btnFutureEvents.Hide();
            ShowPastEvents.Show();
        }
    }
}
