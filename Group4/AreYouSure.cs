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
    public partial class AreYouSure : Form
    {
        private Book book;
        private BookCrud bc;
        public AreYouSure(Book b, BookCrud bc)
        {
            this.book = b;
            this.bc = bc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book.set_archive(true);
            book.update_Book();
            this.Hide();
            bc.Hide();
            ManageBooks form16 = new ManageBooks();
            form16.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
