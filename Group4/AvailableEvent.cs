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
    public partial class AvailableEvent : Form
    {
        public AvailableEvent()
        {
            InitializeComponent();
        }

        private void BookCrudTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EventCrud formEventCrud = new EventCrud();
            formEventCrud.Show();
            this.Hide();
        }
    }
}
