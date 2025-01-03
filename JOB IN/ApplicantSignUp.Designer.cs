using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.DirectoryServices.ActiveDirectory;
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
            titleLabel.Font = new Font("sans serif", 42f);

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
            nameLabel.Font = new Font("sans serif", 18f);

            // Name Field 
            nameField = new RoundedTextBox();
            nameField.Anchor = AnchorStyles.None;
            nameField.Size = new Size(432, 100);
            nameField.Location = new Point(150, 374);
            nameField.PlaceholderText = "Enter your name";
            nameField.BorderStyle = BorderStyle.None;
            nameField.Font = new Font("Sans serif", 14f);


            // Phone number label
            phoneNumLabel = new Label();
            phoneNumLabel.Anchor = AnchorStyles.None;
            phoneNumLabel.Size = new Size(540, 40);
            phoneNumLabel.Location = new Point(150, 484);
            phoneNumLabel.Text = "Phone Number";
            phoneNumLabel.ForeColor = Color.White;
            phoneNumLabel.Font = new Font("sans serif", 18f);

            // Phone number field 
            phoneNumField = new RoundedTextBox();
            phoneNumField.Anchor = AnchorStyles.None;
            phoneNumField.Size = new Size(432, 100);
            phoneNumField.Location = new Point(150, 537);
            phoneNumField.PlaceholderText = "09--------";
            phoneNumField.BorderStyle = BorderStyle.None;
            phoneNumField.Font = new Font("Sans serif", 14f);

            // Date of birth label
            DOBLabel = new Label();
            DOBLabel.Anchor = AnchorStyles.None;
            DOBLabel.Size = new Size(540, 40);
            DOBLabel.Location = new Point(150, 637);
            DOBLabel.Text = "Date of Birth";
            DOBLabel.ForeColor = Color.White;
            DOBLabel.Font = new Font("sans serif", 18f);

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
            emailLabel.Font = new Font("Sans serif", 18f);


            // Email Field 
            emailField = new RoundedTextBox();
            emailField.Anchor = AnchorStyles.None;
            emailField.Size = new Size(432, 100);
            emailField.Location = new Point(1175, 374);
            emailField.PlaceholderText = "example@gmail.com";
            emailField.BorderStyle = BorderStyle.None;
            emailField.Font = new Font("Sans serif", 14f);

            // password label
            passwordLabel = new Label();
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.Size = new Size(540, 40);
            passwordLabel.Location = new Point(1175, 484);
            passwordLabel.Text = "Password";
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Font = new Font("Sans serif", 18f);

            // password field
            passwordField = new RoundedTextBox();
            passwordField.Anchor = AnchorStyles.None;
            passwordField.Size = new Size(432, 100);
            passwordField.Location = new Point(1175, 537);
            passwordField.PlaceholderText = "******";
            passwordField.PasswordChar = '*';
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Font = new Font("Sans serif", 14f);

            // Next Button
            nextBtn = new RoundedButton();
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.Size = new Size(230, 70);
            nextBtn.Location = new Point(1397, 878);
            nextBtn.Text = "Next >>";
            nextBtn.BackColor = Color.Black;
            nextBtn.ForeColor = Color.White;
            nextBtn.Font = new Font("Sans serif", 18f);
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.Click += next_btn_click;

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
            skillLabel.Font = new Font("Sans serif", 16f);

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
            cvLabel.Font = new Font("Sans serif", 16f);
            

            // Cv Field
            cvField = new RoundedTextBox();
            cvField.Anchor = AnchorStyles.None;
            cvField.Size = new Size(420, 76);
            cvField.Location = new Point(57, 704);
            cvField.Font = new Font("Sans serif", 14f);
            cvField.BackColor = Color.Black;
            cvField.BorderStyle = BorderStyle.None;
            cvField.Font = new Font("Sans serif", 18f);
            


            // Upload file btn
            uploadBtn = new RoundedButton();
            uploadBtn.Anchor = AnchorStyles.None;
            uploadBtn.Size = new Size(230, 70);
            uploadBtn.Location = new Point(478, 690);
            uploadBtn.Text = "Upload";
            uploadBtn.BackColor = Color.LightGray;
            uploadBtn.ForeColor = Color.Black;
            uploadBtn.FlatStyle = FlatStyle.Flat;
            uploadBtn.Font = new Font("Sans serif", 16f);

            // Certification label
            certificationLabel = new Label();
            certificationLabel.Anchor = AnchorStyles.None;
            certificationLabel.Size = new Size(372, 46);
            certificationLabel.Location = new Point(57, 790);
            certificationLabel.Text = "Certifications";
            certificationLabel.ForeColor = Color.Black;
            certificationLabel.Font = new Font("Sans serif", 16f);


            // certification adding field
            certificationField = new RoundedTextBox();
            certificationField.Anchor = AnchorStyles.None;
            certificationField.Size = new Size(660, 76);
            certificationField.Location = new Point(57, 846);
            certificationField.BackColor = Color.Black;
            certificationField.Font = new Font("Sans serif", 19f, FontStyle.Regular);
            certificationField.BorderStyle = BorderStyle.None;
            certificationField.ForeColor = Color.White;

            // cerification add button
            addCertificateBtn = new RoundedButton();
            addCertificateBtn.Size = new Size(40, 40);
            addCertificateBtn.radius = 43;
            addCertificateBtn.Location = new Point(641, 846);
            addCertificateBtn.Text = "+";
            addCertificateBtn.TextAlign = ContentAlignment.MiddleCenter;
            addCertificateBtn.Font = new Font("Arial", 14f, FontStyle.Bold);
            addCertificateBtn.ForeColor = Color.Black;
            addCertificateBtn.BackColor = Color.LightGray;
            addCertificateBtn.FlatStyle = FlatStyle.Flat;

            // Job category label
            jobCategoryLabel = new Label();
            jobCategoryLabel.Anchor = AnchorStyles.None;
            jobCategoryLabel.Size = new Size(278, 66);
            jobCategoryLabel.Location = new Point(1453, 274);
            jobCategoryLabel.Text = "Job Category";
            jobCategoryLabel.ForeColor = Color.Black;
            jobCategoryLabel.Font = new Font("Sans serif", 16f);


            // Job category combo Box
            jobCategoryCB = new ComboBox();
            jobCategoryCB.Anchor = AnchorStyles.None;
            List<string> items = new List<string> { "Software enginerring", "Computer science", "Graphics designer", "Architecture", "Mechanical Engineering" };
            jobCategoryCB.DataSource = items;
            jobCategoryCB.Size = new Size(432, 76);
            jobCategoryCB.Location = new Point(1390, 340);
            jobCategoryCB.BackColor = Color.Black;
            jobCategoryCB.ForeColor = Color.White;
            jobCategoryCB.Font = new Font("Sans serif", 14f);            
            jobCategoryCB.FlatStyle = FlatStyle.Flat;


            // Experience Label
            experienceLabel = new Label();
            experienceLabel.Anchor = AnchorStyles.None;
            experienceLabel.Size = new Size(278, 46);
            experienceLabel.Location = new Point(1436, 422);
            experienceLabel.Text = "Experience";
            experienceLabel.Font = new Font("Sans serif", 16f);
            experienceLabel.ForeColor = Color.Black;



            // Exeperience field
            experienceField = new RoundedTextBox();
            experienceField.Anchor = AnchorStyles.None;
            experienceField.Size = new Size(145, 76);
            experienceField.Location = new Point(1390, 480);
            experienceField.Font = new Font("Sans serif", 16f);
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
            yearsLabel.Font = new Font("Sans serif", 16f);

            // Work status label
            workStatusLabel = new Label();
            workStatusLabel.Anchor = AnchorStyles.None;
            workStatusLabel.Text = "Work status";
            workStatusLabel.Size = new Size(278, 46);
            workStatusLabel.Location = new Point(1450, 570);
            workStatusLabel.ForeColor = Color.Black;
            workStatusLabel.Font = new Font("Sans serif", 16f);

            // Work status radio button
            statusRadioBtn1 = new RadioButton();
            statusRadioBtn1.Anchor = AnchorStyles.None;
            statusRadioBtn1.Text = "Active";
            statusRadioBtn1.Size = new Size(120, 46);
            statusRadioBtn1.Location = new Point(1410, 635);
            statusRadioBtn1.ForeColor = Color.Black;
            statusRadioBtn1.Font = new Font("Sans serif", 14f);
            statusRadioBtn1.Checked = true;


            statusRadioBtn2 = new RadioButton();
            statusRadioBtn2.Anchor = AnchorStyles.None;
            statusRadioBtn2.Text = "Non-Active";
            statusRadioBtn2.Size = new Size(223, 46);
            statusRadioBtn2.Location = new Point(1540, 636);
            statusRadioBtn2.ForeColor = Color.Black;
            statusRadioBtn2.Font = new Font("Sans serif", 14f);


            // submit button
            submitBtn = new RoundedButton();
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Text = "Submit";
            submitBtn.Size = new Size(245, 76);
            submitBtn.Location = new Point(1529, 820);
            submitBtn.ForeColor = Color.Black;
            submitBtn.BackColor = Color.FromArgb(238, 164, 127);
            submitBtn.FlatStyle = FlatStyle.Flat | FlatStyle.Popup;
            submitBtn.Font = new Font("Sans serif", 16f, FontStyle.Bold);

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
            infoPanel.Controls.Add(nextBtn);
            


            // Add to the second info panel
            infoPanel2.Controls.Add(skillLabel);
            infoPanel2.Controls.Add(skillField);
            infoPanel2.Controls.Add(cvLabel);
            infoPanel2.Controls.Add(cvField);
            infoPanel2.Controls.Add(uploadBtn);
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
        private RoundedButton nextBtn, submitBtn, uploadBtn, addCertificateBtn;
        private RoundedTextBox nameField, emailField, phoneNumField, passwordField, skillField, cvField, certificationField, experienceField;
        private DateTimePicker DobField;
        private ComboBox jobCategoryCB;
        private RadioButton statusRadioBtn1, statusRadioBtn2;





    }



}