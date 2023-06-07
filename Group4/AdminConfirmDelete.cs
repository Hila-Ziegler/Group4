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
        public AdminConfirmDelete(TeacherCrud tc)
        {
            this.tc = tc;
            InitializeComponent();
        }
        public AdminConfirmDelete(StudentCrud sc)
        {
            this.sc = sc;
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
             else if (sc != null)
             {
                 sc.getStudent().set_archive(true);
                 sc.getStudent().update_Student();
                 sc.Hide();
             }
             else if (tc != null)
             {
                tc.getTeacher().set_archive(true);
                tc.getTeacher().Update_teacher();
                tc.Hide();
             }
            AdminActions aa = new AdminActions();
            aa.Show();
            this.Hide();
        }
    }
}
