using System;
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
    public partial class ApplicantSignUp : Form
    {
        public ApplicantSignUp()
        {
            InitializeComponent();
        }

        private void next_btn_click(object sender, EventArgs e)
        {
            infoPanel.Hide();
            titlePanel.BackColor = Color.FromArgb(238, 164, 127);
            mainPanel1.Controls.Add(infoPanel2);
        }

    }
}
