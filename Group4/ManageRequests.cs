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
        Librarian l = null;

        public ManageRequests(Librarian l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void ManageRequests_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Actions"].Index)
            {
                int i = e.RowIndex;
                DateTime sd = DateTime.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                //BookCrud form10 = new BookCrud(sd);
                //form10.Show();
                this.Hide();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
