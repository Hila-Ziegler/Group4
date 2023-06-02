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
    public partial class LibrarianChooseAction : Form
    {
        public LibrarianChooseAction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageBooks form3 = new ManageBooks();
            form3.Show();
            this.Hide();
        }
    }
}
