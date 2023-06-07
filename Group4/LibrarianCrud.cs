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
    public partial class LibrarianCrud : Form
    {
        private Librarian l;
        public LibrarianCrud(Librarian l)
        {
            this.l = l;
            InitializeComponent();
        }
    }
}
