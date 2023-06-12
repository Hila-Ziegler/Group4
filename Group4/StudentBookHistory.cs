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
        private Student student;
        private System.Collections.Generic.List<BookHistory> history;

        public StudentBookHistory(Student stud)
        {
            student = stud;
            this.history = this.filterStudentBookHistory();
            InitializeComponent();
        }

        private System.Collections.Generic.List<BookHistory> filterStudentBookHistory()
        {
            System.Collections.Generic.List<BookHistory> ans = new System.Collections.Generic.List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_student() == this.student)
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }
        private void update_BookHistoryList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.history;
            int i = 0;
            foreach (BookHistory bh in this.history)
            {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = bh.get_book().get_title();
                        this.dataGridView1.Rows[i].Cells[1].Value = bh.get_book().get_sNumber();
                        this.dataGridView1.Rows[i].Cells[2].Value = bh.get_copyNum();
                        this.dataGridView1.Rows[i].Cells[3].Value = bh.get_StartDate();
                        if (bh.get_StartDate() == bh.get_EndDate())
                        {
                            this.dataGridView1.Rows[i].Cells[4].Value = DBNull.Value;
                        }
                        else
                        {
                            this.dataGridView1.Rows[i].Cells[4].Value = bh.get_EndDate();
                        }
                        this.dataGridView1.Rows[i].Cells[5].Value = bh.get_rate();
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
               int c = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
               DateTime st = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
               BookHistory bhRecord = this.history.Find(history => history.get_book().get_sNumber() == sn && history.get_copyNum() == c && history.get_StartDate() == st);
               StudentBorrowActinos formStudentBorrowActions = new StudentBorrowActinos(bhRecord);
               formStudentBorrowActions.Show();
               this.Hide();
            }
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(student);
            formStudentChooseAction.Show();
            this.Hide();
        }
    }
}
