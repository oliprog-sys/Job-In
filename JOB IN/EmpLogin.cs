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
        public EmpLogin()
        {
            InitializeComponent();
        }
        private Form activeform1;
        private void OpenchildForm2(Form ChildForm, object btnsender)
        {


            if (activeform1 != null)
            {

                activeform1.Close();
            }

            activeform1 = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.apppanel.Controls.Add(ChildForm);
            this.apppanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void Jobs_Click(object sender, EventArgs e)
        {
            if (postp.BackColor == Color.White)
                postp.BackColor = Color.LightGray;
            if (historyp.BackColor == Color.White)
                historyp.BackColor = Color.LightGray;
            if (profilep.BackColor == Color.White)
                profilep.BackColor = Color.LightGray;


            Jobbackp.BackColor = Color.White;


            Jobbackp.BackColor = Color.White;
            
            
            
       }

        private static void CloseApp(object? sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
        
        private void cusbutton2_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (historyp.BackColor == Color.White)
                historyp.BackColor = Color.LightGray;
            if (profilep.BackColor == Color.White)
                profilep.BackColor = Color.LightGray;

            postp.BackColor = Color.White;

            //apppanel.Dock = DockStyle.None;
            //apppanel.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;    
        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (postp.BackColor == Color.White)
                postp.BackColor = Color.LightGray;
            if (profilep.BackColor == Color.White)
                profilep.BackColor = Color.LightGray;



            historyp.BackColor = Color.White;

        }


        private void Profilebtn_Click(object sender, EventArgs e)
        {
            if (Jobbackp.BackColor == Color.White)
                Jobbackp.BackColor = Color.LightGray;
            if (historyp.BackColor == Color.White)
                historyp.BackColor = Color.LightGray;
            if (postp.BackColor == Color.White)
                postp.BackColor = Color.LightGray;

            profilep.BackColor = Color.White;


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
