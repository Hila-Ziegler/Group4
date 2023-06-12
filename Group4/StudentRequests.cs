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
    public partial class StudentRequests : Form
    {
        Student student;
        public System.Collections.Generic.List<Request> requests = null;
        public StudentRequests(Student s)
        {
            this.student = s;
            this.requests = Program.requests;
            InitializeComponent();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(this.student);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void SizeAllColumns(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView2.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }

        
        private void StudentRequests_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = requests.ToArray();
            int i = 0;
            foreach (Request r in requests)
            {
                if (r.get_Student().get_ID() == this.student.get_ID())
                {
                    if (r.get_status().ToString() == "Open")
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = r.get_startDT();
                        this.dataGridView1.Rows[i].Cells[1].Value = r.get_copy().get_book().get_title();
                        this.dataGridView1.Rows[i].Cells[2].Value = r.get_status().ToString();
                        i++;
                    }
                }
            }
            this.dataGridView2.DataSource = requests.ToArray();
            int j = 0;
            foreach (Request r in requests)
            {
                if (r.get_Student().get_ID() == this.student.get_ID())
                {
                    if (r.get_status().ToString() != "Open")
                    {
                        this.dataGridView1.Rows[j].Cells[0].Value = r.get_startDT();
                        this.dataGridView1.Rows[j].Cells[1].Value = r.get_copy().get_book().get_title();
                        this.dataGridView1.Rows[j].Cells[2].Value = r.get_endDT();
                        this.dataGridView1.Rows[j].Cells[3].Value = r.get_status().ToString();
                        j++;
                    }
                }
            }
            SizeAllColumns(sender, e);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
