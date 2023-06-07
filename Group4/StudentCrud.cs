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
        private Student s;
        public StudentCrud(Student s)
        {
            this.s = s;
            InitializeComponent();
        }
    }
}
