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
        Student s = null;
        Teacher t = null;
        Event ev = null;
        public EventCrud(string st, Teacher t)
        {
            this.st = st;
            this.t = t;
            InitializeComponent();
        }
        public EventCrud(Student s, Event ev)
        {
            this.s = s;
            this.ev = ev;
            InitializeComponent();
        }
        public EventCrud(string st, Teacher t, Event ev)
        {
            this.t = t;
            this.st = st;
            this.ev = ev;
            InitializeComponent();
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void Titlelbl_Click(object sender, EventArgs e)
        {

        }

        private void setValuesFromEvent()
        {
            lb_Date_value.Text = ev.get_date().ToString();
            lb_MaxAttendanceValue.Text = ev.get_maxGuests().ToString();
            if (ev.get_Status().ToString() == "Open")
            {
                OpenForRegistrationValuelb.Text = "Yes";
            }
            else
            {
                OpenForRegistrationValuelb.Text = "No";
            }
            lb_CurrentAttendanceValue.Text = ev.get_currentlyRegistered().ToString();
            GuestTypeValue.Text = ev.get_guestType().ToString();
            SpeakerName.Text = ev.get_guestName();
        }

        private void setValuesForUpdate()
        {
            EventDatePicker.Text = ev.get_date().ToString();
            GuestNameTextBox.Text = ev.get_guestName();
            numericMaxAttendance.Minimum = ev.get_currentlyRegistered();
            //numericMaxAttendance set value
            if(ev.get_Status().ToString() == "Open")
            {
                OpenForRegistrationCheckBox.Checked = true;
            }
            else
            {
                OpenForRegistrationCheckBox.Checked = false;
            }
            numericPrice.Value = (decimal)ev.get_price();
            GuestTypeComboBox.Text = ev.get_guestType().ToString();
        }
        private void EventCrud_Load(object sender, EventArgs e)
        {
            this.Load_Enum();
            if(s != null)
            {
                UpdateEvent.Hide();
                CreateNewEvent.Hide();
                DeleteEvent.Hide();
                updateEventbtn.Hide();
                GuestName.Hide();
                GuestNameTextBox.Hide();
                EventDatePicker.Hide();

                this.setValuesFromEvent();
            }
            else if (t != null)
            {
                RegisterBTN.Hide();
                if (st == "update")
                {
                    CreateNewEvent.Hide();
                    UpdateEvent.Hide();
                    DeleteEvent.Hide();
                    SpeakerName.Hide();
                    CurrentAtten.Hide();

                    this.setValuesForUpdate();

                }
                else
                {
                    updateEventbtn.Hide();
                    GuestName.Hide();
                    GuestNameTextBox.Hide();
                    EventDatePicker.Hide();

                    this.setValuesFromEvent();
                }
            }
        }

        private void Load_Enum()
        {
            List<KeyValuePair<string, string>> guesttypelist = new List<KeyValuePair<string, string>>();
            Array guestTypes = Enum.GetValues(typeof(GuestType));
            foreach (GuestType guestType in guestTypes)
            {
                guesttypelist.Add(new KeyValuePair<string, string>(guestType.ToString(), ((int)guestType).ToString()));
            }
            GuestTypeComboBox.DataSource = guesttypelist;
            GuestTypeComboBox.DisplayMember = "Key";
            GuestTypeComboBox.ValueMember = "Value";
            GuestTypeComboBox.SelectedIndex = 1;
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(st);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvailableEvent formAvailableEvent = new AvailableEvent(st);
            formAvailableEvent.Show();
            this.Hide();
        }
    }
}
