using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using JOB_IN.RJControls;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace JOB_IN
{
    
    public partial class ApplicantHomepage : Form
    {

        public applicants applicant;

        private Label companyname1;
        private Panel panel1;

        public TextBox edit_name_text;

        public TextBox edit_phone_text;
        public ComboBox edit_category_text;
        public TextBox edit_bio_text;
        public NumericUpDown edit_exp_text;
        TextBox edit_certificate_text;
        TextBox edit_cv_text;
        public string edit_cv_path;
        public string edit_certificate_path;
        RadioButton active, notworking;

        topButtons edit_save;
        topButtons edit_close;



        public ApplicantHomepage(applicants ap)
        {
            applicant = ap;
            InitializeComponents();
        }
        public void InitializeComponents()
        {
            
            panel1 = new Panel();
            companyname1 = new Label();

            jobs = new topButtons(2);
            jobsPane = new borderedscrollPanels();

            search = new topButtons(0);
            searchButton = new topButtons(Color.Black,Color.White);
            searchBox = new TextBox();
            searchResultsPane = new borderedscrollPanels();
            searchPane = new borderedPanels();

            status = new topButtons(0);
            sAllbutton = new topButtons(Color.Black, Color.White);
            sAcceptedbutton = new topButtons(Color.Orange, Color.Black);
            sPendingbutton = new topButtons(Color.Orange, Color.Black);
            sDeniedbutton = new topButtons(Color.Orange, Color.Black);
            statusPane = new borderedPanels();
            statusScrollPane = new borderedscrollPanels();

            profile = new topButtons(0);
            profilePane = new borderedPanels();

            editpanel = new borderedPanels();

            subMain = new borderedPanels();
            
            exit = new topButtons(0);
            MainPanel = new Panel();

            jobs.Name = "jobs";
            jobs.Anchor = AnchorStyles.None;
            jobs.Font = Custom.font(12f);
            jobs.Location = new Point(-617, -320);
            jobs.Size = new Size(140, 80);
            jobs.Text = "Jobs";
            jobs.Click += job_nav_MouseClick;


            search.Anchor = AnchorStyles.None;
            search.Font = Custom.font(12f);
            search.Location = new Point( -215, -320);
            search.Size = new Size(140, 80);
            search.Text = "Search";
            search.Click += search_nav_MouseClick;

            status.Anchor = AnchorStyles.None;
            status.Font = Custom.font(12f);
            status.Location = new Point(215, -320);
            status.Size = new Size(140, 80);
            status.Text = "Status";
            status.Click += status_nav_MouseClick;

            profile.Anchor = AnchorStyles.None;
            profile.Font = Custom.font(12f);
            profile.Location = new Point(617, -320);
            profile.Size = new Size(140, 80);
            profile.Text = "Profile";
            profile.Click += profile_nav_MouseClick;

            exit.Anchor = AnchorStyles.None;
            exit.Font = Custom.font(12f);
            exit.Location = new Point(870, 470);
            exit.Size = new Size(140, 80);
            exit.Text = "exit";
           // exit.Click += ClosePanel;
         
            
            jobsPane.Anchor= AnchorStyles.None;
          
            jobsPane.AutoScroll = true;
            jobsPane.BackColor = Color.FromArgb(0,Color.Black);
            jobsPane.Size = new Size(1434, 675);
            jobsPane.Location = new Point(10, 10);
            jobsPane.BorderStyle = BorderStyle.None;

            // jobs.TabStop = false;

            borderedPanels searchboxP = new borderedPanels();
            searchboxP.Anchor = AnchorStyles.None;
            searchboxP.Location = new Point(260, 15);
            searchboxP.Size = new Size(680, 60);
            searchboxP.BackColor = Color.Black;
            searchboxP.BorderRadius = 30;

            searchBox.Anchor = AnchorStyles.None;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.MinimumSize = new Size(600, 40);
            searchBox.Location = new Point(300, 28);
            //searchBox.Size = new Size(600, 200);
            searchBox.BackColor = Color.Black;
            searchBox.ForeColor = Color.White;
            searchBox.Font = Custom.font(18);
            searchBox.PlaceholderText = "Search";

            searchButton.Anchor = AnchorStyles.None;
            searchButton.Size = new Size(60, 60);
            searchButton.Location = new Point(950, 15);
            searchButton.Font = Custom.font(18);
            searchButton.Text = "🔍";
            searchButton.Click += (s,e)=>searchResultFetch(s,e,searchBox.Text);

            searchResultsPane.Anchor = AnchorStyles.None;
            searchResultsPane.Size = new Size(1250, 500);
            searchResultsPane.BackColor = Color.FromArgb(0, Color.Chartreuse);
            searchResultsPane.Location = new Point(100, 100);


            searchPane.Anchor = AnchorStyles.None;
            searchPane.AutoScroll = true;
            searchPane.BackColor = Color.FromArgb(255, Color.WhiteSmoke);
            searchPane.Size = new Size(1413, 675);
            searchPane.Location = new Point(10, 10);
            searchPane.BorderStyle = BorderStyle.None;

            searchPane.Controls.Add(searchboxP);
            searchPane.Controls.Add(searchBox);
            searchPane.Controls.Add(searchButton);
            searchPane.Controls.Add(searchResultsPane);

            searchBox.BringToFront();

            sAllbutton.Anchor = AnchorStyles.None;
            sAllbutton.Size = new Size(160, 40);
            sAllbutton.Location = new Point(320, 30);
            sAllbutton.Font = Custom.font(15);
            sAllbutton.Text = "All";
            sAllbutton.Click += all_button_nav;

            sAcceptedbutton.Anchor = AnchorStyles.None;
            sAcceptedbutton.Size = new Size(160, 40);
            sAcceptedbutton.Location = new Point(510, 30);
            sAcceptedbutton.Font = Custom.font(15);
            sAcceptedbutton.Text = "Accepted";
            sAcceptedbutton.Click += accepted_button_nav;

            sDeniedbutton.Anchor = AnchorStyles.None;
            sDeniedbutton.Size = new Size(160, 40);
            sDeniedbutton.Location = new Point(700, 30);
            sDeniedbutton.Font = Custom.font(15);
            sDeniedbutton.Text = "Rejected";
            sDeniedbutton.Click += denied_button_click;

            sPendingbutton.Anchor = AnchorStyles.None;
            sPendingbutton.Size = new Size(160, 40);
            sPendingbutton.Location = new Point(890, 30);
            sPendingbutton.Font = Custom.font(15);
            sPendingbutton.Text = "Pending";
            sPendingbutton.Click += pending_button_nav;

            statusPane.Anchor = AnchorStyles.None;
            statusPane.AutoScroll = true;
            statusPane.BackColor = Color.White;
            statusPane.Size = new Size(1434, 675);
            statusPane.Location = new Point(10, 10);
            statusPane.BorderStyle = BorderStyle.None;

            statusScrollPane.Anchor = AnchorStyles.None;
            statusScrollPane.AutoScroll = true;
            statusScrollPane.Size = new Size(1250, 550);
            statusScrollPane.Location = new Point(100, 100);
            statusScrollPane.BackColor = Color.FromArgb(0, Color.PaleGoldenrod);
           

            statusPane.Controls.Add(sAllbutton);
            statusPane.Controls.Add(sAcceptedbutton);
            statusPane.Controls.Add(sPendingbutton);
            statusPane.Controls.Add(sDeniedbutton);
            statusPane.Controls.Add(statusScrollPane);

            profilePane.Anchor = AnchorStyles.None;
            profilePane.AutoScroll = true;
            profilePane.BackColor = Color.White;
            profilePane.Size = new Size(1413, 675);
            profilePane.Location = new Point(10, 10);
            profilePane.BorderStyle = BorderStyle.None;


            editpanel.Anchor = AnchorStyles.None;
            editpanel.AutoScroll = true;
            editpanel.BackColor = Color.Coral;
            editpanel.Size = new Size(1600, 805);
            editpanel.Location = new Point(-700, -320);
            editpanel.BorderStyle = BorderStyle.None;
            
            Label edit_label = new Label();
            Label edit_name = new Label();
            Label edit_phone = new Label();
            Label edit_exp = new Label();
            Label edit_bio = new Label();
            Label edit_category = new Label();
            Label edit_cv = new Label();
            Label edit_certificate = new Label();
            topButtons edit_cv_button = new topButtons(Color.AliceBlue, Color.Coral);
            topButtons edit_certificate_button = new topButtons(Color.AliceBlue, Color.Coral);
            Label edit_workStatus = new Label();

            edit_name_text = new TextBox();
            edit_phone_text = new TextBox();
            edit_bio_text = new TextBox();
            edit_exp_text = new NumericUpDown();
            edit_category_text = new ComboBox();
            edit_certificate_text = new TextBox();
            edit_cv_text = new TextBox();
            active = new RadioButton();
            notworking = new RadioButton();
            edit_save = new topButtons(Color.Yellow, Color.Black);
            edit_close = new topButtons(Color.Red, Color.Black);

            edit_label.Text = "Edit";
            edit_label.ForeColor = Color.White;
            edit_label.Anchor = AnchorStyles.None;
            edit_label.Size = new Size(300, 50);
            edit_label.Font = Custom.font(25);
            edit_label.Location = new Point(650, 80);

            edit_name.Text = "Name: ";
            edit_name.Anchor = AnchorStyles.None;
            edit_name.Size = new Size(100, 50);
            edit_name.Font = Custom.font(16);
            edit_name.Location = new Point(50, 160);

           
            edit_name_text.Anchor = AnchorStyles.None;
            edit_name_text.Size = new Size(300, 50);
            edit_name_text.Font = Custom.font(12);
            edit_name_text.Location = new Point(180, 160);

            edit_phone.Text = "Phone: ";
            edit_phone.Anchor = AnchorStyles.None;
            edit_phone.Size = new Size(100, 50);
            edit_phone.Font = Custom.font(16);
            edit_phone.Location = new Point(50, 230);
            edit_phone_text.Leave += phone_check;

            edit_phone_text.Anchor = AnchorStyles.None;
            edit_phone_text.Size = new Size(300, 50);
            edit_phone_text.Font = Custom.font(12);
            edit_phone_text.Location = new Point(180, 230);

            edit_exp.Text = "Exp: ";
            edit_exp.Anchor = AnchorStyles.None;
            edit_exp.Size = new Size(100, 50);
            edit_exp.Font = Custom.font(16);
            edit_exp.Location = new Point(50, 300);

            edit_exp_text.Anchor = AnchorStyles.None;
            edit_exp_text.Size = new Size(300, 50);
            edit_exp_text.Font = Custom.font(12);
            edit_exp_text.Location = new Point(180, 300);

            edit_bio.Text = "Bio: ";
            edit_bio.Anchor = AnchorStyles.None;
            edit_bio.Size = new Size(100, 50);
            edit_bio.Font = Custom.font(16);
            edit_bio.Location = new Point(50, 380);

            edit_category.Text = "Category: ";
            edit_category.Anchor = AnchorStyles.None;
            edit_category.Size = new Size(200, 50);
            edit_category.Font = Custom.font(16);
            edit_category.Location = new Point(760, 160);

            edit_category_text.DataSource = Custom.job_category;
            edit_category_text.Anchor = AnchorStyles.None;
            edit_category_text.Size = new Size(400, 50);
            edit_category_text.Font = Custom.font(12);
            edit_category_text.Location = new Point(980, 160);

            edit_cv.Text = "CV: ";
            edit_cv.Anchor = AnchorStyles.None;
            edit_cv.Size = new Size(200, 50);
            edit_cv.Font = Custom.font(16);
            edit_cv.Location = new Point(760, 300);

        
            edit_cv_text.Anchor = AnchorStyles.None;
            edit_cv_text.Size = new Size(300, 50);
            edit_cv_text.Font = Custom.font(12);
            edit_cv_text.Location = new Point(980, 300);
            edit_cv_text.Enabled = false;

            edit_cv_button.Text = "New file";
            edit_cv_button.Anchor = AnchorStyles.None;
            edit_cv_button.Size = new Size(100, 40);
            edit_cv_button.Font = Custom.font(16);
            edit_cv_button.Location = new Point(1300, 300);
            edit_cv_button.Click += cv_clicked;

            edit_certificate.Text = "Certificate: ";
            edit_certificate.Anchor = AnchorStyles.None;
            edit_certificate.Size = new Size(210, 50);
            edit_certificate.Font = Custom.font(16);
            edit_certificate.Location = new Point(760, 340);

            edit_certificate_text.Anchor = AnchorStyles.None;
            edit_certificate_text.Size = new Size(300, 50);
            edit_certificate_text.Font = Custom.font(12);
            edit_certificate_text.Location = new Point(980, 340);
            edit_certificate_text.Enabled =false;

            edit_certificate_button.Text = "New file";
            edit_certificate_button.Anchor = AnchorStyles.None;
            edit_certificate_button.Size = new Size(100, 40);
            edit_certificate_button.Font = Custom.font(16);
            edit_certificate_button.Location = new Point(1300, 340);
            edit_certificate_button.Click += certificate_clicked;

            edit_workStatus.Text = "Work status: ";
            edit_workStatus.Anchor = AnchorStyles.None;
            edit_workStatus.Size = new Size(210, 50);
            edit_workStatus.Font = Custom.font(16);
            edit_workStatus.Location = new Point(760, 440);
            
            active.Text = "Active";
            active.Anchor = AnchorStyles.None;
            active.Size = new Size(210, 50);
            active.Font = Custom.font(16);
            active.Location = new Point(980, 440);


            notworking.Text = "Not working";
            notworking.Anchor = AnchorStyles.None;
            notworking.Size = new Size(300, 50);
            notworking.Font = Custom.font(16);
            notworking.Location = new Point(1200, 440);
          
          

            edit_bio_text.PlaceholderText = applicant.skill_description;
            edit_bio_text.Anchor = AnchorStyles.None;
            edit_bio_text.Multiline = true;
            edit_bio_text.WordWrap = true;
            edit_bio_text.Size = new Size(500, 200);
            edit_bio_text.Font = Custom.font(12);
            edit_bio_text.Location = new Point(180, 380);


            edit_save.Text = "Save";
            edit_save.Anchor = AnchorStyles.None;
            edit_save.Size = new Size(120, 40);
            edit_save.Font = Custom.font(16);
            edit_save.Location = new Point(1300, 640);
            edit_save.Click += edit_save_click;

            edit_close.Text = "Close";
            edit_close.Anchor = AnchorStyles.None;
            edit_close.Size = new Size(120, 40);
            edit_close.Font = Custom.font(16);
            edit_close.Location = new Point(1150, 640);
            edit_close.Click += edit_close_click;


            editpanel.Controls.Add(edit_label);
            editpanel.Controls.Add(edit_name);
            editpanel.Controls.Add(edit_phone);
            editpanel.Controls.Add(edit_exp);
            editpanel.Controls.Add(edit_bio);
            editpanel.Controls.Add(edit_category);
            editpanel.Controls.Add(edit_cv);
            editpanel.Controls.Add(edit_certificate);
            editpanel.Controls.Add(edit_cv_button);
            editpanel.Controls.Add(edit_certificate_button);
            editpanel.Controls.Add(edit_workStatus);
            editpanel.Controls.Add(edit_name_text);
            editpanel.Controls.Add(edit_phone_text);
            editpanel.Controls.Add(edit_bio_text);
            editpanel.Controls.Add(edit_exp_text);
            editpanel.Controls.Add(edit_category_text);
            editpanel.Controls.Add(edit_cv_text);
            editpanel.Controls.Add(edit_certificate_text);
            editpanel.Controls.Add(active);
            editpanel.Controls.Add(notworking);
            editpanel.Controls.Add(edit_save);
            editpanel.Controls.Add(edit_close);

            PictureBox profileImg = new PictureBox();
            Label UserNameL = new Label();
            Label Email = new Label();
            Label PhoneNum = new Label();
            Label Status = new Label();
            Label Bio = new Label();
            borderedPanels BioP = new borderedPanels();
            Label bioT = new Label();
            Label Experience = new Label();
            Label CV = new Label();
            topButtons cvP = new topButtons(0);
            borderedscrollPanels cvs = new borderedscrollPanels();
            Label CertificationsLabel = new Label();
            topButtons Certification = new topButtons(0);
           // borderedscrollPanels CertificationScroll = new borderedscrollPanels();
            topButtons edit = new topButtons(0);
           // topButtons Certification = new topButtons(Color.AliceBlue, Color.Coral);
            //Label UserName = new Label();

            profileImg.Size = new Size(140, 140);
            profileImg.Location = new Point(40, 25);
            profileImg.BorderStyle = BorderStyle.None;  
            //profileImg.BackColor = Color.OrangeRed;
            profileImg.Load(Application.StartupPath + "..\\..\\..\\Image\\png-clipart-logo-house-home-house-angle-building.png");

            //     profileImg.Controls.Add(new Label("profile image"));

            UserNameL.Text = "Name: "+applicant.name;
            UserNameL.Anchor = AnchorStyles.None;
            UserNameL.Font = Custom.font(15);
            UserNameL.Location = new Point(40, 170);
            UserNameL.Size = new Size(200, 40);

            Email.Text = "Email: "+applicant.email;
            Email.Anchor = AnchorStyles.None;
            Email.Font = Custom.font(15);
            Email.Location = new Point(40, 210);
            Email.Size = new Size(400, 40);

            PhoneNum.Text = "Phone: " + applicant.PhoneNum;
            PhoneNum.Anchor = AnchorStyles.None;
            PhoneNum.Font = Custom.font(15);
            PhoneNum.Location = new Point(40, 250);
            PhoneNum.Size = new Size(400, 40);

            Status.Text = "Status: " + applicant.work_status;
            Status.Anchor = AnchorStyles.None;
            Status.Font = Custom.font(15);
            Status.Location = new Point(40, 290);
            Status.Size = new Size(400, 40);


            Bio.Text = "Bio: " ;
            Bio.Anchor = AnchorStyles.None;
            Bio.Font = Custom.font(15);
            Bio.Location = new Point(40, 330);
            Bio.Size = new Size(200, 30);

            BioP.Size = new Size(400, 200);
            BioP.Location = new Point(40, 370);
            BioP.Anchor = AnchorStyles.None;
            BioP.BackColor = Color.Coral;

            bioT.Text = applicant.skill_description;
            bioT.Anchor = AnchorStyles.None;
            bioT.ForeColor = Color.White;
            bioT.Font = Custom.font(12);
            bioT.AllowDrop = true;
            bioT.Size = new Size(350,160);
            bioT.BorderStyle = BorderStyle.None;
            bioT.Location = new Point(25, 20);
            BioP.Controls.Add(bioT);

            Experience.Text = "Experience: " + applicant.experience;
            Experience.Anchor = AnchorStyles.None;
            Experience.Font = Custom.font(15);
            Experience.Location = new Point(400, 170);
            Experience.Size = new Size(400, 30);

            CV.Text = "Curriculum Vitae";
            CV.Anchor = AnchorStyles.None;
            CV.Font = Custom.font(15);
            CV.Location = new Point(900, 40);
            CV.Size = new Size(400, 30);

            cvP.Size = new Size(290, 50);
            cvP.Text = "View";
            cvP.Font = Custom.font(17);
            cvP.Location = new Point(880, 80);
            cvP.Anchor = AnchorStyles.None;
            cvP.Click += (sender, e) => show_cv(sender, e, applicant.cv);
           

            CertificationsLabel.Text = "Certification";
            CertificationsLabel.Anchor = AnchorStyles.None;
            CertificationsLabel.Font = Custom.font(15);
            CertificationsLabel.Location = new Point(900, 140);
            CertificationsLabel.Size = new Size(400, 30);

            Certification.Anchor = AnchorStyles.None;
            Certification.Size = new Size(290, 50);
            Certification.Font = Custom.font(17);
            Certification.Text = "View";
            Certification.Location = new Point(880, 180);
            Certification.Click += (sender, e) => showcertificate(sender, e, applicant.certificateFile);
            



            edit.Anchor = AnchorStyles.None;
            edit.Font = Custom.font(17);
            edit.Text = "Edit";
            edit.Size = new Size(290, 50);
            edit.Location = new Point(935, 600);
            edit.Click += edit_click;

            profilePane.Controls.Add(profileImg);
            profilePane.Controls.Add(UserNameL);
            profilePane.Controls.Add(Experience);
            profilePane.Controls.Add(Email);
            profilePane.Controls.Add(PhoneNum);
            profilePane.Controls.Add(Status);
            profilePane.Controls.Add(Bio);
            profilePane.Controls.Add(BioP);
            profilePane.Controls.Add(CV);
            profilePane.Controls.Add(cvP);
            profilePane.Controls.Add(CertificationsLabel);
            profilePane.Controls.Add(Certification);
            profilePane.Controls.Add(edit);
            edit.BringToFront();

            subMain.Anchor = AnchorStyles.None;
            subMain.AutoScroll = true;
            subMain.BackColor = Color.Coral;
            subMain.Size = new Size(1443, 705);
            subMain.Location = new Point(-617, -220);
            subMain.BorderStyle = BorderStyle.None;


            companyname1.AccessibleName = "";
            companyname1.Anchor = AnchorStyles.None;
            companyname1.AutoSize = true;
            companyname1.Font = new Font("Cascadia Mono", 55F);
            companyname1.Location = new Point(-90, 11);
            companyname1.Name = "companyname1";
            companyname1.Size = new Size(376, 122);
            companyname1.TabIndex = 0;
            companyname1.ForeColor= Color.White;
            companyname1.Text = "JOB IN";
          

            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(companyname1);
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(-860, -500);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 143);
            panel1.TabIndex = 0;

            Label welcome = new Label();
            welcome.Text = "WELCOME, " + applicant.name.ToUpperInvariant();
            welcome.Font = Custom.font(30);
            welcome.Anchor = AnchorStyles.None;
            welcome.Location = new Point(-200, -450);
            welcome.ForeColor = Color.OrangeRed;
            welcome.Size = new Size(850, 100);

            MainPanel.Controls.Add(welcome);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(jobs);
            MainPanel.Controls.Add(search);
            MainPanel.Controls.Add(status);
            MainPanel.Controls.Add(profile);
            MainPanel.Controls.Add(exit);
            subMain.Controls.Add(jobsPane);
            subMain.Controls.Add(searchPane);
            subMain.Controls.Add(statusPane);
            subMain.Controls.Add(profilePane);
            MainPanel.Controls.Add(subMain);
            MainPanel.Controls.Add(editpanel);
            editpanel.Hide();
            

            MainPanel.Anchor = AnchorStyles.None;
            MainPanel.BackColor = Color.White;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1920, 1080);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);


            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1635, 920);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(MainPanel);
            Name = "Applicant";
            Text = "Applicant";

            this.FormClosing += CloseApp;


        }

        private void edit_close_click(object? sender, EventArgs e)
        {


            edit_name_text.Clear();
            edit_phone_text.Clear();
            edit_bio_text.Clear();
            edit_certificate_text.Clear();
            edit_cv_text.Clear();
            edit_cv_text.Clear();
            edit_certificate_path = "";
            edit_certificate_path ="";
            editpanel.Hide();

        }
        private void phone_check(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            Match match = regex.Match(edit_phone_text.Text);

            if (!match.Success)
            {
                MessageBox.Show("Please enter exactly 10 digits.");
                edit_phone_text.Text = string.Empty;
                edit_phone_text.Focus();
            }
        }
        private void edit_save_click(object? sender, EventArgs e)
        {

            byte[] cvFile = { };
            byte[] certificateFile = { };
            if (string.IsNullOrEmpty(edit_name_text.Text)) edit_name_text.Text = edit_name_text.PlaceholderText;
            if (string.IsNullOrEmpty(edit_phone_text.Text)) edit_phone_text.Text = edit_phone_text.PlaceholderText;
            if (string.IsNullOrEmpty(edit_bio_text.Text)) edit_bio_text.Text = edit_bio_text.PlaceholderText;
            if (string.IsNullOrEmpty(edit_cv_text.Text))
            {
                MessageBox.Show("Please select a Cv file");
                return;
            }
            else
            {
                if (checkExtension(edit_cv_path))
                {
                    try
                    {
                        cvFile = File.ReadAllBytes(edit_cv_path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file type. Please upload a PDF file.");
                    edit_cv_text.Text = "";
                }
            }
            if (string.IsNullOrEmpty(edit_certificate_text.Text))
            {

                MessageBox.Show("Please select a Certificate file");
                return;
            }
            else
            {
                if (checkExtension(edit_certificate_path))
                {
                    try
                    {
                        certificateFile = File.ReadAllBytes(edit_certificate_path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file type. Please upload a PDF file.");
                    edit_cv_text.Text = "";
                }
            }

            string stat;
            if (active.Checked)
            {
                stat = "Active";
            }
            else
            {
                stat = "notworking";
            }

            int p = int.Parse(edit_phone_text.Text);
            edit_phone_text.Text = p.ToString("D10");

            if(Db.update_applicant(applicant.email, edit_name_text.Text,edit_phone_text.Text,(int) edit_exp_text.Value, edit_bio_text.Text, edit_category_text.Text, cvFile, certificateFile, stat))
            {
                applicant = Db.fetchApplicantinfo(applicant.email);
                refresh();
            }
        }
        
        public void refresh()
        {
            MessageBox.Show("Restarting now");
            Application.Restart();
        }

        private void edit_click(object? sender, EventArgs e)
        {
             editpanel.Show();
            edit_name_text.PlaceholderText = applicant.name;
            edit_phone_text.PlaceholderText = applicant.PhoneNum;
            edit_bio_text.PlaceholderText = applicant.skill_description;
            edit_exp_text.Value = applicant.experience;
            edit_category_text.SelectedIndex = (int)Custom.job_category.IndexOf(applicant.category);
            if (applicant.work_status == "Active")
            {
                active.Checked = true;
            }
            else
            {
                notworking.Checked = true;
            }
            editpanel.BringToFront();
        }

        private void pending_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("pending");
            job_history_adder("pending");
        }

        private void denied_button_click(object? sender, EventArgs e)
        {
            selectedButtonStatus("denied");
            job_history_adder("denied");
        }

        private void accepted_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("accepted");
            job_history_adder("accepted");
        }

        private void all_button_nav(object? sender, EventArgs e)
        {
            selectedButtonStatus("all");
            job_history_adder("all");
        }

        private void searchResultFetch(object? sender, EventArgs e, string search)
        {
            searchResultsPane.Controls.Clear();
            if (search == "") {
                Panel wrap = new Panel();
                // wrap.BackColor = Color.Azure;
                wrap.Size = new Size(1250, 160);

                Label noResult = new Label();
                noResult.Anchor = AnchorStyles.None;
                noResult.BorderStyle = BorderStyle.None;
                noResult.Font = Custom.font(23);
                noResult.Size = new Size(600, 90);
                noResult.Text = "No results found...";
                noResult.BackColor = Color.FromArgb(0, Color.White);
                noResult.Location = new Point(400, 80);
                wrap.Controls.Add(noResult);
                searchResultsPane.Controls.Add(wrap);
            }
        
            else
            {
                ArrayList arr = Db.fetchJobName(search);
                if (arr.Count == 0)
                {
                    Panel wrap = new Panel();
                    // wrap.BackColor = Color.Azure;
                    wrap.Size = new Size(1250, 160);

                    Label noResult = new Label();
                    noResult.Anchor = AnchorStyles.None;
                    noResult.BorderStyle = BorderStyle.None;
                    noResult.Font = Custom.font(23);
                    noResult.Size = new Size(600, 90);
                    noResult.Text = "No results found...";
                    noResult.BackColor = Color.FromArgb(0, Color.White);
                    noResult.Location = new Point(400, 80);
                    
                   

                    wrap.Controls.Add(noResult);
                    searchResultsPane.Controls.Add(wrap);
                }
                else
                {
                    foreach (Job j in arr)
                    {

                        jobDesc jd = new jobDesc(j.name, j.description, j.requirement);
                        //jd.Size = new Size(1100, 400);
                        jd.more.Location = new Point(930, 230);
                        jd.more.Click += (sender, e) => jobExpand(sender, e, j.id);
                        searchResultsPane.Controls.Add(jd);
                    }
                }
            }
            
        }



        private void selectedButton(string button)
        {
            if (button == "jobs")
            {
                jobs.BackColor= Color.AliceBlue;
                jobs.ForeColor = Color.Coral;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "search")
            {
                search.BackColor = Color.AliceBlue;
                search.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "status")
            {
                status.BackColor = Color.AliceBlue;
                status.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
                profile.BackColor = Color.Coral;
                profile.ForeColor = Color.Black;
            }
            else if (button == "profile")
            {
                profile.BackColor = Color.AliceBlue;
                profile.ForeColor = Color.Coral;
                jobs.BackColor = Color.Coral;
                jobs.ForeColor = Color.Black;
                status.BackColor = Color.Coral;
                status.ForeColor = Color.Black;
                search.BackColor = Color.Coral;
                search.ForeColor = Color.Black;
            }
        }

        private void selectedButtonStatus(string button)
        {
            if (button == "all")
            {
                sAllbutton.BackColor = Color.Black;
                sAllbutton.ForeColor = Color.White;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black;
            }
            else if (button == "accepted")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Black;
                sAcceptedbutton.ForeColor = Color.White;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black;
            }
            else if (button == "pending")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Orange;
                sDeniedbutton.ForeColor = Color.Black;
                sPendingbutton.BackColor = Color.Black;
                sPendingbutton.ForeColor = Color.White;
            }
            else if (button == "denied")
            {
                sAllbutton.BackColor = Color.Orange;
                sAllbutton.ForeColor = Color.Black;
                sAcceptedbutton.BackColor = Color.Orange;
                sAcceptedbutton.ForeColor = Color.Black;
                sDeniedbutton.BackColor = Color.Black;
                sDeniedbutton.ForeColor = Color.White;
                sPendingbutton.BackColor = Color.Orange;
                sPendingbutton.ForeColor = Color.Black; ;
            }
        }

        private void job_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("jobs");
            jobsPane.BringToFront();
            jobsPane.Controls.Clear();
            this.job_list_adder();
           
        }

        private void search_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("search");
            searchPane.BringToFront();
           

        }

        private void status_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("status");
            statusPane.BringToFront();


            status_lock(Db.Applied_History_Count(applicant.email));
           


        }

        public void status_lock(int i)
        {
            borderedPanels b = new borderedPanels();
            if (i == 0)
            {
                sAllbutton.Hide();
                sAcceptedbutton.Hide();
                sDeniedbutton.Hide();
                sPendingbutton.Hide();
                Label l = new Label();
                l.Text = "No Job history, Apply to jobs to see history.";
                l.Font = Custom.font(20);
                l.Size = new Size(400, 40);

              
                b.Size = new Size(700, 400);
                b.Location = new Point(600, 300);
                b.Controls.Add(l);

                statusScrollPane.Controls.Clear();
                statusPane.Controls.Add(b);
                b.BringToFront();
                statusPane.MinimumSize = new Size(1434, 675);
            }
            else
            {

                sAllbutton.Show();
                sAcceptedbutton.Show();
                sDeniedbutton.Show();
                sPendingbutton.Show();
                job_history_adder("all");
                statusScrollPane.BringToFront();
                b.Hide();
                statusPane.MaximumSize = new Size(1413, 675);

            }
        }

        private void profile_nav_MouseClick(object? sender, EventArgs e)
        {
            selectedButton("profile");
            profilePane.BringToFront();

        }

        // 
        public  void  job_list_adder()
        {
            ArrayList arr = Db.fetchJobs(applicant.category);
            jobsPane.Controls.Clear();
            if (arr.Count==0)
            {
                borderedPanels b = new borderedPanels();
                b.Size = new Size(1410, 650);
                b.BackColor = Color.White;
                b.Anchor = AnchorStyles.None;
                b.Location = new Point(1000, 700);

                Label l = new Label();
                l.ForeColor = Color.Black;
                l.Text = "No "+applicant.category+" jobs available, Try again later";
                
                l.Font = Custom.font(24);
                l.Anchor = AnchorStyles.None;
                l.Size = new Size(900, 150);
                l.Location = new Point(340, 280);

                b.Controls.Add(l);
                jobsPane.Controls.Add(b);
            }
            else
            {
                foreach (Job j in arr)
                {

                    jobDesc jd = new jobDesc(j.name, j.description, j.requirement);
                    jd.more.Click += (sender, e) => jobExpand(sender, e, j.id);
                    jobsPane.Controls.Add(jd);

                }
            }
            
        }

        private void jobExpand(object? sender, EventArgs e, int id)
        {
            jobDescDetail a = new jobDescDetail(id);
            a.Apply.Click += (sender, e) => Apply_Click(sender, e, id);
            MainPanel.Controls.Add(a);
            a.BringToFront();
        }

        private void Apply_Click(object? sender, EventArgs e, int id)
        {
            if(Db.apply(id, applicant.email))
            {
                MessageBox.Show("Applied Successfully");
            }
        }


        //Fetches the job info as a series of strings from the database and creates a panel that will be added to an array list
        public void job_list_fetcher(ArrayList jobList)
        {

        }

        //needs db
        public void job_history_fetcher()
        {

        }
       
        
        public void job_history_adder(string stat)
        {
            statusScrollPane.Controls.Clear();

            ArrayList arr= Db.Applied_History(applicant.email, stat);
            if(arr.Count == 0)
            {
                Label l = new Label();
                l.Text = "No Job history, Apply to jobs to see history.";
                l.Font = Custom.font(20);
                l.Size = new Size(400, 40);
                
                borderedPanels b = new borderedPanels();
                b.Size = new Size(1150, 400);
                b.Controls.Add(l);
                statusScrollPane.Controls.Add(b);
            }
            else
            {
                foreach (int i in arr)
                {
                    Job j = Db.fetchJobId(i);
                    statusScrollPane.Controls.Add(new jobHistory(j.name, j.oEmail, j.category, j.requirement, j.Deadline.ToString()));
                }
            }
           
        }


        private static void CloseApp(object? sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }


        private void ClosePanel(object? sender, EventArgs e)
        {
            this.Close();
            MainPanel.BringToFront();

            // Application.Exit();
        }

        public  void return_to_login(Object sender, EventArgs e, Form1 f)
        {
            f.Show();
            f.activeForm.Controls.Remove(this);
            this.Hide();
          
        }
        private void showcertificate(object sender, EventArgs e, byte[] a)
        {
            string tempfilepath = Application.StartupPath + "..\\..\\..\\cv\\certificate" + ".pdf";
            File.WriteAllBytes(tempfilepath, a);
            Process.Start(new ProcessStartInfo { FileName = tempfilepath, UseShellExecute = true });
        }

        private void show_cv(object sender, EventArgs e, byte[] a)
        {
            string tempfilepath = Application.StartupPath + "..\\..\\..\\cv\\cv" + ".pdf";
            File.WriteAllBytes(tempfilepath, a);
            Process.Start(new ProcessStartInfo { FileName = tempfilepath, UseShellExecute = true });
        }
        private void certificate_clicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    MessageBox.Show("Selected file: " + filePath);
                    edit_certificate_path= filePath;
                    edit_certificate_text.Text = edit_certificate_path;

                }
            }
        }
        private void cv_clicked(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    MessageBox.Show("Selected file: " + filePath);
                    edit_cv_path = filePath;
                    edit_cv_text.Text = edit_cv_path;

                }
            }
        }
        private bool checkExtension(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName).ToLower();
            string[] allowedExtensions = { ".pdf" };

            if (!allowedExtensions.Contains(fileExtension))
            {
                return false;
            }
            return true;
        }

    }



}
