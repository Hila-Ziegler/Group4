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
    public partial class CopyCrud : Form
    {
        public CopyCrud()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CopyCrud_Load(object sender, EventArgs e)
        {

        }

        private void copyCrudMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LibrarianChooseAction form6 = new LibrarianChooseAction();
            form6.Show();
            this.Hide();
        }

        private void MenuManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks form7 = new ManageBooks();
            form7.Show();
            this.Hide();

        }
    }
}
