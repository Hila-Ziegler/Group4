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
    public partial class AdminConfirmDelete : Form
    {
        LibrarianCrud lc = null;
        StudentCrud sc = null;
        TeacherCrud tc = null;
        public AdminConfirmDelete(LibrarianCrud lc)
        {
            this.lc = lc;
            InitializeComponent();
        }

        private void AdminConfirmDelete_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lc != null)
            {
                lc.getLibrarian().set_archive(true);
                lc.getLibrarian().update_librarian();
                lc.Hide();
            }
            /* else if (sc != null)
             {
                 sc.getStudent().set_archive(true);
                 sc.getStudent().update_librarian();
             }
             else if (tc != null)
             {
                 sc.getTeacher().set_archive(true);
                 sc.getTeacher().update_librarian();
             }*/
            AdminActions aa = new AdminActions();
            aa.Show();
            this.Hide();
        }
    }
}
