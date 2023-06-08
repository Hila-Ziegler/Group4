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
    public partial class ManageBooks : Form
    {
        public static System.Collections.Generic.List<Book> books = Program.books;
        Librarian librarian;
        public ManageBooks(Librarian libr)
        {
            librarian = libr;
            InitializeComponent();
        }
        private void SizeAllColumns(Object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Title"].Index)
            {
                int i = e.RowIndex;
                string sn = dataGridView1.Rows[i].Cells[0].Value.ToString();
                BookCrud form10 = new BookCrud(sn, librarian);
                form10.Show();
                this.Hide();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void BookCrud_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = books.ToArray();
            int i = 0;
            foreach (Book b in books) {
                if (!b.get_archive())
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = b.get_sNumber();
                    this.dataGridView1.Rows[i].Cells[1].Value = b.get_title();
                    this.dataGridView1.Rows[i].Cells[2].Value = b.get_author();
                    this.dataGridView1.Rows[i].Cells[3].Value = b.get_lang();
                    this.dataGridView1.Rows[i].Cells[4].Value = b.Copies.Count();
                    this.dataGridView1.Rows[i].Cells[5].Value = b.get_PYear();
                    i++;
                }
            }
            SizeAllColumns(sender, e);


        }


        private void AddNewBook_Click(object sender, EventArgs e)
        {
            BookCrud form5 = new BookCrud(null,librarian);
            form5.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageBooksHomePagemenu_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction form9 = new LibrarianChooseAction(librarian);
            form9.Show();
            this.Hide();
        }

        private void BookManagmentGoToArchieve_Click(object sender, EventArgs e)
        {
           // BookManagmentGoToArchieve.Hide();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = books.ToArray();
            int i = 0;
            foreach (Book b in books)
            {
                if (b.get_archive())
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = b.get_sNumber();
                    this.dataGridView1.Rows[i].Cells[1].Value = b.get_title();
                    this.dataGridView1.Rows[i].Cells[2].Value = b.get_author();
                    this.dataGridView1.Rows[i].Cells[3].Value = b.get_lang();
                    this.dataGridView1.Rows[i].Cells[4].Value = b.Copies.Count();
                    this.dataGridView1.Rows[i].Cells[5].Value = b.get_PYear();
                    i++;
                }
            }
            SizeAllColumns(sender, e);
        }

        private void btnShowActiveBooks_Click(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = books.ToArray();
            int i = 0;
            foreach (Book b in books)
            {
                if (!b.get_archive())
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = b.get_sNumber();
                    this.dataGridView1.Rows[i].Cells[1].Value = b.get_title();
                    this.dataGridView1.Rows[i].Cells[2].Value = b.get_author();
                    this.dataGridView1.Rows[i].Cells[3].Value = b.get_lang();
                    this.dataGridView1.Rows[i].Cells[4].Value = b.Copies.Count();
                    this.dataGridView1.Rows[i].Cells[5].Value = b.get_PYear();
                    i++;
                }
            }
            SizeAllColumns(sender, e);
        }
    }
}
