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
    public partial class ManageWaitList : Form
    {
        private Book b;
        private List<BookInWaitlist> waitList;
        public ManageWaitList(Book b)
        {
            this.b = b;
            InitializeComponent();
        }

        private List<BookInWaitlist> getWaitList()
        {
            List<BookInWaitlist> li = new List<BookInWaitlist>();
            foreach(BookInWaitlist biw in Program.booksInWaitlist)
            {
                if(biw.get_Book().get_sNumber() == this.b.get_sNumber())
                {
                    li.Add(biw);
                }
            }
            return li;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Load_IDs()
        {
            List<string> li = new List<string>();
            foreach (Student s in Program.students)
            {
                li.Add(s.get_ID());
            }
            StudentIDComboBox.DataSource = li;
        }

        private void addToWaitListbtn_Click(object sender, EventArgs e)
        {
            if(StudentIDComboBox.Text != "" || StudentIDComboBox.Text != null)
            {
                BookInWaitlist newWaitList = new BookInWaitlist(DateTime.Now,Program.seekStudent(StudentIDComboBox.Text), this.b, true, true );
                this.loadDataGrid();
            }
        }

        private void ManageWaitList_Load(object sender, EventArgs e)
        {
            this.Load_IDs();
            this.loadDataGrid();
        }

        private void loadDataGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.getWaitList();
            this.waitList = this.getWaitList();
            int i = 0;
            foreach (BookInWaitlist biw in this.getWaitList())
            {
                if (biw.getInList()) {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = biw.get_Student().get_ID();
                        this.dataGridView1.Rows[i].Cells[1].Value = biw.get_startDT();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(biw.get_Student().get_ID(), biw.get_startDT());
                    }
                    i++;
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
