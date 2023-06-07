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
    public partial class AdminGridView : Form
    {
        private List<Librarian> libs;
        private List<Student> studs;
        private List<Teacher> teachers;
        private string type;
        public AdminGridView(string s)
        {
            this.type = s;
            setList();
            InitializeComponent();
        }
        private void setList()
        {
            if (this.type == "s")
            {
                studs = Program.students;
            }
            else if (this.type == "t")
            {
                teachers = Program.teachers;
            }
            else if (this.type == "l")
            {
                libs = Program.librarians;
            }
            
        }
        private void loadGrid()
        {
            if (this.libs != null)
            {
                this.loadLibrarians();
            }
            else if(this.studs != null)
            {
                this.loadStudents();
            }
            else if (this.teachers != null)
            {
                this.loadTeachers();
            }

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void loadStudents()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.studs;
            int i = 0;
            foreach (Student s in this.studs)
            {
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = s.get_ID();
                        this.dataGridView1.Rows[i].Cells[1].Value = s.get_name();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(s.get_ID(), s.get_name());
                    }
                    i++;
                }

            }
        }
        private void loadTeachers()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.teachers;
            int i = 0;
            foreach (Teacher t in this.teachers)
            {
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = t.get_ID();
                        this.dataGridView1.Rows[i].Cells[1].Value = t.get_name();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(t.get_ID(), t.get_name());
                    }
                    i++;
                }

            }

        }
        private void loadLibrarians()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.libs;
            int i = 0;
            foreach (Librarian l in this.libs)
            {
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = l.get_ID();
                        this.dataGridView1.Rows[i].Cells[1].Value = l.get_name();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(l.get_ID(), l.get_name());
                    }
                    i++;
                }

            }
        }

        private void AdminGridView_Load(object sender, EventArgs e)
        {
            this.loadGrid();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            AdminActions form16 = new AdminActions();
            form16.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ID"].Index)
            {
                int i = e.RowIndex;
                string sn = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (Program.seekLibrarian(sn) != null)
                {
                    LibrarianCrud form16 = new LibrarianCrud(Program.seekLibrarian(sn));
                    form16.Show();
                    this.Hide();
                }
                else if (Program.seekStudent(sn) != null)
                {
                    StudentCrud form16 = new StudentCrud(Program.seekStudent(sn));
                    form16.Show();
                    this.Hide();
                }
                else if (Program.seekTeacher(sn) != null)
                {
                    TeacherCrud form16 = new TeacherCrud(Program.seekTeacher(sn));
                    form16.Show();
                    this.Hide();
                }
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (this.type == "s")
            {
                StudentCrud form22 = new StudentCrud(null);
                form22.Show();
                this.Hide();
            }
            else if (this.type == "l")
            {
                LibrarianCrud form23 = new LibrarianCrud(null);
                form23.Show();
                this.Hide();
            }
            else
            {
                TeacherCrud form24 = new TeacherCrud(null);
                form24.Show();
                this.Hide();
            }
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminActions form16 = new AdminActions();
            form16.Show();
            this.Hide();
        }
    }
}
