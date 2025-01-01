namespace JOB_IN
{
    partial class AppJobPanel
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
            jpan = new Panel();
            panel2 = new Panel();
            Myjobsbtn = new RJControls.Cusbutton();
            otherbtn = new RJControls.Cusbutton();
            panel1 = new Panel();
            showmorebtn = new RJControls.Cusbutton();
            textBox1 = new TextBox();
            jpan.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // jpan
            // 
            jpan.BackColor = Color.White;
            jpan.Controls.Add(panel2);
            jpan.Controls.Add(panel1);
            jpan.Dock = DockStyle.Fill;
            jpan.Location = new Point(0, 0);
            jpan.Name = "jpan";
            jpan.Size = new Size(1000, 650);
            jpan.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(Myjobsbtn);
            panel2.Controls.Add(otherbtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 125);
            panel2.TabIndex = 2;
            // 
            // Myjobsbtn
            // 
            Myjobsbtn.Anchor = AnchorStyles.Bottom;
            Myjobsbtn.BackColor = Color.Black;
            Myjobsbtn.BackgroundColor = Color.Black;
            Myjobsbtn.BorderColor = Color.Black;
            Myjobsbtn.BorderColor1 = Color.Black;
            Myjobsbtn.BorderRadius = 20;
            Myjobsbtn.BorderRadius1 = 20;
            Myjobsbtn.BorderSize = 2;
            Myjobsbtn.BorderSize1 = 2;
            Myjobsbtn.FlatAppearance.BorderSize = 0;
            Myjobsbtn.FlatStyle = FlatStyle.Flat;
            Myjobsbtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Myjobsbtn.ForeColor = Color.White;
            Myjobsbtn.Location = new Point(296, 72);
            Myjobsbtn.Name = "Myjobsbtn";
            Myjobsbtn.Size = new Size(188, 50);
            Myjobsbtn.TabIndex = 0;
            Myjobsbtn.Text = "My Jobs";
            Myjobsbtn.TextColor = Color.Black;
            Myjobsbtn.UseVisualStyleBackColor = false;
            // 
            // otherbtn
            // 
            otherbtn.Anchor = AnchorStyles.Bottom;
            otherbtn.BackColor = Color.White;
            otherbtn.BackgroundColor = Color.White;
            otherbtn.BorderColor = Color.Black;
            otherbtn.BorderColor1 = Color.Black;
            otherbtn.BorderRadius = 20;
            otherbtn.BorderRadius1 = 20;
            otherbtn.BorderSize = 2;
            otherbtn.BorderSize1 = 2;
            otherbtn.FlatAppearance.BorderSize = 0;
            otherbtn.FlatStyle = FlatStyle.Flat;
            otherbtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otherbtn.ForeColor = Color.Black;
            otherbtn.Location = new Point(525, 72);
            otherbtn.Name = "otherbtn";
            otherbtn.Size = new Size(188, 50);
            otherbtn.TabIndex = 1;
            otherbtn.Text = "Others";
            otherbtn.TextColor = Color.White;
            otherbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(showmorebtn);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 282);
            panel1.TabIndex = 0;
            // 
            // showmorebtn
            // 
            showmorebtn.Anchor = AnchorStyles.None;
            showmorebtn.BackColor = Color.RoyalBlue;
            showmorebtn.BackgroundColor = Color.RoyalBlue;
            showmorebtn.BorderColor = Color.PaleVioletRed;
            showmorebtn.BorderColor1 = Color.PaleVioletRed;
            showmorebtn.BorderRadius = 40;
            showmorebtn.BorderRadius1 = 40;
            showmorebtn.BorderSize = 0;
            showmorebtn.BorderSize1 = 0;
            showmorebtn.FlatAppearance.BorderSize = 0;
            showmorebtn.FlatStyle = FlatStyle.Flat;
            showmorebtn.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showmorebtn.ForeColor = Color.White;
            showmorebtn.Location = new Point(768, 216);
            showmorebtn.Name = "showmorebtn";
            showmorebtn.Size = new Size(188, 50);
            showmorebtn.TabIndex = 1;
            showmorebtn.Text = "Show more";
            showmorebtn.TextColor = Color.RoyalBlue;
            showmorebtn.UseVisualStyleBackColor = false;
            showmorebtn.Click += showmorebtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 253);
            textBox1.TabIndex = 0;
            // 
            // AppJobPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(jpan);
            Name = "AppJobPanel";
            Text = "AppPanel";
            jpan.ResumeLayout(false);
            jpan.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel jpan;
        private Panel panel1;
        private RJControls.Cusbutton otherbtn;
        private RJControls.Cusbutton Myjobsbtn;
        private RJControls.Cusbutton showmorebtn;
        private TextBox textBox1;
        private Panel panel2;
    }
}