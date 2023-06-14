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
        private int IDLength = 9;

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
                            try
                            {
                                StartBorrow.Hide();
                                    }
                            catch (Exception)
                            {
                                //
                            }
                            StID.Hide();
                            label5.Hide();
                            endBorrow1.Show();
                        }
                        else
                        {
                            this.dataGridView1.Rows[i].Cells[1].Value = bh.get_EndDate();
                            StartBorrow.Show();
                            StID.Show();
                            label5.Show();
                            try
                            {
                                endBorrow1.Hide();
                            }
                            catch (Exception)
                            {
                                //
                            }
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
            if (checkIfValid())
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

        private bool checkIfValid()
        {
            ErrorPage ep;
            if (StID.Text == "")
            {
                String str = $"Not all required information entered, \nPlease try again";
                ep = new ErrorPage(str);
                ep.Show();
                return false;
            }

            if (StID.Text.Length != IDLength)
            {
                // Error Window
                String stri = $"ID is not in the expected length, \nPlease enter a valid number of characters";
                ep = new ErrorPage(stri);
                ep.Show();
                return false;
            }


            int number;
            bool isNumeric = int.TryParse(StID.Text, out number);
            if (!isNumeric)
            {
                String strt = $"ID should not contain letters";
                ep = new ErrorPage(strt);
                ep.Show();
                return false;
            }
            foreach (Student stu in Program.students)
            {
                if (StID.Text == stu.get_ID())
                {
                    return true;
                }

            }
            // Error Window
            String strq = $"ID is not in the system, \nPlease enter a valid ID number";
            ep = new ErrorPage(strq);
            ep.Show();
            return false;
        }

    }
}
