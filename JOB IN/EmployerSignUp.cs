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
    public partial class EmployerSignUp : Form
    {
        public EmployerSignUp()
        {
            InitializeComponent();
        }

        // organization panel
        private void OnOrganizationBtn_clicked(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(organizationPanel);
            choosePanel.Hide();
            organizationPanel.Show();
            signUpAsLabel.Text = "Oraganization  Sign  Up";

        }
        

        private void next_btn_click(object sender, EventArgs e)
        {
            organizationPanel.Hide();
            signUpAsPanel.BackColor = Color.FromArgb(0, 83, 156);
            signUpAsLabel.ForeColor = Color.White;
            mainPanel.Controls.Add(organizationalMorePanel);
        }

        private void On_add_media_clicked(object sender, EventArgs e)
        {

        }

        // personal panel
        private void personal_next_btn_click(Object sender, EventArgs e)
        {
            personalPanel.Hide();
            signUpAsPanel.BackColor = Color.FromArgb(0, 83, 156);
            signUpAsLabel.ForeColor = Color.White;
            mainPanel.Controls.Add(personalMorePanel);
        }

        private void OnPersonalBtn_clicked(object sender, EventArgs e)
        {
            //choosePanel.Hide();
            mainPanel.Controls.Add(personalPanel);
            choosePanel.Hide();
            personalPanel.Show();
            signUpAsLabel.Text = "Employer  Sign  Up";
        }
    }
}
