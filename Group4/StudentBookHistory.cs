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
    public partial class StudentBookHistory : Form
    {
        string st = "";
        public System.Collections.Generic.List<BookHistory> History = null;

        public StudentBookHistory(string s)
        {
            System.Collections.Generic.List<BookHistory> AllBookHistory = Program.bookHistories;
            this.st = s;
            this.History = this.filterStudentBookHistory(AllBookHistory, st);
            InitializeComponent();
        }
        public StudentBookHistory()
        {
            InitializeComponent();
        }

        private System.Collections.Generic.List<BookHistory> filterStudentBookHistory(System.Collections.Generic.List<BookHistory> li, String sn)
        {
            System.Collections.Generic.List<BookHistory> ans = new System.Collections.Generic.List<BookHistory>();
            foreach (BookHistory bh in li)
            {
                if (bh.get_student().get_name() == sn)
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }
        private void update_BookHistoryList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.History;
            int i = 0;
            foreach (BookHistory c in this.History)
            {

                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = c.get_book().get_title();
                        this.dataGridView1.Rows[i].Cells[1].Value = c.get_book().get_sNumber();
                        this.dataGridView1.Rows[i].Cells[2].Value = c.get_StartDate();
                        this.dataGridView1.Rows[i].Cells[3].Value = c.get_EndDate();
                        this.dataGridView1.Rows[i].Cells[4].Value = c.get_rate();
                    }

                    i++;


            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void StudentBookHistory_Load(object sender, EventArgs e)
        {
            this.update_BookHistoryList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Title"].Index)
            {
                int i = e.RowIndex;
                string sn = dataGridView1.Rows[i].Cells[1].Value.ToString();
                Book b = Program.seekBook(sn);
               StudentBorrowActinos formStudentBorrow = new StudentBorrowActinos(st,b);
               formStudentBorrow.Show();
               this.Hide();
            }

        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(st);
            formStudentChooseAction.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
