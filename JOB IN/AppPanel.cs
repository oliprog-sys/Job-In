﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_IN
{
    public partial class AppJobPanel : Form
    {
        public AppJobPanel()
        {
            InitializeComponent();
        }

        private void showmorebtn_Click(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;

        }
    }
}
