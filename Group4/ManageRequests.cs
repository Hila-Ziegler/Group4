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
    public partial class ManageRequests : Form
    {
        public System.Collections.Generic.List<Request> requests = null;
        Librarian librarian = null;

        public ManageRequests(Librarian l)
        {
            this.librarian = l;
            System.Collections.Generic.List<Request> allRequests = Program.requests;
            this.requests = this.filterRequestList(allRequests);
            InitializeComponent();
        }

        private System.Collections.Generic.List<Request> filterRequestList(System.Collections.Generic.List<Request> li)
        {
            System.Collections.Generic.List<Request> ans = new System.Collections.Generic.List<Request>();
            foreach (Request r in li)
            {
                if (r.get_status().ToString() != "Approved" || r.get_status().ToString() != "Declined")
                {
                    ans.Add(r);
                }
            }
            return ans;
        }

        private void SizeAllColumns(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ManageRequests_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = requests.ToArray();
            int i = 0;
            foreach (Request r in requests)
            {
                if (r.get_Librarian().get_ID() == librarian.get_ID())
                {
                if (r.get_type().ToString() == "TimeExtention")
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = r.get_startDT();
                    this.dataGridView1.Rows[i].Cells[1].Value = r.get_Student().get_ID();
                    this.dataGridView1.Rows[i].Cells[2].Value = "View";
                    i++;
                }

                }
            }
            this.dataGridView2.DataSource = requests.ToArray();
            int j = 0;
            foreach (Request r in requests)
            {
                if (r.get_Librarian().get_ID() == librarian.get_ID())
                {
                    if (r.get_type().ToString() == "AlternativeBook")
                {
                    this.dataGridView2.Rows[j].Cells[0].Value = r.get_startDT();
                    this.dataGridView2.Rows[j].Cells[1].Value = r.get_Student().get_ID();
                    this.dataGridView2.Rows[j].Cells[2].Value = "View";
                    j++;
                }
                }


            }
            SizeAllColumns(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Actions"].Index)
            {
                int i = e.RowIndex;

                DateTime sd = DateTime.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Student sid = Program.seekStudent(dataGridView1.Rows[i].Cells[1].Value.ToString());
                Request r = Program.SeekRequest(sd, this.librarian, sid);
                RequestDeat formRequestDeat = new RequestDeat(r, this.librarian);
                formRequestDeat.Show();
                this.Hide();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Actions1"].Index)
            {
                int i = e.RowIndex;

                DateTime sd = DateTime.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                Student sid = Program.seekStudent(dataGridView1.Rows[i].Cells[1].Value.ToString());
                Request r = Program.SeekRequest(sd, this.librarian, sid);
                RequestDeat formRequestDeat = new RequestDeat(r, this.librarian);
                formRequestDeat.Show();
                this.Hide();
            }
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction formLibrarianChooseAction = new LibrarianChooseAction(librarian);
            formLibrarianChooseAction.Show();
            this.Hide();
        }
    }
}
