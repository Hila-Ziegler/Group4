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
    public partial class BookCrud : Form
    {
        private Book b = null;
        private string sn = "";
        public System.Collections.Generic.List<Copy> copies = null;

        public BookCrud(string s)
        {
            System.Collections.Generic.List<Copy> allCopies = Program.copies;
            this.copies = Program.copies;
            this.sn = s;
            this.copies = this.filterCopyList(allCopies);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BookCrudHomePage_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction form8 = new LibrarianChooseAction();
            form8.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private System.Collections.Generic.List<Copy> filterCopyList(System.Collections.Generic.List<Copy> li)
        {
            System.Collections.Generic.List<Copy> ans = new System.Collections.Generic.List<Copy>();
            foreach (Copy c in li)
            {
            if (c.get_book().get_sNumber() == sn){
                    ans.Add(c);
                }
            }
            return ans;
        }

        private void update_CopyList()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.copies;
            int i = 0;
            foreach (Copy c in this.copies)
            {
                if (c.get_book().get_sNumber() == sn)
                {
                    if (i < dataGridView1.Rows.Count)
                    {
                        this.dataGridView1.Rows[i].Cells[0].Value = c.get_copyNum();
                        this.dataGridView1.Rows[i].Cells[1].Value = c.get_status();
                    }
                    else
                    {
                        dataGridView1.Rows.Add(c.get_copyNum(), c.get_status());
                    }
                    i++;
                }

            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Console.WriteLine("Copy list updated");
        }

        private void BookCrud_Load(object sender, EventArgs e)
        {
            if (sn != null)
            {
                this.b = Program.seekBook(sn);
                lb_ISBN_value.Text = sn;
                lb_AuthorValue.Text = b.get_author();
                lb_PublishYearValue.Text = b.get_PYear().ToString();
                lb_LangueageValue.Text = b.get_lang().ToString();
                lb_RatingValue.Text = b.get_rating().ToString();
                BookCrudTitle.Text = b.get_title();

                this.update_CopyList();
            }





        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bookCrudAddNewCopy_Click(object sender, EventArgs e)
        {
            if (this.b != null)
            {
                Copy c = new Copy(copies.Count()+1, b, false, true);
                c.create_Copy();
                b.addCopy(c);
                this.copies.Add(c);
                Program.copies.Add(c);
                Console.WriteLine("Copy Created");
                this.update_CopyList();

            }
        }
    }
}
