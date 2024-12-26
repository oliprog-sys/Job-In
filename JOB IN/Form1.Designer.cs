using System.Runtime.InteropServices;

namespace JOB_IN
{
    partial class Form1
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nleft,int ntop, int nright,int nbottom, int nwidthEllipse,int nheightEllipse);
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            companyname1 = new Label();
            SIgnUpPanel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SIgnUpPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(companyname1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 154);
            panel1.TabIndex = 0;
            // 
            // companyname1
            // 
            companyname1.AccessibleName = "";
            companyname1.Anchor = AnchorStyles.None;
            companyname1.AutoSize = true;
            companyname1.Font = new Font("Britannic Bold", 55.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyname1.Location = new Point(385, 26);
            companyname1.Name = "companyname1";
            companyname1.Size = new Size(310, 101);
            companyname1.TabIndex = 0;
            companyname1.Text = "JOB IN";
            companyname1.TextAlign = ContentAlignment.TopCenter;
            companyname1.Click += companyname1_Click;
            // 
            // SIgnUpPanel1
            // 
            SIgnUpPanel1.Anchor = AnchorStyles.None;
            SIgnUpPanel1.BackColor = Color.Coral;
            SIgnUpPanel1.Controls.Add(tableLayoutPanel1);
            SIgnUpPanel1.Controls.Add(button1);
            SIgnUpPanel1.Controls.Add(textBox2);
            SIgnUpPanel1.Controls.Add(textBox1);
            SIgnUpPanel1.Controls.Add(label2);
            SIgnUpPanel1.Controls.Add(label1);
            SIgnUpPanel1.Location = new Point(236, 366);
            SIgnUpPanel1.Name = "SIgnUpPanel1";
            SIgnUpPanel1.Size = new Size(591, 405);
            SIgnUpPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.Snow;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.Location = new Point(144, 322);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(293, 63);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(149, 3);
            button2.Name = "button2";
            button2.Size = new Size(141, 57);
            button2.TabIndex = 5;
            button2.Text = "Employer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Snow;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Britannic Bold", 12F);
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(140, 57);
            button3.TabIndex = 6;
            button3.Text = "Applicant";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Coral;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(222, 257);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Candara Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(40, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(480, 32);
            textBox2.TabIndex = 3;
            textBox2.Text = "********";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Candara Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(40, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "Someone12@gmail.com";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 117);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 33);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 313);
            label3.Name = "label3";
            label3.Size = new Size(169, 37);
            label3.TabIndex = 7;
            label3.Text = "Signing in";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(458, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 103);
            panel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1081, 860);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(SIgnUpPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SIgnUpPanel1.ResumeLayout(false);
            SIgnUpPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label companyname1;
        private Panel SIgnUpPanel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
    }
}
