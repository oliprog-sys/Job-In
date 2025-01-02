using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JOB_IN
{
    partial class LoginForm
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nleft, int ntop, int nright, int nbottom, int nwidthEllipse, int nheightEllipse);

        private void InitializeComponent()
        {
            Postbtn = new RJControls.Cusbutton();
            historybtn = new RJControls.Cusbutton();
            Jobs = new RJControls.Cusbutton();
            Profilebtn = new RJControls.Cusbutton();
            apppanel = new Panel();
            panel1 = new Panel();
            Jobbackp = new borderedPanels();
            profilep = new Panel();
            postp = new Panel();
            historyp = new Panel();
            panel1.SuspendLayout();
            Jobbackp.SuspendLayout();
            profilep.SuspendLayout();
            postp.SuspendLayout();
            historyp.SuspendLayout();
            SuspendLayout();
            // 
            // Postbtn
            // 
            Postbtn.Anchor = AnchorStyles.Left;
            Postbtn.BackColor = Color.RoyalBlue;
            Postbtn.BackgroundColor = Color.RoyalBlue;
            Postbtn.BorderColor = Color.RoyalBlue;
            Postbtn.BorderColor1 = Color.RoyalBlue;
            Postbtn.BorderRadius = 20;
            Postbtn.BorderRadius1 = 20;
            Postbtn.BorderSize = 0;
            Postbtn.BorderSize1 = 0;
            Postbtn.FlatAppearance.BorderSize = 0;
            Postbtn.FlatStyle = FlatStyle.Flat;
            Postbtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Postbtn.ForeColor = Color.White;
            Postbtn.Location = new Point(3, 12);
            Postbtn.Name = "Postbtn";
            Postbtn.Size = new Size(231, 36);
            Postbtn.TabIndex = 3;
            Postbtn.Text = "Post";
            Postbtn.TextColor = Color.RoyalBlue;
            Postbtn.UseVisualStyleBackColor = false;
            Postbtn.Click += cusbutton2_Click;
            // 
            // historybtn
            // 
            historybtn.Anchor = AnchorStyles.Left;
            historybtn.BackColor = Color.RoyalBlue;
            historybtn.BackgroundColor = Color.RoyalBlue;
            historybtn.BorderColor = Color.RoyalBlue;
            historybtn.BorderColor1 = Color.RoyalBlue;
            historybtn.BorderRadius = 20;
            historybtn.BorderRadius1 = 20;
            historybtn.BorderSize = 0;
            historybtn.BorderSize1 = 0;
            historybtn.FlatAppearance.BorderSize = 0;
            historybtn.FlatStyle = FlatStyle.Flat;
            historybtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historybtn.ForeColor = Color.White;
            historybtn.Location = new Point(3, 12);
            historybtn.Name = "historybtn";
            historybtn.Size = new Size(231, 36);
            historybtn.TabIndex = 2;
            historybtn.Text = "History";
            historybtn.TextColor = Color.RoyalBlue;
            historybtn.UseVisualStyleBackColor = false;
            historybtn.Click += historybtn_Click;
            // 
            // Jobs
            // 
            Jobs.Anchor = AnchorStyles.Left;
            Jobs.BackColor = Color.RoyalBlue;
            Jobs.BackgroundColor = Color.RoyalBlue;
            Jobs.BorderColor = Color.RoyalBlue;
            Jobs.BorderColor1 = Color.RoyalBlue;
            Jobs.BorderRadius = 20;
            Jobs.BorderRadius1 = 20;
            Jobs.BorderSize = 2;
            Jobs.BorderSize1 = 2;
            Jobs.FlatAppearance.BorderSize = 2;
            Jobs.FlatStyle = FlatStyle.Flat;
            Jobs.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Jobs.ForeColor = Color.Snow;
            Jobs.Location = new Point(19, 3);
            Jobs.Name = "Jobs";
            Jobs.Size = new Size(194, 40);
            Jobs.TabIndex = 2;
            Jobs.Text = "Jobs";
            Jobs.TextColor = Color.RoyalBlue;
            Jobs.UseVisualStyleBackColor = false;
            Jobs.Click += Jobs_Click;
            // 
            // Profilebtn
            // 
            Profilebtn.Anchor = AnchorStyles.Left;
            Profilebtn.BackColor = Color.RoyalBlue;
            Profilebtn.BackgroundColor = Color.RoyalBlue;
            Profilebtn.BorderColor = Color.RoyalBlue;
            Profilebtn.BorderColor1 = Color.RoyalBlue;
            Profilebtn.BorderRadius = 20;
            Profilebtn.BorderRadius1 = 20;
            Profilebtn.BorderSize = 2;
            Profilebtn.BorderSize1 = 2;
            Profilebtn.FlatAppearance.BorderSize = 0;
            Profilebtn.FlatStyle = FlatStyle.Flat;
            Profilebtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Profilebtn.ForeColor = Color.White;
            Profilebtn.Location = new Point(3, 12);
            Profilebtn.Name = "Profilebtn";
            Profilebtn.Size = new Size(231, 36);
            Profilebtn.TabIndex = 3;
            Profilebtn.Text = "Profile";
            Profilebtn.TextColor = Color.RoyalBlue;
            Profilebtn.UseVisualStyleBackColor = false;
            Profilebtn.Click += Profilebtn_Click;
            // 
            // apppanel
            // 
            apppanel.Dock = DockStyle.Fill;
            apppanel.Location = new Point(0, 0);
            apppanel.Name = "apppanel";
            apppanel.Size = new Size(1019, 440);
            apppanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(Jobbackp);
            panel1.Controls.Add(profilep);
            panel1.Controls.Add(postp);
            panel1.Controls.Add(historyp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 55);
            panel1.TabIndex = 3;
            // 
            // Jobbackp
            // 
            Jobbackp.BorderRadius = 10;
            Jobbackp.BorderSize = 0;
            Jobbackp.Controls.Add(Jobs);
            Jobbackp.Location = new Point(12, 3);
            Jobbackp.Name = "Jobbackp";
            Jobbackp.Size = new Size(238, 62);
            Jobbackp.TabIndex = 5;
            // 
            // profilep
            // 
            profilep.Controls.Add(Profilebtn);
            profilep.Location = new Point(766, 0);
            profilep.Name = "profilep";
            profilep.Size = new Size(250, 65);
            profilep.TabIndex = 1;
            // 
            // postp
            // 
            postp.Controls.Add(Postbtn);
            postp.Location = new Point(256, 0);
            postp.Name = "postp";
            postp.Size = new Size(250, 65);
            postp.TabIndex = 4;
            // 
            // historyp
            // 
            historyp.Controls.Add(historybtn);
            historyp.Location = new Point(512, 0);
            historyp.Name = "historyp";
            historyp.Size = new Size(250, 65);
            historyp.TabIndex = 1;
            // 
            // EmpLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 440);
            Controls.Add(panel1);
            Controls.Add(apppanel);
            Name = "EmpLogin";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            Jobbackp.ResumeLayout(false);
            profilep.ResumeLayout(false);
            postp.ResumeLayout(false);
            historyp.ResumeLayout(false);
            ResumeLayout(false);
            Application.Exit();
        }

        // #endregion
        private RJControls.Cusbutton Jobs;
        private RJControls.Cusbutton Postbtn;
        private RJControls.Cusbutton historybtn;
        private RJControls.Cusbutton Profilebtn;
        private Panel apppanel;
        private Panel panel1;
        private Panel profilep;
        private Panel historyp;
        private Panel postp;
        private borderedPanels Jobbackp;
    }
}