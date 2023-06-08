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
    public partial class DeleteEvent : Form
    {
        EventCrud ec;
        Event e;
        Teacher t;
        public DeleteEvent(EventCrud ec, Teacher t)
        {
            this.ec = ec;
            this.e = this.ec.getEvent();
            this.t = t;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.e.delete_Event();
            this.ec.Hide();
            AvailableEvent ae = new AvailableEvent(t);
            ae.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
