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
    public partial class studentAllMessagescs : Form
    {
        string st = "";
        public studentAllMessagescs(String s)
        {
            this.st = s;
            InitializeComponent();
        }

        private void labAllYourMessages_Click(object sender, EventArgs e)
        {

        }

        private void studentAllMessagescs_Load(object sender, EventArgs e)
        {
            labAllYourMessages.Text += st;
        }

        private void menuHomePage_Click(object sender, EventArgs e)
        {
            StudentChooseAction formStudentChooseAction = new StudentChooseAction(st);
            formStudentChooseAction.Show();
            this.Hide();
        }
    }
}