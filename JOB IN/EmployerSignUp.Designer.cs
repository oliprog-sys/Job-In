using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.DirectoryServices.ActiveDirectory;
using static JOB_IN.ApplicantSignUp;
using JOB_IN.RJControls;
namespace JOB_IN
{

    public class RoundedTextBox2 : TextBox
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


    partial class EmployerSignUp
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

        public class RoundedButton2 : Button
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

            /* First page */
            // main panel
            this.SuspendLayout();
            mainPanel = new Panel();
            mainPanel.Size = new Size(1920, 1080);
            mainPanel.BackColor = Color.Black;

            // sign up as panel
            signUpAsPanel = new Panel();
            signUpAsPanel.Anchor = AnchorStyles.None;
            signUpAsPanel.Size = new Size(1920, 222);
            signUpAsPanel.BackColor = Color.White;
            

            // sign up as title Label
            signUpAsLabel = new Label();
            signUpAsLabel.Anchor = AnchorStyles.None;
            signUpAsLabel.Size = new Size(1920, 210);
            signUpAsLabel.TextAlign = ContentAlignment.MiddleCenter;            
            signUpAsLabel.Text = "Sign-Up  as";
            signUpAsLabel.Font = Custom.font(42);

            // back button
            backBtn = new RoundedButton2();
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
            backBtn.Click += OnbackBtnForOrganization_clicked;
            backBtn.Click += OnbackBtnForPersonal_clicked;

            // choose the sign up way panel
            choosePanel = new Panel();
            choosePanel.Anchor = AnchorStyles.None;
            choosePanel.Size = new Size(1920, 980);
            choosePanel.BackColor = Color.White;

            // sign up as organization button
            organizationBtn = new Button();
            organizationBtn.Size = new Size(500, 500);
            organizationBtn.Location = new Point(300, 300);
            organizationBtn.Text = "Organization \n  For Organization use";
            organizationBtn.ForeColor = Color.White;
            organizationBtn.BackColor = Color.FromArgb(0, 83, 156);
            organizationBtn.FlatStyle = FlatStyle.Flat;
            organizationBtn.FlatAppearance.BorderColor = Color.White;
            organizationBtn.Font = Custom.font(16);
            organizationBtn.Click += OnOrganizationBtn_clicked;

            // sign up as personal button
            personalBtn = new Button();
            personalBtn.Size = new Size(500, 500);
            personalBtn.Location = new Point(1150, 300);
            personalBtn.Text = "Person \n For personal Use";
            personalBtn.Font = Custom.font(16);
            personalBtn.ForeColor = Color.White;
            personalBtn.BackColor = Color.FromArgb(0, 83, 156);
            personalBtn.FlatStyle = FlatStyle.Flat;
            personalBtn.FlatAppearance.BorderColor = Color.White;
            personalBtn.Click += OnPersonalBtn_clicked;

            // Add the label to the title panel
            signUpAsPanel.Controls.Add(backBtn);
            signUpAsPanel.Controls.Add(signUpAsLabel);
            

            // Add to the choose panel
            choosePanel.Controls.Add(organizationBtn);
            choosePanel.Controls.Add(personalBtn);


            /* Second Page */
            organizationPanel = new Panel();
            organizationPanel.Anchor = AnchorStyles.None;
            organizationPanel.Size = new Size(1920, 980);
            organizationPanel.BackColor = Color.Blue;

            

            // Name label
            orgnameLabel = new Label();
            orgnameLabel.Anchor = AnchorStyles.None;
            orgnameLabel.Size = new Size(540, 40);
            orgnameLabel.Location = new Point(150, 318);
            orgnameLabel.Text = "Name";
            orgnameLabel.ForeColor = Color.White;
            orgnameLabel.Font = Custom.font(18); ;

            // Name Field 
            orgnameField = new RoundedTextBox2();
            orgnameField.Anchor = AnchorStyles.None;
            //orgnameField.Size = new Size(432, 100);
            orgnameField.MinimumSize = new Size(432, 40);
            orgnameField.Location = new Point(150, 374);
            orgnameField.PlaceholderText = "Enter your name";
            orgnameField.BorderStyle = BorderStyle.None;
            orgnameField.Font = Custom.font(14);


            // Phone number label
            orgphoneNumLabel = new Label();
            orgphoneNumLabel.Anchor = AnchorStyles.None;
            orgphoneNumLabel.Size = new Size(540, 40);
            orgphoneNumLabel.Location = new Point(150, 484);
            orgphoneNumLabel.Text = "Phone Number";
            orgphoneNumLabel.ForeColor = Color.White;
            orgphoneNumLabel.Font = Custom.font(18);

            // Phone number field 
            orgphoneNumField = new RoundedTextBox2();
            orgphoneNumField.Anchor = AnchorStyles.None;
            //orgphoneNumField.Size = new Size(432, 100);
            orgphoneNumField.MinimumSize = new Size(432, 40);
            orgphoneNumField.Location = new Point(150, 537);
            orgphoneNumField.PlaceholderText = "09--------";
            orgphoneNumField.BorderStyle = BorderStyle.None;
            orgphoneNumField.Font = Custom.font(14);

            // Date of birth label
            orgaddressLabel = new Label();
            orgaddressLabel.Anchor = AnchorStyles.None;
            orgaddressLabel.Size = new Size(540, 40);
            orgaddressLabel.Location = new Point(150, 637);
            orgaddressLabel.Text = "Address";
            orgaddressLabel.ForeColor = Color.White;
            orgaddressLabel.Font = Custom.font(18);

            // Date of birth field
            orgaddressField = new RoundedTextBox2();
            orgaddressField.Anchor = AnchorStyles.None;
            //orgaddressField.Size = new Size(230, 50);
            orgaddressField.MinimumSize = new Size(432, 40);
            orgaddressField.Location = new Point(150, 693);
            orgaddressField.PlaceholderText = "Addis Ababa";
            orgaddressField.BorderStyle = BorderStyle.None;
            orgaddressField.Font = Custom.font(14);

            // Email label 
            orgemailLabel = new Label();
            orgemailLabel.Anchor = AnchorStyles.None;
            orgemailLabel.Size = new Size(540, 40);
            orgemailLabel.Location = new Point(1175, 318);
            orgemailLabel.Text = "Email";
            orgemailLabel.ForeColor = Color.White;
            orgemailLabel.Font = Custom.font(18);


            // Email Field 
            orgemailField = new RoundedTextBox2();
            orgemailField.Anchor = AnchorStyles.None;
            //orgemailField.Size = new Size(432, 100);
            orgemailField.MinimumSize = new Size(432, 40);
            orgemailField.Location = new Point(1175, 374);
            orgemailField.PlaceholderText = "example@gmail.com";
            orgemailField.BorderStyle = BorderStyle.None;
            orgemailField.Font = Custom.font(14);

            // password label
            orgpasswordLabel = new Label();
            orgpasswordLabel.Anchor = AnchorStyles.None;
            orgpasswordLabel.Size = new Size(540, 40);
            orgpasswordLabel.Location = new Point(1175, 484);
            orgpasswordLabel.Text = "Password";
            orgpasswordLabel.ForeColor = Color.White;
            orgpasswordLabel.Font = Custom.font(18);

            // password field
            orgpasswordField = new RoundedTextBox2();
            orgpasswordField.Anchor = AnchorStyles.None;
            //orgpasswordField.Size = new Size(432, 100);
            orgpasswordField.MinimumSize = new Size(432, 40);
            orgpasswordField.Location = new Point(1175, 537);
            orgpasswordField.PlaceholderText = "******";
            orgpasswordField.PasswordChar = '*';
            orgpasswordField.BorderStyle = BorderStyle.None;
            orgpasswordField.Font = Custom.font(14);


            // show and hide password button
            showPasswordBtn1 = new RoundedButton2();
            showPasswordBtn1.Anchor = AnchorStyles.None;
            showPasswordBtn1.radius = 10;
            showPasswordBtn1.Size = new Size(100, 45);
            showPasswordBtn1.Location = new Point(1610, 535);
            showPasswordBtn1.Text = "Show";
            showPasswordBtn1.Font = Custom.font(14);
            showPasswordBtn1.BackColor = Color.White;
            showPasswordBtn1.FlatStyle = FlatStyle.Flat;
            showPasswordBtn1.FlatAppearance.BorderColor = Color.White;
            showPasswordBtn1.Cursor = Cursors.Hand;
            showPasswordBtn1.Click += showPasswordBtn_on_org_clicked;

            // Next Button
            orgnextBtn = new RoundedButton2();
            orgnextBtn.Anchor = AnchorStyles.None;
            orgnextBtn.radius = 20;
            orgnextBtn.Size = new Size(200, 70);
            orgnextBtn.Location = new Point(1497, 878);
            orgnextBtn.Text = "Next >>";
            orgnextBtn.BackColor = Color.Black;
            orgnextBtn.ForeColor = Color.White;
            orgnextBtn.Font = Custom.font(18);
            orgnextBtn.FlatStyle = FlatStyle.Flat;
            orgnextBtn.FlatAppearance.BorderColor = Color.Blue;
            orgnextBtn.Click += next_btn_click;


            // Adding the controls to the organization panel
            organizationPanel.Controls.Add(orgnameLabel);
            organizationPanel.Controls.Add(orgnameField);
            organizationPanel.Controls.Add(orgphoneNumLabel);
            organizationPanel.Controls.Add(orgphoneNumField);
            organizationPanel.Controls.Add(orgaddressLabel);
            organizationPanel.Controls.Add(orgaddressField);
            organizationPanel.Controls.Add(orgemailLabel);
            organizationPanel.Controls.Add(orgemailField);
            organizationPanel.Controls.Add(orgpasswordLabel);
            organizationPanel.Controls.Add(orgpasswordField);
            organizationPanel.Controls.Add(showPasswordBtn1);
            organizationPanel.Controls.Add(orgnextBtn);

            /* Third page */
            organizationalMorePanel = new Panel();
            organizationalMorePanel.Anchor = AnchorStyles.None;
            organizationalMorePanel.Size = new Size(1920, 980);
            organizationalMorePanel.BackColor = Color.White;

            // about us label
            aboutUsLabel = new Label();
            aboutUsLabel.Anchor = AnchorStyles.None;
            aboutUsLabel.Size = new Size(644, 46);
            aboutUsLabel.Location = new Point(47, 269);
            aboutUsLabel.Text = "About Us";
            aboutUsLabel.ForeColor = Color.Black;
            aboutUsLabel.Font = Custom.font(16);

            // about us Field
            aboutUsField = new RoundedTextBox2();
            aboutUsField.Anchor = AnchorStyles.None;
            aboutUsField.Size = new Size(1310, 285);
            aboutUsField.Location = new Point(47, 335);
            aboutUsField.PlaceholderText = "Enter about your company";
            aboutUsField.Font = Custom.font(16);
            aboutUsField.ForeColor = Color.Black;
            aboutUsField.Multiline = true;
            aboutUsField.ScrollBars = ScrollBars.Vertical;
            aboutUsField.BackColor = Color.LightGray;            
            aboutUsField.BorderStyle = BorderStyle.None;

            // media link label
            mediaLinkLabel = new Label();
            mediaLinkLabel.Anchor = AnchorStyles.None;
            mediaLinkLabel.Size = new Size(372, 46);
            mediaLinkLabel.Location = new Point(47, 648);
            mediaLinkLabel.Text = "Media Link";
            mediaLinkLabel.ForeColor = Color.Black;
            mediaLinkLabel.Font = Custom.font(16);

            // media link field
            mediaLinkField = new RoundedTextBox2();
            mediaLinkField.Anchor = AnchorStyles.None;
            mediaLinkField.MinimumSize = new Size(600, 45);
            mediaLinkField.Location = new Point(57, 714);
            mediaLinkField.BackColor = Color.Black;
            mediaLinkField.PlaceholderText = "https://linkedin/";
            mediaLinkField.Font = Custom.font(16);
            mediaLinkField.BorderStyle = BorderStyle.None;
            mediaLinkField.ForeColor = Color.LightGray;
            

            // organization submit button
            orgSubmitBtn = new RoundedButton2();
            orgSubmitBtn.Anchor = AnchorStyles.None;
            orgSubmitBtn.radius = 20;
            orgSubmitBtn.Text = "Submit";
            orgSubmitBtn.Size = new Size(200, 70);
            orgSubmitBtn.Location = new Point(1379, 820);
            orgSubmitBtn.ForeColor = Color.White;
            orgSubmitBtn.BackColor = Color.FromArgb(0, 83, 156);
            orgSubmitBtn.FlatStyle = FlatStyle.Flat;
            orgSubmitBtn.FlatAppearance.BorderColor = Color.White;
            orgSubmitBtn.Font = Custom.font(16);
            orgSubmitBtn.Click += OnorgSubmitBtn_clicked;

            // exit button one
            exitBtn1 = new RoundedButton2();
            exitBtn1.Anchor = AnchorStyles.None;
            exitBtn1.radius = 20;
            exitBtn1.Size = new Size(200, 70);
            exitBtn1.Location = new Point(1620, 820);
            exitBtn1.Text = "Exit";
            exitBtn1.Font = Custom.font(18);
            exitBtn1.Cursor = Cursors.Hand;
            exitBtn1.BackColor = Color.Red;
            exitBtn1.ForeColor = Color.White;
            exitBtn1.FlatStyle = FlatStyle.Flat;
            exitBtn1.FlatAppearance.BorderColor = Color.FromArgb(238, 164, 127);
            exitBtn1.Click += exitBtn1_clicked;


            // first under line
            orgUnderline1 = new Panel();
            orgUnderline1.Anchor = AnchorStyles.None;
            orgUnderline1.Size = new Size(1414, 5);
            orgUnderline1.Location = new Point(253, 935);
            orgUnderline1.BackColor = Color.FromArgb(0, 83, 156);
            orgUnderline1.BorderStyle = BorderStyle.None;

            // second under line
            orgUnderline2 = new Panel();
            orgUnderline2.Anchor = AnchorStyles.None;
            orgUnderline2.Size = new Size(769, 5);
            orgUnderline2.Location = new Point(600, 960);
            orgUnderline2.BackColor = Color.FromArgb(0, 83, 156);
            orgUnderline2.BorderStyle = BorderStyle.None;


            // add to the organization more panel
            organizationalMorePanel.Controls.Add(aboutUsLabel);
            organizationalMorePanel.Controls.Add(aboutUsField);
            organizationalMorePanel.Controls.Add(mediaLinkLabel);
            organizationalMorePanel.Controls.Add(mediaLinkField);
            organizationalMorePanel.Controls.Add(exitBtn1);
            organizationalMorePanel.Controls.Add(orgSubmitBtn);
            organizationalMorePanel.Controls.Add(orgUnderline1);
            organizationalMorePanel.Controls.Add(orgUnderline2);

            /* Personal Panel */
            personalPanel = new Panel();
            personalPanel.Anchor = AnchorStyles.None;
            personalPanel.Size = new Size(1920, 980);
            personalPanel.BackColor = Color.Blue;



            // Name label
            pernameLabel = new Label();
            pernameLabel.Anchor = AnchorStyles.None;
            pernameLabel.Size = new Size(540, 40);
            pernameLabel.Location = new Point(150, 318);
            pernameLabel.Text = "Name";
            pernameLabel.ForeColor = Color.White;
            pernameLabel.Font = Custom.font(18);

            // Name Field 
            pernameField = new RoundedTextBox2();
            pernameField.Anchor = AnchorStyles.None;
            pernameField.MinimumSize = new Size(432, 40);
            pernameField.Location = new Point(150, 374);
            pernameField.PlaceholderText = "Enter your name";
            pernameField.BorderStyle = BorderStyle.None;
            pernameField.Font = Custom.font(14);


            // Phone number label
            perphoneNumLabel = new Label();
            perphoneNumLabel.Anchor = AnchorStyles.None;
            perphoneNumLabel.Size = new Size(540, 40);
            perphoneNumLabel.Location = new Point(150, 484);
            perphoneNumLabel.Text = "Phone Number";
            perphoneNumLabel.ForeColor = Color.White;
            perphoneNumLabel.Font = Custom.font(18);

            // Phone number field 
            perphoneNumField = new RoundedTextBox2();
            perphoneNumField.Anchor = AnchorStyles.None;
            perphoneNumField.MinimumSize = new Size(432, 40);
            perphoneNumField.Location = new Point(150, 537);
            perphoneNumField.PlaceholderText = "09--------";
            perphoneNumField.BorderStyle = BorderStyle.None;
            perphoneNumField.Font = Custom.font(14);

            // Date of birth label
            peraddressLabel = new Label();
            peraddressLabel.Anchor = AnchorStyles.None;
            peraddressLabel.Size = new Size(540, 40);
            peraddressLabel.Location = new Point(150, 637);
            peraddressLabel.Text = "Address";
            peraddressLabel.ForeColor = Color.White;
            peraddressLabel.Font = Custom.font(18);

            // Date of birth field
            peraddressField = new RoundedTextBox2();
            peraddressField.Anchor = AnchorStyles.None;
            peraddressField.MinimumSize = new Size(432, 40);
            peraddressField.Location = new Point(150, 693);
            peraddressField.PlaceholderText = "Addis Ababa";
            peraddressField.BorderStyle = BorderStyle.None;
            peraddressField.Font = Custom.font(14);

            // Email label 
            peremailLabel = new Label();
            peremailLabel.Anchor = AnchorStyles.None;
            peremailLabel.Size = new Size(540, 40);
            peremailLabel.Location = new Point(1175, 318);
            peremailLabel.Text = "Email";
            peremailLabel.ForeColor = Color.White;
            peremailLabel.Font = Custom.font(18);


            // Email Field 
            peremailField = new RoundedTextBox2();
            peremailField.Anchor = AnchorStyles.None;
            peremailField.MinimumSize = new Size(432, 40);
            peremailField.Location = new Point(1175, 374);
            peremailField.PlaceholderText = "example@gmail.com";
            peremailField.BorderStyle = BorderStyle.None;
            peremailField.Font = Custom.font(14);

            // password label
            perpasswordLabel = new Label();
            perpasswordLabel.Anchor = AnchorStyles.None;
            perpasswordLabel.Size = new Size(540, 40);
            perpasswordLabel.Location = new Point(1175, 484);
            perpasswordLabel.Text = "Password";
            perpasswordLabel.ForeColor = Color.White;
            perpasswordLabel.Font = Custom.font(18);

            // password field
            perpasswordField = new RoundedTextBox2();
            perpasswordField.Anchor = AnchorStyles.None;
            perpasswordField.MinimumSize = new Size(432, 40);
            perpasswordField.Location = new Point(1175, 537);
            perpasswordField.PlaceholderText = "******";
            perpasswordField.PasswordChar = '*';
            perpasswordField.BorderStyle = BorderStyle.None;
            perpasswordField.Font = Custom.font(14);

            // show and hide password button
            showPasswordBtn2 = new RoundedButton2();
            showPasswordBtn2.Anchor = AnchorStyles.None;
            showPasswordBtn2.radius = 10;
            showPasswordBtn2.Size = new Size(100, 45);
            showPasswordBtn2.Location = new Point(1610, 535);
            showPasswordBtn2.Text = "Show";
            showPasswordBtn2.Font = Custom.font(14);
            showPasswordBtn2.BackColor = Color.White;
            showPasswordBtn2.FlatStyle = FlatStyle.Flat;
            showPasswordBtn2.FlatAppearance.BorderColor = Color.White;
            showPasswordBtn2.Cursor = Cursors.Hand;
            showPasswordBtn2.Click += showPasswordBtn_on_per_clicked;

            // Next Button
            pernextBtn = new RoundedButton2();
            pernextBtn.Anchor = AnchorStyles.None;
            pernextBtn.radius = 20;
            pernextBtn.Size = new Size(200, 70);
            pernextBtn.Location = new Point(1497, 878);
            pernextBtn.Text = "Next >>";
            pernextBtn.BackColor = Color.Black;
            pernextBtn.ForeColor = Color.White;
            pernextBtn.Font = Custom.font(18);
            pernextBtn.FlatStyle = FlatStyle.Flat;
            pernextBtn.FlatAppearance.BorderColor = Color.Black;
            pernextBtn.Click += personal_next_btn_click;




            // Adding the controls to the personal panel
            personalPanel.Controls.Add(pernameLabel);
            personalPanel.Controls.Add(pernameField);
            personalPanel.Controls.Add(perphoneNumLabel);
            personalPanel.Controls.Add(perphoneNumField);
            personalPanel.Controls.Add(peraddressLabel);
            personalPanel.Controls.Add(peraddressField);
            personalPanel.Controls.Add(peremailLabel);
            personalPanel.Controls.Add(peremailField);
            personalPanel.Controls.Add(perpasswordLabel);
            personalPanel.Controls.Add(perpasswordField);
            personalPanel.Controls.Add(showPasswordBtn2);
            personalPanel.Controls.Add(pernextBtn);


            /* personal more panel */
            personalMorePanel = new Panel();
            personalMorePanel.Anchor = AnchorStyles.None;
            personalMorePanel.Size = new Size(1920, 980);
            personalMorePanel.BackColor = Color.White;

            // about us label
            peraboutUsLabel = new Label();
            peraboutUsLabel.Anchor = AnchorStyles.None;
            peraboutUsLabel.Size = new Size(644, 46);
            peraboutUsLabel.Location = new Point(47, 269);
            peraboutUsLabel.Text = "About Us";
            peraboutUsLabel.ForeColor = Color.Black;
            peraboutUsLabel.Font = Custom.font(16);

            // about us Field
            peraboutUsField = new RoundedTextBox2();
            peraboutUsField.Anchor = AnchorStyles.None;
            peraboutUsField.Size = new Size(1310, 285);
            peraboutUsField.Location = new Point(47, 335);
            peraboutUsField.PlaceholderText = "Enter about your company";
            peraboutUsField.Font = Custom.font(16);
            peraboutUsField.ForeColor = Color.Black;
            peraboutUsField.Multiline = true;
            peraboutUsField.ScrollBars = ScrollBars.Vertical;
            peraboutUsField.BackColor = Color.LightGray;
            peraboutUsField.BorderStyle = BorderStyle.None;

            // media link label
            permediaLinkLabel = new Label();
            permediaLinkLabel.Anchor = AnchorStyles.None;
            permediaLinkLabel.Size = new Size(372, 46);
            permediaLinkLabel.Location = new Point(47, 648);
            permediaLinkLabel.Text = "Media Link";
            permediaLinkLabel.ForeColor = Color.Black;
            permediaLinkLabel.Font = Custom.font(16);

            // media link field
            permediaLinkField = new RoundedTextBox2();
            permediaLinkField.Anchor = AnchorStyles.None;
            permediaLinkField.MinimumSize = new Size(600, 45);
            permediaLinkField.PlaceholderText = "https://linkedin/";
            permediaLinkField.Location = new Point(57, 714);
            permediaLinkField.BackColor = Color.Black;
            permediaLinkField.Font = Custom.font(16);
            permediaLinkField.BorderStyle = BorderStyle.None;
            permediaLinkField.ForeColor = Color.LightGray;

            

            // organization submit button
            perSubmitBtn = new RoundedButton2();
            perSubmitBtn.Anchor = AnchorStyles.None;
            perSubmitBtn.radius = 20;
            perSubmitBtn.Text = "Submit";
            perSubmitBtn.Size = new Size(200, 70);
            perSubmitBtn.Location = new Point(1382, 820);
            perSubmitBtn.ForeColor = Color.White;
            perSubmitBtn.BackColor = Color.FromArgb(0, 83, 156);
            perSubmitBtn.FlatStyle = FlatStyle.Flat;
            perSubmitBtn.FlatAppearance.BorderColor = Color.White; 
            perSubmitBtn.Font = Custom.font(16);
            perSubmitBtn.Click += OnperSubmitBtn_clicked;

            
            // exit button two
            exitBtn2 = new RoundedButton2();
            exitBtn2.Anchor = AnchorStyles.None;
            exitBtn2.radius = 20;
            exitBtn2.Size = new Size(200, 70);
            exitBtn2.Location = new Point(1620, 820);
            exitBtn2.Text = "Exit";
            exitBtn2.Font = Custom.font(18);
            exitBtn2.Cursor = Cursors.Hand;
            exitBtn2.BackColor = Color.Red;
            exitBtn2.ForeColor = Color.White;
            exitBtn2.FlatStyle = FlatStyle.Flat;
            exitBtn2.FlatAppearance.BorderColor = Color.White;
            exitBtn2.Click += exitBtn1_clicked;

            // first under line
            perUnderline1 = new Panel();
            perUnderline1.Anchor = AnchorStyles.None;
            perUnderline1.Size = new Size(1414, 5);
            perUnderline1.Location = new Point(253, 935);
            perUnderline1.BackColor = Color.FromArgb(0, 83, 156);
            perUnderline1.BorderStyle = BorderStyle.None;

            // second under line
            perUnderline2 = new Panel();
            perUnderline2.Anchor = AnchorStyles.None;
            perUnderline2.Size = new Size(769, 5);
            perUnderline2.Location = new Point(600, 960);
            perUnderline2.BackColor = Color.FromArgb(0, 83, 156);
            perUnderline2.BorderStyle = BorderStyle.None;


            // add to the organization more panel
            personalMorePanel.Controls.Add(peraboutUsLabel);
            personalMorePanel.Controls.Add(peraboutUsField);
            personalMorePanel.Controls.Add(permediaLinkLabel);
            personalMorePanel.Controls.Add(permediaLinkField);
            personalMorePanel.Controls.Add(exitBtn2);
            personalMorePanel.Controls.Add(perSubmitBtn);
            personalMorePanel.Controls.Add(perUnderline1);
            personalMorePanel.Controls.Add(perUnderline2);


            // Add sign up as panel to the main panel
            mainPanel.Controls.Add(signUpAsPanel);
            mainPanel.Controls.Add(choosePanel);

            this.Controls.Add(mainPanel);
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1920, 1080);
            this.Text = "EmployerSignUp";
        }

        private Panel mainPanel, signUpAsPanel, choosePanel, organizationPanel, personalPanel, organizationalMorePanel, personalMorePanel, orgUnderline1, orgUnderline2,
            perUnderline1, perUnderline2;
        private Label signUpAsLabel, orgnameLabel, orgphoneNumLabel, orgaddressLabel, orgemailLabel, orgpasswordLabel, aboutUsLabel, mediaLinkLabel, pernameLabel,
                        perphoneNumLabel, peraddressLabel, peremailLabel, perpasswordLabel, peraboutUsLabel, permediaLinkLabel;
        private RoundedTextBox2 orgnameField, orgphoneNumField, orgaddressField, orgemailField, orgpasswordField, aboutUsField, mediaLinkField,
                            pernameField, perphoneNumField, peraddressField, peremailField, perpasswordField, peraboutUsField, permediaLinkField;
        private RoundedButton2 orgnextBtn, addMediaLinkBtn, orgSubmitBtn, pernextBtn, peraddMediaLinkBtn, perSubmitBtn, backBtn, showPasswordBtn1, showPasswordBtn2, exitBtn1, exitBtn2;
        private Button organizationBtn, personalBtn;

        #endregion
    }
} 