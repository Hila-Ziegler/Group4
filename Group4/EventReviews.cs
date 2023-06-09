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
    public partial class EventReviews : Form
    {
        Event ev;
        List<Registration> registered;
        public EventReviews(Event ev)
        {
            this.ev = ev;
            this.registered = this.getRegistrations();
            InitializeComponent();
        }

        private void EventReviews_Load(object sender, EventArgs e)
        {
            this.updateReviews();
        }

        private void updateReviews()
        {
            this.dataGridView1.DataSource = this.registered;
            int i = 0;
            foreach (Registration re in this.registered)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = re.get_student().get_name();
                    this.dataGridView1.Rows[i].Cells[1].Value = re.get_review();
                }

                i++;


            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private List<Registration> getRegistrations()
        {
            List<Registration> li = new List<Registration>();
            foreach(Registration re in Program.registrations)
            {
                if(re.GetEvent().getNum() == this.ev.getNum() && re.get_review()!= "" && re.get_showedUp())
                {
                    li.Add(re);
                }
            }
            return li;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
