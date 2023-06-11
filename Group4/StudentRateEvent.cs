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
    public partial class StudentRateEvent : Form
    {
        Registration re;
        public StudentRateEvent(Registration re)
        {
            this.re = re;
            InitializeComponent();
        }

        private void StudentRateEvent_Load(object sender, EventArgs e)
        {
            label1.Text = $"Please rate the following event you took part in\n" +
                $"Guest: {this.re.GetEvent().get_guestName()}\n" +
                $"Event took place on the {this.re.GetEvent().get_date().ToShortDateString()}";
        }

        private void AddAReviewbtn_Click(object sender, EventArgs e)
        {
            re.set_rating(int.Parse(ratingComboBox.Text));
            re.set_review(ReviewTextBox.Text);
            re.update_Registration();
            this.Hide();
        }
    }
}
