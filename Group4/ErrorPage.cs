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
    public partial class ErrorPage : Form
    {
        String message;

        public ErrorPage(String m)
        {
            this.message = m;
            InitializeComponent();
        }

        private void ErrorPage_Load(object sender, EventArgs e)
        {
            ErrorText.Text = message;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
