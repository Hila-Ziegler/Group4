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
        private Librarian l = null;
        private string s = null;
        public LibrarianCrud(Librarian l)
        {
            this.l = l;
            InitializeComponent();
        }
        public LibrarianCrud(string s, Librarian l)
        {
            this.s = s;
            this.l = l;
            InitializeComponent();
        }

        public Librarian getLibrarian()
        {
            return this.l;
        }

        private void LibrarianCrud_Load(object sender, EventArgs e)
        {
            if (s == null && l != null)
            {
                Passwordlbl.Hide();
                PasswordTextBox.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                Createbtn.Hide();
                Namelbl.Hide();
                NameTextBox.Hide();
                IDTextBox.Hide();


                if (l.get_archive())
                {
                    BringBackFromArchieve.Show();
                    DeleteBTN.Hide();
                }

                NameTitle.Text = l.get_name();
                lb_ID_value.Text = l.get_ID();
            }
            else if(s == "update")
            {
                IDTextBox.Hide();
                UpdateBTN.Hide();
                NameTitle.Hide();
                BringBackFromArchieve.Hide();
                DeleteBTN.Hide();
                Createbtn.Hide();



                lb_ID_value.Text = l.get_ID();
                NameTextBox.Text = l.get_name();





            }
            else
                {
                NameTitle.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                UpdateBTN.Hide();
                DeleteBTN.Hide();

                }
            }

        private bool checkIfValid()
        {
            if (this.s == null && this.l == null)
            {
                if (PasswordTextBox.Text == "")
                {
                    string s = "Please enter a password for this user.";
                    IncorrectInformation form23 = new IncorrectInformation(s);
                    form23.Show();
                    return false;
                }
            }
            if (NameTextBox.Text != "")
            {
                if (this.s != "update" && IDTextBox.Text != "")
                {
                    if (IDTextBox.Text.Any(x => !char.IsDigit(x)))
                    {
                        string s = "ID must contain numbers only.\n No other characters allowed!";
                        IncorrectInformation form23 = new IncorrectInformation(s);
                        form23.Show();
                        return false;
                    }
                    return true;

                }
                else if (this.s != "update" && IDTextBox.Text == "")
                {
                    string s = "ID field can't be left empty!";
                    IncorrectInformation form23 = new IncorrectInformation(s);
                    form23.Show();
                    return false;
                }
                return true;

            }
            string st = "Name field can't be left empty!";
            IncorrectInformation form24 = new IncorrectInformation(st);
            form24.Show();
            return false;
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
                LibrarianCrud form17 = new LibrarianCrud("update", this.l);
                form17.Show();
                this.Hide();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            AdminConfirmDelete form19 = new AdminConfirmDelete(this);
            form19.Show();
           

        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            //if input check passed
            if (this.checkIfValid())
            {
                Librarian lib = new Librarian(IDTextBox.Text, NameTextBox.Text, Hash.GetHash(PasswordTextBox.Text), false, true);
                LibrarianCrud form20 = new LibrarianCrud(lib);
                form20.Show();
                this.Hide();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.checkIfValid())
            {
                if (PasswordTextBox.Text != "")
                {
                    l.set_password(PasswordTextBox.Text);
                }
                l.set_name(NameTextBox.Text);
                l.update_librarian();
                LibrarianCrud form21 = new LibrarianCrud(this.l);
                form21.Show();
                this.Hide();
            }
        }

        private void BringBackFromArchieve_Click(object sender, EventArgs e)
        {
            this.l.set_archive(false);
            this.l.update_librarian();
            LibrarianCrud form21 = new LibrarianCrud(this.l);
            form21.Show();
            this.Hide();
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminActions form24 = new AdminActions();
            form24.Show();
            this.Hide();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGridView form25 = new AdminGridView("l");
            form25.Show();
            this.Hide();
        }
    }
}
