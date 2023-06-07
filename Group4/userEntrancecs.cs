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
        private string adminUser = "Admin";
        private string adminPass = "admin";
        public userEntrancecs()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text !=  null || txtPassword.Text != null)
            {
                if(txtUserName.Text == this.adminUser && txtPassword.Text == this.adminPass)
                {
                    //מסך אדמין
                    AdminActions form20 = new AdminActions();
                    form20.Show();
                    this.Hide();
                }
                foreach (Librarian L in Program.librarians)
                {
                    if (txtUserName.Text == L.get_ID() && Hash.GetHash(txtPassword.Text) == L.get_password())
                    {
                        // show new form for librarians
                        LibrarianChooseAction form1 = new LibrarianChooseAction();
                        form1.Show();
                        this.Hide();
                    }
                }
                // foreach Librarian end
                foreach (Teacher T in Program.teachers)
                {
                    if (txtUserName.Text == T.get_ID() && Hash.GetHash(txtPassword.Text) == T.get_password())
                    {

                        this.Hide();

                        

                    }
                }
                // foreach Teacher end
                foreach (Student S in Program.students)
                {
                    if (txtUserName.Text == S.get_ID() && Hash.GetHash(txtPassword.Text) == S.get_password())
                    {
                        StudentChooseAction formStudentChooseAction = new StudentChooseAction(S.get_name());
                        formStudentChooseAction.Show();
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
