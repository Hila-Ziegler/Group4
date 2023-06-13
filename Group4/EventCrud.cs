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
            if(ev == null)
            {
                return;
            }
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
            eventsPriceValuelbl.Text = ev.get_price().ToString();
        }

        private void setValuesForUpdate()
        {
            EventDatePicker.Value = ev.get_date();
            GuestNameTextBox.Text = ev.get_guestName();
            numericMaxAttendance.Minimum = ev.get_currentlyRegistered();
            numericMaxAttendance.Value = ev.get_maxGuests();
            if (ev.get_Status().ToString() == "Open")
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
            if (this.ev != null)
            {
                if (this.ev.get_date() > DateTime.Now)
                {
                    finalRatingScore.Hide();
                    WatchReviews.Hide();
                }
                else
                {
                    this.setFinalRatingScore();
                }
            }
            else
            {
                WatchReviews.Hide();
                finalRatingScore.Hide();
            }
            if(s != null)
            {
                UpdateEvent.Hide();
                CreateNewEvent.Hide();
                DeleteEvent.Hide();
                updateEventbtn.Hide();
                GuestName.Hide();
                GuestNameTextBox.Hide();
                EventDatePicker.Hide();
                GuestTypeComboBox.Hide();
                numericMaxAttendance.Hide();
                OpenForRegistrationCheckBox.Hide();
                numericPrice.Hide();
                EventPricelbl.Hide();
                eventsPriceValuelbl.Hide();

                if(this.ev.Registered.Contains(this.s) || this.ev.get_currentlyRegistered() >= this.ev.get_maxGuests())
                {
                    RegisterBTN.Hide();
                }

                this.setValuesFromEvent();
            }
            else if (t != null)
            {
                RegisterBTN.Hide();
                homePageToolStripMenuItem.Visible = false;


                //homePageToolStripMenuItem hide homepage button
                if (st == "update")
                {
                    CreateNewEvent.Hide();
                    UpdateEvent.Hide();
                    DeleteEvent.Hide();
                    SpeakerName.Hide();
                    CurrentAtten.Hide();
                    CreateNewEvent.Hide();


                    this.setValuesForUpdate();

                }
                else if(st == "new")
                {
                    updateEventbtn.Hide();
                    SpeakerName.Hide();
                    RegisterBTN.Hide();
                    UpdateEvent.Hide();
                    DeleteEvent.Hide();
                    CurrentAtten.Hide();

                }
                else
                {
                    updateEventbtn.Hide();
                    GuestName.Hide();
                    GuestNameTextBox.Hide();
                    EventDatePicker.Hide();
                    GuestTypeComboBox.Hide();
                    numericMaxAttendance.Hide();
                    OpenForRegistrationCheckBox.Hide();
                    numericPrice.Hide();
                    CreateNewEvent.Hide();

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
            if (s != null)
            {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(s);
            formStudentChooseAction.Show();
            this.Hide();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
            AvailableEvent formAvailableEvent = new AvailableEvent(t);
            formAvailableEvent.Show();
            this.Hide();
            }
            else if (s != null)
            {
                AvailableEvent formAvailableEvent = new AvailableEvent(s);
                formAvailableEvent.Show();
                this.Hide();
            }

        }

        private void CreateNewEvent_Click(object sender, EventArgs e)
        {
            if (GuestNameTextBox.Text != "")
            {
                GuestType gt = (GuestType)Enum.Parse(typeof(GuestType), GuestTypeComboBox.Text);
                DateTime dt = DateTime.Parse(EventDatePicker.Value.ToString());
                Status st = OpenForRegistrationCheckBox.Checked ? (Status)Enum.Parse(typeof(Status), "Open") : (Status)Enum.Parse(typeof(Status), "Closed");
                int num = Program.events.Count + 1;
                Event newE = new Event(gt, dt, float.Parse(numericPrice.Value.ToString()), GuestNameTextBox.Text, st, int.Parse(numericMaxAttendance.Value.ToString()), 0, num, true);
                t.addEvent(newE);
                EventCrud form24 = new EventCrud("", this.t, newE);
                form24.Show();
                this.Hide();
            }
            else
            {
                string str = "Invalid Guest Name.";
                IncorrectInformation inin = new IncorrectInformation(str);
                inin.Show();
            }
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            //testing
            DeleteEvent form25 = new DeleteEvent(this,this.t);
            form25.Show();

        }

        public Event getEvent()
        {
            return this.ev;
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            EventCrud form24 = new EventCrud("update", this.t, this.ev);
            form24.Show();
            this.Hide();
        }

        private void updateEventbtn_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(EventDatePicker.Value.ToString()) != this.ev.get_date())
            {
                foreach (Registration re in Program.registrations)
                {
                    if(this.ev.getNum() == re.GetEvent().getNum())
                    {
                        re.set_oldDate(this.ev.get_date().ToShortDateString());
                        re.update_Registration();
                    }
                }
            }
            this.ev.set_guestName(GuestNameTextBox.Text);
            this.ev.set_date(DateTime.Parse(EventDatePicker.Value.ToString()));
            this.ev.set_guestType((GuestType)Enum.Parse(typeof(GuestType), GuestTypeComboBox.Text));
            this.ev.set_maxGuests(int.Parse(numericMaxAttendance.Value.ToString()));
            this.ev.set_price(float.Parse(numericPrice.Value.ToString()));
            this.ev.set_Status(OpenForRegistrationCheckBox.Checked ? (Status)Enum.Parse(typeof(Status), "Open") : (Status)Enum.Parse(typeof(Status), "Closed"));
            this.ev.update_Event();

            EventCrud form24 = new EventCrud("", this.t, this.ev);
            form24.Show();
            this.Hide();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            this.ev.Registered.Add(this.s);
            Registration newReg = new Registration(this.s, false, "", 0,this.ev ,"", true);
            this.ev.set_currentlyRegistered(this.ev.get_currentlyRegistered() + 1);
            this.ev.update_Event();
            EventCrud form24 = new EventCrud(this.s, this.ev);
            form24.Show();
            this.Hide();

        }

        private List<Registration> GetRegistrations()
        {
            List<Registration> ans = new List<Registration>();
            foreach(Registration r in Program.registrations)
            {
                if (r.GetEvent() == this.ev)
                {
                    ans.Add(r);
                }
            }
            return ans;
        }

        private void WatchReviews_Click(object sender, EventArgs e)
        {
            EventReviews evre = new EventReviews(this.ev);
            evre.Show();
        }

        private void setFinalRatingScore()
        {
            int counter = 0;
            int score = 0;
            foreach (Registration re in Program.registrations)
            {
                if (re.GetEvent().getNum() == this.ev.getNum())
                {
                    if(re.get_rating() != 0)
                    {
                        counter++;
                        score += re.get_rating();
                    }
                }
            }
            finalRatingScore.Text = $"Event's Final Rating: {(float)(score/counter)}";

        }

        private void GuestTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void finalRatingScore_Click(object sender, EventArgs e)
        {

        }
    }
}
