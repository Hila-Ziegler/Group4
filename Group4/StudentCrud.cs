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
    public partial class StudentCrud : Form
    {
        private Student st = null;
        private string s = null;
        public StudentCrud(Student st)
        {
            this.st = st;
            InitializeComponent();
        }
        public StudentCrud(string s, Student st)
        {
            this.s = s;
            this.st = st;
            InitializeComponent();
        }

        public Student getStudent()
        {
            return this.st;
        }

        private void StudentCrud_Load(object sender, EventArgs e)
        {
            if (s == null && st != null)
            {
                Passwordlbl.Hide();
                PasswordTextBox.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                Createbtn.Hide();
                Namelbl.Hide();
                NameTextBox.Hide();
                IDTextBox.Hide();
                YearlyGoalTextBox.Hide();
                ClubComboBox.Hide();
                AgeComboBox.Hide();
                if (st.get_archive())
                {
                    BringBackFromArchieve.Show();
                    DeleteBTN.Hide();
                }
                NameTitle.Text = st.get_name();
                lb_ID_value.Text = st.get_ID();
                YearlyGoalValuelbl.Text = st.get_yearlyGoal().ToString();
                ClubNamelbl.Text = st.get_club().ToString();
                AgeValuelbl.Text = st.get_age().ToString();
            }
            else if (s == "update")
            {
                this.loadEnum();
                IDTextBox.Hide();
                UpdateBTN.Hide();
                NameTitle.Hide();
                BringBackFromArchieve.Hide();
                DeleteBTN.Hide();
                Createbtn.Hide();
                lb_ID_value.Text = st.get_ID();
                NameTextBox.Text = st.get_name();
                AgeComboBox.Text = st.get_age().ToString();
                YearlyGoalTextBox.Text = st.get_yearlyGoal().ToString();
                ClubComboBox.Text = st.get_club().ToString();


            }
            else
            {
                this.loadEnum();
                NameTitle.Hide();
                BringBackFromArchieve.Hide();
                btnUpdate.Hide();
                UpdateBTN.Hide();
                DeleteBTN.Hide();

            }
        }

        private void loadEnum()
        {
            List<KeyValuePair<string, string>> Clublist = new List<KeyValuePair<string, string>>();
            Array clubs = Enum.GetValues(typeof(Club));
            foreach (Club club in clubs)
            {
                Clublist.Add(new KeyValuePair<string, string>(club.ToString(), ((int)club).ToString()));
            }
            ClubComboBox.DataSource = Clublist;
            ClubComboBox.DisplayMember = "Key";
            ClubComboBox.ValueMember = "Value";
        }

        private void BringBackFromArchieve_Click(object sender, EventArgs e)
        {
            this.st.set_archive(false);
            this.st.update_Student();
            StudentCrud form21 = new StudentCrud(this.st);
            form21.Show();
            this.Hide();
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            StudentCrud form17 = new StudentCrud("update", this.st);
            form17.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.checkIfValid())
            {
                if (PasswordTextBox.Text != "")
                {
                    string newPassword = Hash.GetHash(PasswordTextBox.Text);
                    st.set_password(newPassword);
                }
                st.set_name(NameTextBox.Text);
                st.set_age(int.Parse(AgeComboBox.Text));
                st.set_club((Club)Enum.Parse(typeof(Club), ClubComboBox.Text));
                st.set_yearlyGoal(int.Parse(YearlyGoalTextBox.Text));
                st.update_Student();
                StudentCrud form21 = new StudentCrud(this.st);
                form21.Show();
                this.Hide();
            }
            
        }


        private bool checkIfValid()
        {
            if (YearlyGoalTextBox.Text != "" && NameTextBox.Text != "")
            {
                if (this.s!="update" && IDTextBox.Text != "")
                {
                    if (IDTextBox.Text.Any(x => !char.IsDigit(x)))
                    {
                        return false;
                    }
                    return true;
                
                }
                return true;

            }
            return false;
        }
        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (this.checkIfValid()) {
                Club club = (Club)Enum.Parse(typeof(Club), ClubComboBox.Text);
                Student stu = new Student(IDTextBox.Text, NameTextBox.Text, int.Parse(AgeComboBox.Text), club, int.Parse(YearlyGoalTextBox.Text), Hash.GetHash(PasswordTextBox.Text), false, true);
                StudentCrud form20 = new StudentCrud(stu);
                form20.Show();
                this.Hide();
            }

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            AdminConfirmDelete form19 = new AdminConfirmDelete(this);
            form19.Show();
        }

        private void ClubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminActions form24 = new AdminActions();
            form24.Show();
            this.Hide();

        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGridView form25 = new AdminGridView("s");
            form25.Show();
            this.Hide();

        }
    }
}
