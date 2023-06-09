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
    public partial class EventDateChangedMessage : Form
    {
        Registration r;
        public EventDateChangedMessage(Registration r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void EventDateChangedMessage_Load(object sender, EventArgs e)
        {
            DateChangedMessage.Text = $"The date of the event you Registered to has changed.\n" +
                $"{this.r.get_guestName()} will come to the school on the {this.r.get_eventDate().ToShortDateString()} \ninstead of the {this.r.get_oldDate()}\n" +
                $"We're looking forward to see you!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.r.set_oldDate("");
            this.r.update_Registration();
            this.Hide();
        }
    }
}
