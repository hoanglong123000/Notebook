﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class FindNote : Form
    {
        public FindNote()
        {
            InitializeComponent();
        }

        private void returnaddscrnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.titlebox.Text.ToString() != "" || this.numpage.Text.ToString() != "")
            {
                this.Findbtn.Enabled = true;
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {

        }

        private void ReadNote_Load(object sender, EventArgs e)
        {

        }
    }
}
