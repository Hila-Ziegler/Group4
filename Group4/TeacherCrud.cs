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
    public partial class TeacherCrud : Form
    {
        private Teacher t = null;
        private string s = null;

        public TeacherCrud(Teacher t)
        {
            this.t = t;
            InitializeComponent();
        }
        public TeacherCrud(string s, Teacher t)
        {
            this.s = s;
            this.t = t;
            InitializeComponent();
        }

        public Teacher getTeacher()
        {
            return this.t;
        }

        private void TeacherCrud_Load(object sender, EventArgs e)
        {
            if (s == null && t != null)
            {
                Passwordlbl.Hide();
                PasswordTextBox.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                Createbtn.Hide();
                Namelbl.Hide();
                NameTextBox.Hide();
                IDTextBox.Hide();


                if (t.get_archive())
                {
                    BringBackFromArchieve.Show();
                    DeleteBTN.Hide();
                }

                NameTitle.Text = t.get_name();
                lb_ID_value.Text = t.get_ID();
            }
            else if (s == "update")
            {
                IDTextBox.Hide();
                UpdateBTN.Hide();
                NameTitle.Hide();
                BringBackFromArchieve.Hide();
                DeleteBTN.Hide();
                Createbtn.Hide();



                lb_ID_value.Text = t.get_ID();
                NameTextBox.Text = t.get_name();





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
            if (this.t == null && this.s == null)
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
            string st = $"Name field can't be left empty!";
            IncorrectInformation form24 = new IncorrectInformation(st);
            form24.Show();
            return false;
        }

        private void BringBackFromArchieve_Click(object sender, EventArgs e)
        {
            this.t.set_archive(false);
            this.t.Update_teacher();
            TeacherCrud form21 = new TeacherCrud(this.t);
            form21.Show();
            this.Hide();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            AdminConfirmDelete form19 = new AdminConfirmDelete(this);
            form19.Show();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (this.checkIfValid())
            {
                Teacher te = new Teacher(IDTextBox.Text, NameTextBox.Text, Hash.GetHash(PasswordTextBox.Text), false, true);
                TeacherCrud form20 = new TeacherCrud(te);
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
                    string newPassword = Hash.GetHash(PasswordTextBox.Text);
                    t.set_password(newPassword);
                }
                t.set_name(NameTextBox.Text);
                t.Update_teacher();
                TeacherCrud form21 = new TeacherCrud(this.t);
                form21.Show();
                this.Hide();
            }
        }


        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            TeacherCrud form17 = new TeacherCrud("update", this.t);
            form17.Show();
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
            AdminGridView form25 = new AdminGridView("t");
            form25.Show();
            this.Hide();
        }
    }
}
