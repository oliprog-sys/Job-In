using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            int radius = 20; // Adjust the radius for rounded corners
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
            Invalidate(); // Forces the control to redraw
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion(); // Update region on resize
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
            protected override void OnCreateControl()
            {
                base.OnCreateControl();
                UpdateRegion();
            }

            private void UpdateRegion()
            {
                GraphicsPath path = new GraphicsPath();
                int radius = 50; // Adjust the radius for rounded corners
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                this.Region = new Region(path);
                Invalidate(); // Forces the control to redraw
            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                UpdateRegion(); // Update region on resize
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
            titlePanel.Size = new Size(1920, 130);
            titlePanel.BackColor = Color.White;

            // title label
            titleLabel = new Label();
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.Size = new Size(1920, 100);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Text = "Applicant SignUp";
            titleLabel.Font = new Font("sans serif", 36f);

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

            // Next Button
            nextBtn = new RoundedButton();
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.Size = new Size(230, 70);
            nextBtn.Location = new Point(1397, 878);
            nextBtn.Text = "Next >>";
            nextBtn.BackColor = Color.Black;
            nextBtn.ForeColor = Color.White;
            nextBtn.Font = new Font("Sans serif", 18f);
            //nextBtn.BorderStyle = BorderStyle.None;
            nextBtn.Click += next_btn_click;

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

            // Add child panels to the parent panel
            mainPanel1.Controls.Add(titlePanel);
            mainPanel1.Controls.Add(infoPanel);

            this.Controls.Add(mainPanel1);
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1920, 1080);
            this.Text = "ApplicantSignUp";
        }

        #endregion

        private Panel mainPanel1, mainPanel2, titlePanel, infoPanel;        
        private Label titleLabel, nameLabel, emailLabel, phoneNumLabel, passwordLabel, DOBLabel;
        private RoundedButton nextBtn;
        private RoundedTextBox nameField, emailField, phoneNumField, passwordField;
        private DateTimePicker DobField;


        


    }

   

}