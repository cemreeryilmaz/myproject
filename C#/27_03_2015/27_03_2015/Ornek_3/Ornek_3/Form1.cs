﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox1.Text = checkBox1.CheckState.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Text = checkBox2.Checked.ToString();
        }
    }
}