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
    public partial class socialPage : Form
    {
        public  System.Collections.Generic.List<Student> students;
        Student student;

        public socialPage(Student stud)
        {
            this.student = stud;
            this.students = Program.students;
            InitializeComponent();
        }
        private void update_socialPage()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.students;
            int i = 0;
            foreach (Student s in this.students)
            {

                if (i < dataGridView1.Rows.Count)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = s.get_name();
                    this.dataGridView1.Rows[i].Cells[1].Value = s.get_age();
                    this.dataGridView1.Rows[i].Cells[1].Value = s.get_club();

                }

                i++;

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void socialPage_Load(object sender, EventArgs e)
        {
            update_socialPage();
        }
    }
}
