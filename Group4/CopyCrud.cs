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
    public partial class CopyCrud : Form
    {
        private Copy copy;
        private System.Collections.Generic.List<BookHistory> history;
        private Librarian librarian;
        public CopyCrud(Copy c, Librarian libr)
        {
            librarian = libr;
            this.copy = c;
            this.history = this.getCopyHistory();
            InitializeComponent();
        }

        private System.Collections.Generic.List<BookHistory> getCopyHistory()
        {
            System.Collections.Generic.List<BookHistory> ans = new System.Collections.Generic.List<BookHistory>();
            foreach (BookHistory bh in Program.bookHistories)
            {
                if (bh.get_copyNum() == copy.get_copyNum() && bh.get_book() == copy.get_book())
                {
                    ans.Add(bh);
                }
            }
            return ans;
        }

        public void updateBookHistory()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.history;
            int i = 0;
            foreach (BookHistory bh in this.history)
            {
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = bh.get_StartDate();
                        if (bh.get_StartDate() == bh.get_EndDate() && this.copy.get_status() == true)
                        {
                            this.dataGridView1.Rows[i].Cells[1].Value = DBNull.Value;
                            StartBorrow.Visible = false;
                            StName.Visible = false;
                            label4.Visible = false;
                            StID.Visible = false;
                            label5.Visible = false;
                            endBorrow1.Visible = true;
                        }
                        else
                        {
                            this.dataGridView1.Rows[i].Cells[1].Value = bh.get_EndDate();
                            StartBorrow.Visible = true;
                            StName.Visible = true;
                            label4.Visible = true;
                            StID.Visible = true;
                            label5.Visible = true;
                            endBorrow1.Visible = false;
                        }
                        this.dataGridView1.Rows[i].Cells[2].Value = bh.get_student().get_name();
                        this.dataGridView1.Rows[i].Cells[3].Value = bh.get_student().get_ID();
                        this.dataGridView1.Rows[i].Cells[4].Value = bh.get_rate();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(bh.get_StartDate(), bh.get_EndDate(), bh.get_student().get_name(), bh.get_student().get_ID(), bh.get_rate());
                    }
                    i++;
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void CopyCrud_Load(object sender, EventArgs e)
        {
            if (this.copy.get_deleted() == true)
            {
                StartBorrow.Visible = false;
            }
            if (this.copy.get_status() == false)
            {
                endBorrow1.Visible = false;
            }
            if (copy != null)
            {
                Book b = copy.get_book();
                CopyCrudTitle.Text = b.get_title();
                CopyCrudCopyNum.Text = copy.get_copyNum().ToString();
                this.updateBookHistory();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction form6 = new LibrarianChooseAction(librarian);
            form6.Show();
            this.Hide();
        }

        private void MenuManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks form7 = new ManageBooks(librarian);
            form7.Show();
            this.Hide();
        }

        private void StartBorrow_Click(object sender, EventArgs e)
        {
            Student st = Program.seekStudent(StID.Text);
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            BookHistory bh = new BookHistory(this.copy.get_copyNum(), this.copy.get_book(), st, startDate, endDate, 0, true);
            this.history.Add(bh);
            st.addBookHistory(bh);
            copy.get_book().addBookHistory(bh);
            this.copy.set_status(true);
            this.copy.update_Copy();
            this.updateBookHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lastIndex = this.history.Count - 1;
            if (lastIndex >= 0)
            {
                BookHistory lastRecord = this.history[lastIndex];
                lastRecord.set_endDate(DateTime.Now);
                lastRecord.update_BookHistory();
                this.copy.set_status(false);
                this.copy.update_Copy();
                this.updateBookHistory();
            }
        }
    }
}
