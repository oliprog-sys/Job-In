using System;
using System.Windows.Forms;
namespace JOB_IN
{
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

       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.titlePanel = new Panel();
            this.titlePanel.Anchor = AnchorStyles.None;
            this.titlePanel.Size = new Size(1920, 60);
            this.titlePanel.Location = new Point(-820, -390);
            titlePanel.BackColor = Color.Blue;

            this.Controls.Add(titlePanel);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Size = new Size(1930, 1080);
            this.Text = "ApplicantSignUp";
        }

        #endregion

        private Panel titlePanel;
        private Label titleLabel, nameLabel, emailLabel, phoneNumLabel, passwordLabel, DOBLabel;
        private Button nextBtn;
        private TextBox nameField, emailField, phoneNumField, DOBField, passwordField;
      
    }
}