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
    public partial class IncorrectInformation : Form
    {
        string st = "";
        public IncorrectInformation(String s)
        {
          this.st = s;
            InitializeComponent();
        }

        private void labdetails_Click(object sender, EventArgs e)
        {

        }

        private void IncorrectInformation_Load(object sender, EventArgs e)
        {
            labdetails.Text = st;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
