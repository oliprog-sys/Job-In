namespace JOB_IN
{
    public partial class Form1 : Form
    {
        public Form activeForm;
        static ApplicantHomepage s ;
        public Form1()
        {
            InitializeComponent();



        }

        private void OpenchildForm(Form ChildForm, object btnsender)
        {
            if (activeForm != null)
            {

                activeForm.Hide();
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
            apage = true;
        }




        private void SignIn(object sender, EventArgs e)
        {
            //this.Hide();
            if (apage)
            {
                if (Db.check(textBox1.Text, textBox2.Text) == true)
                {
                    applicants app = Db.fetchApplicantinfo(textBox1.Text);
                    s = new ApplicantHomepage(app);
                    s.job_list_adder();

                    s.exit.Click += (sender, e) => s.return_to_login(sender, e, this);

                    OpenchildForm(s, sender);
                    activeForm.Controls.Remove(this);

                }
                else
                {
                    MessageBox.Show("no email found");
                }


            }
            else
            {
                if (Db.checkOrganization(textBox1.Text, textBox2.Text) == true)
                {
                    organization o = Db.fetchOrganizationInfo(textBox1.Text);
                    SIgnUpPanel1.BackColor = Color.RoyalBlue;
                    companyname1.ForeColor = Color.White;
                    EmpLogin form = new EmpLogin(o);
                    form.joblist();
                    OpenchildForm(form, sender);
                }
                else
                {
                    MessageBox.Show("no email found");
                }

            }


        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (apage)
            {
                ApplicantSignUp app = new ApplicantSignUp();
                OpenchildForm(app, sender);
            }
            else
            {
                EmployerSignUp appO = new EmployerSignUp();
                OpenchildForm(appO, sender);
            }
           
        }
    }
}


