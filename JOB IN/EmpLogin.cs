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
    public partial class EmpLogin : Form
    {
        public EmpLogin(organization org)
        {
            this.org = org;
            InitializeComponent();
            
        }


        private void Jobs_Click(object sender, EventArgs e)
        {
            if (postbackp.BackColor == Color.White || postbackp.BackColor == Color.FromArgb(64, 64, 64))
                postbackp.BackColor = Color.LightGray;
            if (historybackp.BackColor == Color.White)
                historybackp.BackColor = Color.LightGray;
            if (profilebackp.BackColor == Color.White)
                profilebackp.BackColor = Color.LightGray;


            jobpanel.Show();
            historypanel.Hide();
            profilepanel.Hide();
            postpanel.Hide();
            Jobbackp.BackColor = Color.White;




        }





        private void historybtn_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (postbackp.BackColor == Color.White || postbackp.BackColor == Color.FromArgb(64, 64, 64))
                postbackp.BackColor = Color.LightGray;
            if (profilebackp.BackColor == Color.White)
                profilebackp.BackColor = Color.LightGray;



            historybackp.BackColor = Color.White;
            historypanel.Show();
            jobpanel.Hide();
            profilepanel.Hide();
            postpanel.Hide();

        }


        private void Profilebtn_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (historybackp.BackColor == Color.White)
                historybackp.BackColor = Color.LightGray;
            if (postbackp.BackColor == Color.White || postbackp.BackColor == Color.FromArgb(64, 64, 64))
                postbackp.BackColor = Color.LightGray;

            profilebackp.BackColor = Color.White;
            profilepanel.Show();
            historypanel.Hide();
            postpanel.Hide();
            jobpanel.Hide();

       

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            jobpanel.Show();
            postpanel.Hide();
            historypanel.Hide();
            profilepanel.Hide();

            orglbl.Text = org.name;
            b.Text = org.description;
            emaillbl.Text = org.email;
            phonelbl.Text = org.PhoneNum;
            adlbl.Text = org.address;
            smlink.Text= org.mediaLink;
            
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (historybackp.BackColor == Color.White)
                historybackp.BackColor = Color.LightGray;
            if (profilebackp.BackColor == Color.White)
                profilebackp.BackColor = Color.LightGray;

            postbackp.BackColor = Color.FromArgb(64, 64, 64);
            postpanel.Show();
            jobpanel.Hide();
            historypanel.Hide();
            profilepanel.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {   
            this.Hide();

        }
    }
}
