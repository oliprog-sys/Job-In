namespace JOB_IN
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();

        }

        private void OpenchildForm(Form ChildForm, object btnsender)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(ChildForm);
            this.MainPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            apage = false;
            SIgnUpPanel1.BackColor = Color.RoyalBlue;
            companyname1.ForeColor = Color.White;
            panel1.BackColor = Color.RoyalBlue;
            Loginbtn.BackColor = Color.RoyalBlue;
            Applicantbtn.BackColor = Color.Coral;
            Applicantbtn.ForeColor = Color.White;
            Employerbtn.ForeColor = Color.Black;
            Employerbtn.BackColor = Color.White;
            //panel2.BackgroundImage = Image.FromFile("D:\\iconb.png");
            //panel2.Size = new Size(100, 83);
            picture.Image = Image.FromFile("..\\..\\..\\Image\\iconb.png");
        }

        private void button(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            apage = true;
            SIgnUpPanel1.BackColor = Color.Coral;
            companyname1.ForeColor = Color.Black;
            panel1.BackColor = Color.Coral;
            Loginbtn.BackColor = Color.Coral;
            Applicantbtn.BackColor = Color.White;
            Applicantbtn.ForeColor = Color.Black;
            Employerbtn.ForeColor = Color.White;
            Employerbtn.BackColor = Color.RoyalBlue;
            // panel2.BackgroundImage = Image.FromFile("D:\\or.png");
            //panel2.Size = new Size(100, 100);
            picture.Image = Image.FromFile("..\\..\\..\\Image\\or.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SIgnUpPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SIgnUpPanel1.Width, SIgnUpPanel1.Height, 150, 150));
            Employerbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Employerbtn.Width, Employerbtn.Height, 10, 10));
            //textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 20, 20));
            //textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 20, 20));
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            blackColorLine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, blackColorLine.Width, blackColorLine.Height, 5, 5));
            
        }




        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (apage) { 
                
            }
            else
            {
                SIgnUpPanel1.BackColor = Color.RoyalBlue;
                companyname1.ForeColor = Color.White;
                OpenchildForm(new LoginForm(), sender);
            }
        }


        private void SignIn(object sender, EventArgs e)
        {
            //this.Hide();
            if (apage)
            {
                this.Hide();
                ApplicantHomepage s = new ApplicantHomepage();
              //  OpenchildForm(s, sender);
                s.Show();
            }
            else
            {
                SIgnUpPanel1.BackColor = Color.RoyalBlue;
                companyname1.ForeColor = Color.White;
                LoginForm form = new LoginForm();
                OpenchildForm(form, sender);
                form.Hide();
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)

        {

        }
    }
}


