﻿using System;
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
    public partial class TeacherCrud : Form
    {
        private Teacher t;
        public TeacherCrud(Teacher t)
        {
            this.t = t;
            InitializeComponent();
        }
    }
}