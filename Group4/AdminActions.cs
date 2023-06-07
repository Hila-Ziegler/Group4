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
    public partial class AdminActions : Form
    {
        public AdminActions()
        {
            InitializeComponent();
        }

        private void Studentsbtn_Click(object sender, EventArgs e)
        {
            AdminGridView form14 = new AdminGridView("s");
            form14.Show();
            this.Hide();
        }

        private void Teachersbtn_Click(object sender, EventArgs e)
        {
            AdminGridView form14 = new AdminGridView("t");
            form14.Show();
            this.Hide();
        }

        private void Librariansbtn_Click(object sender, EventArgs e)
        {
            AdminGridView form14 = new AdminGridView("l");
            form14.Show();
            this.Hide();
        }
    }
}
