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
        String st = "";
        public StudentChooseAction(string s)
        {
            InitializeComponent();
            this.st = s;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            StudentBookHistory formStudentBookHistory = new StudentBookHistory();
            formStudentBookHistory.Show();
            this.Hide();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            AvailableEvent formAvailableEvent = new AvailableEvent(st);
            formAvailableEvent.Show();
            this.Hide();
        }

        private void StudentChooseAction_Load(object sender, EventArgs e)
        {
            tlxWalcome.Text = $"Welcome {st}";
;        }
    }
}
