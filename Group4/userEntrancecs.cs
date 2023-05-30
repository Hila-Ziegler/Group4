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
    public partial class userEntrancecs : Form
    {
        public userEntrancecs()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text !=  null || txtPassword != null)
            {
                foreach (Librarian L in Program.librarians)
                {
                    if (txtUserName.Text == L.get_ID().ToString() && txtPassword.Text == L.get_password())
                    {
                        // show new form for librarians
                        this.Hide();
                    }
                }
                // foreach Librarian end
                foreach (Teacher T in Program.teachers)
                {
                    if (txtUserName.Text == T.get_ID().ToString() && txtPassword.Text == T.get_password())
                    {
                        // show new form for Teacher
                        librarianStartPage1 form2 = new librarianStartPage1();
                        form2.Show();
                        this.Hide();
                    }
                }
                // foreach Teacher end
                foreach (Student S in Program.students)
                {
                    if (txtUserName.Text == S.get_ID().ToString() && txtPassword.Text == S.get_password())
                    {
                        // show new form for Teacher
                        this.Hide();
                    }
                }
                // foreach Teacher end
            }
        }

        private void userEntrancecs_Load(object sender, EventArgs e)
        {

        }
    }
}
