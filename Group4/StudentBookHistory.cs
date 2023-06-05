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
    public partial class StudentBookHistory : Form
    {
        string st = "";
        public StudentBookHistory(string s)
        {
            this.st = s;
            InitializeComponent();
        }
        public StudentBookHistory()
        {
            InitializeComponent();
        }


        private void StudentBookHistory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentBorrow formStudentBorrow = new StudentBorrow(st);
            formStudentBorrow.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(st);
            formStudentChooseAction.Show();
            this.Hide();
        }

    }
}
