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
        public static System.Collections.Generic.List<Request> requests = Program.requests;
        Librarian librarian = null;

        public ManageRequests(Librarian l)
        {
            this.librarian = l;
            InitializeComponent();
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
                if (r.GetType().ToString() == "TimeExtention")
                {
                    if (r.get_status().ToString() != "Approved" || r.get_status().ToString() != "Declined" )
                    {
                    this.dataGridView1.Rows[i].Cells[0].Value = r.get_startDT();
                    this.dataGridView1.Rows[i].Cells[1].Value = r.get_Student().get_ID();
                    this.dataGridView1.Rows[i].Cells[2].Value = r.get_copy().get_book().get_sNumber();
                    this.dataGridView1.Rows[i].Cells[3].Value = r.get_copy().get_copyNum();
                    i++;
                     }
                }
            }
            this.dataGridView2.DataSource = requests.ToArray();
            int j = 0;
            foreach (Request r in requests)
            {
                if (r.GetType().ToString() == "AlternativeBook")
                    if (r.get_status().ToString() != "Approved" || r.get_status().ToString() != "Declined")
                    {
                    this.dataGridView1.Rows[i].Cells[0].Value = r.get_startDT();
                    this.dataGridView1.Rows[i].Cells[1].Value = r.get_Student().get_ID();
                    this.dataGridView1.Rows[i].Cells[2].Value = r.get_copy().get_book().get_sNumber();
                    this.dataGridView1.Rows[i].Cells[3].Value = r.get_copy().get_copyNum();
                    this.dataGridView1.Rows[i].Cells[4].Value = r;
                    j++;
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
                //Request r = dataGridView1.Rows[i].Cells[4];
                //RequestDeat formRequestDeat = new RequestDeat(sd);
                //form10.Show();
                this.Hide();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction formLibrarianChooseAction = new LibrarianChooseAction(librarian);
            formLibrarianChooseAction.Show();
            this.Hide();
        }
    }
}
