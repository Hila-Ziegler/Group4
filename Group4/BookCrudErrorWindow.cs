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
    public partial class BookCrudErrorWindow : Form
    {
        string message = "";
        BookCrud bc;
        public BookCrudErrorWindow(string m, BookCrud bc)
        {
            this.message = m;
            InitializeComponent();
            this.bc = bc;
        }

        private void BookCrudErrorWindow_Load(object sender, EventArgs e)
        {
            ErrorMessage.Text = this.message;
            this.AutoSize = true;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            BookCrud form13 = new BookCrud(null);
            bc.Hide();
            form13.Show();
            this.Hide();
        }
    }
}
