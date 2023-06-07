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
    public partial class LibrarianCrud : Form
    {
        private Librarian l;
        private string s;
        public LibrarianCrud(Librarian l)
        {
            this.l = l;
            InitializeComponent();
        }
        public LibrarianCrud(string s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void LibrarianCrud_Load(object sender, EventArgs e)
        {
            if (l != null)
            {
                Passwordlbl.Hide();
                PasswordTextBox.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                Createbtn.Hide();


            }
            else
            {
                if (s == "update")
                {
                    IDTextBox.Hide();
                }
                else
                {

                }
            }
        }
    }
}
