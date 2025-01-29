using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.DirectoryServices.ActiveDirectory;
using JOB_IN.RJControls;
namespace JOB_IN
{


    public class RoundedTextBox : TextBox
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }
    }


    partial class ApplicantSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        public class RoundedButton : Button
        {
            public int radius = 70;
            protected override void OnCreateControl()
            {
                base.OnCreateControl();
                UpdateRegion();
            }

            private void UpdateRegion()
            {
                GraphicsPath path = new GraphicsPath();
                //int radius = 70;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
                Invalidate();
            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                UpdateRegion();
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            mainPanel1 = new Panel();
            mainPanel1.Size = new Size(1920, 1080);
            mainPanel1.BackColor = Color.Black;

            // title panel
            titlePanel = new Panel();
            titlePanel.Anchor = AnchorStyles.None;
            titlePanel.Size = new Size(1920, 222);
            titlePanel.BackColor = Color.White;

            // title label
            titleLabel = new Label();
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.Size = new Size(1920, 210);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Text = "Applicant SignUp";
            titleLabel.Font = Custom.font(42);

            backBtn = new RoundedButton();
            backBtn.Anchor = AnchorStyles.None;
            backBtn.Size = new Size(130, 40);
            backBtn.radius = 10;
            backBtn.Location = new Point(50, 170);
            backBtn.Text = "< Back";
            backBtn.BackColor = Color.White;
            backBtn.ForeColor = Color.Black;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderColor = Color.Red;
            backBtn.Font = Custom.font(14);
            backBtn.Cursor = Cursors.Hand;
            backBtn.Visible = false;
            backBtn.Click += OnbackBtn_clicked;

            // information gathering panel
            infoPanel = new Panel();
            infoPanel.Anchor = AnchorStyles.None;
            infoPanel.Size = new Size(1920, 980);
            infoPanel.BackColor = Color.FromArgb(238, 164, 127);

            // Name label
            nameLabel = new Label();
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.Size = new Size(540, 40);
            nameLabel.Location = new Point(150, 318);
            nameLabel.Text = "Name";
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = Custom.font(18);

            // Name Field 
            nameField = new RoundedTextBox();
            nameField.Anchor = AnchorStyles.None;
            //nameField.Size = new Size(432, 100);
            nameField.Location = new Point(150, 374);
            nameField.MinimumSize = new Size(432, 40);
            nameField.TextAlign = HorizontalAlignment.Left;
            nameField.PlaceholderText = "Enter your name";
            nameField.BorderStyle = BorderStyle.None;            
            nameField.Font = Custom.font(14);



            // Phone number label
            phoneNumLabel = new Label();
            phoneNumLabel.Anchor = AnchorStyles.None;
            phoneNumLabel.Size = new Size(540, 40);
            phoneNumLabel.Location = new Point(150, 484);
            phoneNumLabel.Text = "Phone Number";
            phoneNumLabel.ForeColor = Color.White;
            phoneNumLabel.Font = Custom.font(18);

            // Phone number field 
            phoneNumField = new RoundedTextBox();
            phoneNumField.Anchor = AnchorStyles.None;
            phoneNumField.Size = new Size(432, 100);
            phoneNumField.MinimumSize = new Size(432, 40);
            phoneNumField.Location = new Point(150, 537);
            phoneNumField.PlaceholderText = "09--------";
            phoneNumField.BorderStyle = BorderStyle.None;
            phoneNumField.Font = Custom.font(14);

            // Date of birth label
            DOBLabel = new Label();
            DOBLabel.Anchor = AnchorStyles.None;
            DOBLabel.Size = new Size(540, 40);
            DOBLabel.Location = new Point(150, 637);
            DOBLabel.Text = "Date of Birth";
            DOBLabel.ForeColor = Color.White;
            DOBLabel.Font = Custom.font(18);

            // Date of birth field
            DobField = new DateTimePicker();
            DobField.Anchor = AnchorStyles.None;
            DobField.Size = new Size(230, 50);
            DobField.Location = new Point(150, 693);
            DobField.Format = DateTimePickerFormat.Short;

            // Email label 
            emailLabel = new Label();
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.Size = new Size(540, 40);
            emailLabel.Location = new Point(1175, 318);
            emailLabel.Text = "Email";
            emailLabel.ForeColor = Color.White;
            emailLabel.Font = Custom.font(18);


            // Email Field 
            emailField = new RoundedTextBox();
            emailField.Anchor = AnchorStyles.None;
            emailField.Size = new Size(432, 100);
            emailField.MinimumSize = new Size(432, 40);
            emailField.Location = new Point(1175, 374);
            emailField.PlaceholderText = "example@gmail.com";
            emailField.BorderStyle = BorderStyle.None;
            emailField.Font = Custom.font(14);

            // password label
            passwordLabel = new Label();
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.Size = new Size(540, 40);
            passwordLabel.Location = new Point(1175, 484);
            passwordLabel.Text = "Password";
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Font = Custom.font(18);

            // password field
            passwordField = new RoundedTextBox();
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Size = new Size(432, 100);
            passwordField.MinimumSize = new Size(432, 40);
            passwordField.Location = new Point(1175, 537);
            passwordField.PlaceholderText = "*********";
            passwordField.PasswordChar = '*';
            passwordField.Font = new Font("Sans serif", 16f);
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Font = Custom.font(14);

            // show and hide password button
            showPasswordBtn = new RoundedButton();
            showPasswordBtn.Anchor = AnchorStyles.None;
            showPasswordBtn.radius = 10;
            showPasswordBtn.Size = new Size(100, 45);
            showPasswordBtn.Location = new Point(1610, 535);
            showPasswordBtn.Text = "Show";
            showPasswordBtn.Font = Custom.font(14);
            showPasswordBtn.BackColor = Color.White;
            showPasswordBtn.FlatStyle = FlatStyle.Flat;
            showPasswordBtn.FlatAppearance.BorderColor = Color.White;
            showPasswordBtn.Cursor = Cursors.Hand;
            showPasswordBtn.Click += showPasswordBtn_clicked;

            // Next Button
            nextBtn = new RoundedButton();
            nextBtn.radius = 20;
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.Size = new Size(200, 70);
            nextBtn.Location = new Point(1597, 878);
            nextBtn.Text = "Next >>";
            nextBtn.BackColor = Color.Black;
            nextBtn.ForeColor = Color.White;
            nextBtn.Font = Custom.font(18);
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.FlatAppearance.BorderColor = Color.FromArgb(238, 164, 127); ;
            nextBtn.Click += next_btn_click;


            exitBtn = new RoundedButton();
            exitBtn.Anchor = AnchorStyles.None;
            exitBtn.radius = 20;
            exitBtn.Size = new Size(200, 70);
            exitBtn.Location = new Point(1620, 820);
            exitBtn.Text = "Exit";
            exitBtn.Font = Custom.font(18);
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = Color.White;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.FlatAppearance.BorderColor = Color.FromArgb(238, 164, 127);
            exitBtn.Click += exitBtn_clicked;

            //Second main panel
            infoPanel2 = new Panel();
            infoPanel2.Anchor = AnchorStyles.None;
            infoPanel2.Size = new Size(1920, 980);
            infoPanel2.BackColor = Color.White;

            // Skill Descrition and achievent label
            skillLabel = new Label();
            skillLabel.Anchor = AnchorStyles.None;
            skillLabel.Size = new Size(644, 66);
            skillLabel.Location = new Point(47, 269);
            skillLabel.Text = "Skill Description and Achievments";
            skillLabel.ForeColor = Color.Black;
            skillLabel.Font = Custom.font(16);

            // skill and achievements field
            skillField = new RoundedTextBox();
            skillField.Anchor = AnchorStyles.None;
            skillField.Multiline = true;
            skillField.Size = new Size(1290, 285);
            skillField.Location = new Point(47, 335);
            skillField.ScrollBars = ScrollBars.Vertical;
            skillField.Font = new Font("Arial", 12f);
            skillField.BackColor = Color.LightGray;
            skillField.BorderStyle = BorderStyle.None;  
          

            // Cv Label
            cvLabel = new Label();
            cvLabel.Anchor = AnchorStyles.None;
            cvLabel.Size = new Size(372, 46);
            cvLabel.Location = new Point(57, 643);
            cvLabel.Text = "Curriculum Vitae (CV)";
            cvLabel.ForeColor = Color.Black;
            cvLabel.Font = Custom.font(16);


            // Cv Field
            cvField = new RoundedTextBox();
            cvField.Anchor = AnchorStyles.None;
            cvField.MinimumSize = new Size(420, 45);
            cvField.Location = new Point(57, 704);
            cvField.Font = Custom.font(14);
            cvField.BackColor = Color.Black;
            cvField.ForeColor = Color.White;
            cvField.BorderStyle = BorderStyle.None;


            // Choose Btn
            chooseFileBtn = new RoundedButton();
            chooseFileBtn.Anchor = AnchorStyles.None;
            chooseFileBtn.radius = 20;
            chooseFileBtn.Size = new Size(230, 70);
            chooseFileBtn.Location = new Point(478, 695);
            chooseFileBtn.Text = "Choose File";
            chooseFileBtn.BackColor = Color.Coral;
            chooseFileBtn.ForeColor = Color.White;
            chooseFileBtn.FlatStyle = FlatStyle.Flat;
            chooseFileBtn.FlatAppearance.BorderColor = Color.White;
            chooseFileBtn.Cursor = Cursors.Hand;
            chooseFileBtn.Font = Custom.font(16);
            chooseFileBtn.Click += OnChooseFile_clicked;


            // Certification label
            certificationLabel = new Label();
            certificationLabel.Anchor = AnchorStyles.None;
            certificationLabel.Size = new Size(372, 46);
            certificationLabel.Location = new Point(57, 790);
            certificationLabel.Text = "Certificate";
            certificationLabel.ForeColor = Color.Black;
            certificationLabel.Font = Custom.font(16);


            // certification adding field
            certificationField = new RoundedTextBox();
            certificationField.Anchor = AnchorStyles.None;
            certificationField.MinimumSize = new Size(580, 45);
            certificationField.Location = new Point(57, 846);
            certificationField.BackColor = Color.Black;
            certificationField.Font = Custom.font(16);
            certificationField.BorderStyle = BorderStyle.None;
            certificationField.ForeColor = Color.White;

            // cerification add button
            addCertificateBtn = new RoundedButton();
            addCertificateBtn.Size = new Size(45, 45);
            addCertificateBtn.radius = 43;
            addCertificateBtn.Location = new Point(641, 847);
            addCertificateBtn.Text = "+";
            addCertificateBtn.TextAlign = ContentAlignment.MiddleCenter;
            addCertificateBtn.Font = Custom.font(16);
            addCertificateBtn.ForeColor = Color.Black;
            addCertificateBtn.BackColor = Color.LightGray;
            addCertificateBtn.FlatAppearance.BorderColor = Color.LightGray;
            addCertificateBtn.FlatStyle = FlatStyle.Flat;
            addCertificateBtn.Click += OnPlusSign_clicked;

            // Job category label
            jobCategoryLabel = new Label();
            jobCategoryLabel.Anchor = AnchorStyles.None;
            jobCategoryLabel.Size = new Size(278, 66);
            jobCategoryLabel.Location = new Point(1453, 274);
            jobCategoryLabel.Text = "Job Category";
            jobCategoryLabel.ForeColor = Color.Black;
            jobCategoryLabel.Font = Custom.font(16);


            // Job category combo Box
            jobCategoryCB = new ComboBox();
            jobCategoryCB.Anchor = AnchorStyles.None;
            List<string> items = new List<string> { "Architecture and Engineering", "Arts and design", "Maintenance ", "Business and Financial", "Social Services", "Construction", "Farming and Forestry", "Healthcare support", "Installation and repair", "Legal", "Office and Administrative", "Personal care and service ", "Sales", "Tech and Web development", "Others" };
            jobCategoryCB.DataSource = items;
            jobCategoryCB.Size = new Size(432, 76);
            jobCategoryCB.Location = new Point(1390, 340);
            jobCategoryCB.BackColor = Color.Black;
            jobCategoryCB.ForeColor = Color.White;
            jobCategoryCB.Font = Custom.font(14);
            jobCategoryCB.FlatStyle = FlatStyle.Flat;


            // Experience Label
            experienceLabel = new Label();
            experienceLabel.Anchor = AnchorStyles.None;
            experienceLabel.Size = new Size(278, 46);
            experienceLabel.Location = new Point(1436, 422);
            experienceLabel.Text = "Experience";
            experienceLabel.Font = Custom.font(16);
            experienceLabel.ForeColor = Color.Black;



            // Exeperience field
            experienceField = new RoundedTextBox();
            experienceField.Anchor = AnchorStyles.None;
            experienceField.Size = new Size(145, 76);
            experienceField.Location = new Point(1390, 480);
            experienceField.Font = Custom.font(16);
            experienceField.ForeColor = Color.White;
            experienceField.BackColor = Color.Black;
            experienceField.BorderStyle = BorderStyle.None;
            experienceField.TextAlign = HorizontalAlignment.Center;

            // Years label
            yearsLabel = new Label();
            yearsLabel.Anchor = AnchorStyles.None;
            yearsLabel.Text = "Years";
            yearsLabel.Size = new Size(122, 36);
            yearsLabel.Location = new Point(1540, 480);
            yearsLabel.ForeColor = Color.Black;
            yearsLabel.Font = Custom.font(16);

            // Work status label
            workStatusLabel = new Label();
            workStatusLabel.Anchor = AnchorStyles.None;
            workStatusLabel.Text = "Work status";
            workStatusLabel.Size = new Size(278, 46);
            workStatusLabel.Location = new Point(1450, 570);
            workStatusLabel.ForeColor = Color.Black;
            workStatusLabel.Font = Custom.font(16);

            // Work status radio button
            statusRadioBtn1 = new RadioButton();
            statusRadioBtn1.Anchor = AnchorStyles.None;
            statusRadioBtn1.Text = "Active";
            statusRadioBtn1.Size = new Size(120, 46);
            statusRadioBtn1.Location = new Point(1410, 635);
            statusRadioBtn1.ForeColor = Color.Black;
            statusRadioBtn1.Font = Custom.font(14);
            statusRadioBtn1.Checked = true;


            statusRadioBtn2 = new RadioButton();
            statusRadioBtn2.Anchor = AnchorStyles.None;
            statusRadioBtn2.Text = "Non-Active";
            statusRadioBtn2.Size = new Size(223, 46);
            statusRadioBtn2.Location = new Point(1540, 636);
            statusRadioBtn2.ForeColor = Color.Black;
            statusRadioBtn2.Font = Custom.font(14);


            // submit button
            submitBtn = new RoundedButton();
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Text = "Submit";
            submitBtn.radius = 20;
            submitBtn.Size = new Size(200, 70);
            submitBtn.Location = new Point(1380, 820);
            submitBtn.ForeColor = Color.Black;
            submitBtn.BackColor = Color.FromArgb(238, 164, 127);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.Font = Custom.font(16);
            submitBtn.FlatAppearance.BorderColor = Color.White;
            submitBtn.Click += OnSubmitBtn_clicked;

            // first under line
            underlinePanel1 = new Panel();
            underlinePanel1.Anchor = AnchorStyles.None;
            underlinePanel1.Size = new Size(1414, 5);
            underlinePanel1.Location = new Point(243, 925);
            underlinePanel1.BackColor = Color.FromArgb(238, 164, 127);
            underlinePanel1.BorderStyle = BorderStyle.None;

            // second under line
            underlinePanel2 = new Panel();
            underlinePanel2.Anchor = AnchorStyles.None;
            underlinePanel2.Size = new Size(769, 5);
            underlinePanel2.Location = new Point(600, 955);
            underlinePanel2.BackColor = Color.FromArgb(238, 164, 127);
            underlinePanel2.BorderStyle = BorderStyle.None;

            // Add the title to the title panel
            titlePanel.Controls.Add(backBtn);
            titlePanel.Controls.Add(titleLabel);
            

            // Add to the info panel
            infoPanel.Controls.Add(nameLabel);
            infoPanel.Controls.Add(nameField);
            infoPanel.Controls.Add(phoneNumLabel);
            infoPanel.Controls.Add(phoneNumField);
            infoPanel.Controls.Add(DOBLabel);
            infoPanel.Controls.Add(DobField);
            infoPanel.Controls.Add(emailLabel);
            infoPanel.Controls.Add(emailField);
            infoPanel.Controls.Add(passwordLabel);
            infoPanel.Controls.Add(passwordField);
            infoPanel.Controls.Add(showPasswordBtn);            
            infoPanel.Controls.Add(nextBtn);
            
            


            // Add to the second info panel
            infoPanel2.Controls.Add(skillLabel);
            infoPanel2.Controls.Add(skillField);
            infoPanel2.Controls.Add(cvLabel);
            infoPanel2.Controls.Add(chooseFileBtn);
            infoPanel2.Controls.Add(cvField);
            infoPanel2.Controls.Add(certificationLabel);
            infoPanel2.Controls.Add(addCertificateBtn);
            infoPanel2.Controls.Add(certificationField);
            infoPanel2.Controls.Add(jobCategoryLabel);
            infoPanel2.Controls.Add(jobCategoryCB);
            infoPanel2.Controls.Add(experienceLabel);
            infoPanel2.Controls.Add(experienceField);
            infoPanel2.Controls.Add(yearsLabel);
            infoPanel2.Controls.Add(workStatusLabel);
            infoPanel2.Controls.Add(statusRadioBtn1);
            infoPanel2.Controls.Add(statusRadioBtn2);
            infoPanel2.Controls.Add(exitBtn);
            infoPanel2.Controls.Add(submitBtn);
            infoPanel2.Controls.Add(underlinePanel1);
            infoPanel2.Controls.Add(underlinePanel2);



            // Add child panels to the parent panel
            mainPanel1.Controls.Add(titlePanel);
            mainPanel1.Controls.Add(infoPanel);

            this.Controls.Add(mainPanel1);
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1920, 1080);
            this.Text = "ApplicantSignUp";
        }

        #endregion

        private Panel mainPanel1, infoPanel2, titlePanel, infoPanel, underlinePanel1, underlinePanel2;
        private Label titleLabel, nameLabel, emailLabel, phoneNumLabel, passwordLabel, DOBLabel, skillLabel, cvLabel,
            certificationLabel, jobCategoryLabel, experienceLabel, workStatusLabel, yearsLabel;
        private RoundedButton nextBtn, submitBtn, uploadBtn, addCertificateBtn, chooseFileBtn, backBtn, showPasswordBtn, exitBtn;
        private RoundedTextBox nameField, emailField, phoneNumField, passwordField, skillField, cvField, certificationField, experienceField;
        private DateTimePicker DobField;
        private ComboBox jobCategoryCB;
        private RadioButton statusRadioBtn1, statusRadioBtn2;    



    }



}