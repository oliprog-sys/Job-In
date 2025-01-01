using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Configuration;
using JOB_IN.RJControls;
using System.ComponentModel;

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


            apage = true;
            t = new topButtons(0);

            panel1 = new Panel();
            companyname1 = new Label();
            SIgnUpPanel1 = new borderedPanels();
            tableLayoutPanel1 = new TableLayoutPanel();
            Employerbtn = new Button();
            Applicantbtn = new Button();
            Loginbtn = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            picture = new PictureBox();
            blackColorLine = new PictureBox();
            SignUpbtn = new Button();
            MainPanel = new Panel();
            panel1.SuspendLayout();
            SIgnUpPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blackColorLine).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(companyname1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 143);
            panel1.TabIndex = 0;
            // 
            // companyname1
            // 
            companyname1.AccessibleName = "";
            companyname1.Anchor = AnchorStyles.None;
            companyname1.AutoSize = true;
            companyname1.Font = new Font("Britannic Bold", 55.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            companyname1.Location = new Point(387, 20);
            companyname1.Name = "companyname1";
            companyname1.Size = new Size(310, 101);
            companyname1.TabIndex = 0;
            companyname1.Text = "JOB IN";
            companyname1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SIgnUpPanel1
            // 
            SIgnUpPanel1.Anchor = AnchorStyles.None;
            SIgnUpPanel1.BorderRadius = 80;
            SIgnUpPanel1.BackColor = Color.Coral;
            SIgnUpPanel1.Controls.Add(tableLayoutPanel1);
            SIgnUpPanel1.Controls.Add(Loginbtn);
            SIgnUpPanel1.Controls.Add(textBox2);
            SIgnUpPanel1.Controls.Add(textBox1);
            SIgnUpPanel1.Controls.Add(label2);
            SIgnUpPanel1.Controls.Add(label1);
            SIgnUpPanel1.Location = new Point(216, 320);
            SIgnUpPanel1.Name = "SIgnUpPanel1";
            SIgnUpPanel1.Size = new Size(548, 469);
            SIgnUpPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackColor = Color.Snow;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Employerbtn, 0, 0);
            tableLayoutPanel1.Controls.Add(Applicantbtn, 0, 0);
            tableLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.Location = new Point(123, 354);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(293, 63);
            tableLayoutPanel1.TabIndex = 5;
            // 

            // Employerbtn
            // 
            Employerbtn.Anchor = AnchorStyles.None;
            Employerbtn.BackColor = Color.RoyalBlue;
            Employerbtn.FlatAppearance.BorderSize = 0;
            Employerbtn.FlatStyle = FlatStyle.Flat;
            Employerbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employerbtn.ForeColor = SystemColors.ButtonHighlight;
            Employerbtn.Location = new Point(149, 3);
            Employerbtn.Name = "Employerbtn";
            Employerbtn.Size = new Size(141, 57);
            Employerbtn.TabIndex = 5;
            Employerbtn.Text = "Employer";
            Employerbtn.UseVisualStyleBackColor = false;
            Employerbtn.Click += button;
            Employerbtn.MouseClick += button2_MouseClick;
            // 
            // Applicantbtn
            // 
            Applicantbtn.BackColor = Color.Snow;
            Applicantbtn.Dock = DockStyle.Fill;
            Applicantbtn.FlatAppearance.BorderSize = 0;
            Applicantbtn.FlatStyle = FlatStyle.Flat;
            Applicantbtn.Font = new Font("Britannic Bold", 12F);
            Applicantbtn.Location = new Point(3, 3);
            Applicantbtn.Name = "Applicantbtn";
            Applicantbtn.Size = new Size(140, 57);
            Applicantbtn.TabIndex = 6;
            Applicantbtn.Text = "Applicant";
            Applicantbtn.UseVisualStyleBackColor = false;
            Applicantbtn.Click += button3_Click;
            // 
            // Loginbtn
            // 
            Loginbtn.Anchor = AnchorStyles.None;
            Loginbtn.BackColor = Color.Coral;
            Loginbtn.FlatAppearance.BorderSize = 0;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(201, 289);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(109, 38);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Log In";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += SignIn;
            
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Candara Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(40, 153);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(437, 32);
            textBox2.TabIndex = 3;
            textBox2.Text = "********";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Candara Light", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(40, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 32);
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
            label1.Location = new Point(40, 25);
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
            label3.Location = new Point(397, 280);
            label3.Name = "label3";
            label3.Size = new Size(169, 37);
            label3.TabIndex = 7;
            label3.Text = "Signing in";
            // 
            // picture
            // 
            picture.Anchor = AnchorStyles.None;
            picture.Image = Image.FromFile("..\\..\\..\\Image\\or.png");
            picture.Location = new Point(435, 174);
            picture.Name = "picture";
            picture.Size = new Size(102, 103);
            picture.TabIndex = 9;
            picture.TabStop = false;
           
            // 
            // blackColorLine
            // 
            blackColorLine.Anchor = AnchorStyles.None;
            blackColorLine.BackColor = Color.Black;
            blackColorLine.Location = new Point(379, 840);
            blackColorLine.Name = "blackColorLine";
            blackColorLine.Size = new Size(204, 10);
            blackColorLine.TabIndex = 10;
            blackColorLine.TabStop = false;
            // 
            // SignUpbtn
            // 
            SignUpbtn.Anchor = AnchorStyles.None;
            SignUpbtn.FlatAppearance.BorderSize = 0;
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpbtn.Location = new Point(397, 795);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(169, 39);
            SignUpbtn.TabIndex = 11;
            SignUpbtn.Text = "Sign Up";
            SignUpbtn.UseVisualStyleBackColor = true;
            
            t.Anchor = AnchorStyles.None;
            t.Text = "hola como es tas";
            t.Location = new Point(397, 795);
            t.Size = new Size(169, 39);
            //t.BorderRadius = 20;
            //t.BorderSize = 100;
            
            // 
            // MainPanel
            // 
           // MainPanel.Controls.Add(t);
            MainPanel.Controls.Add(SIgnUpPanel1);
            MainPanel.Controls.Add(blackColorLine);
            MainPanel.Controls.Add(panel1);
            MainPanel.Controls.Add(SignUpbtn);
            MainPanel.Controls.Add(picture);
            MainPanel.Controls.Add(label3);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1920, 937);
            MainPanel.TabIndex = 12;
            // 
            // Form1
            // 
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1635, 920);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(MainPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SIgnUpPanel1.ResumeLayout(false);
            SIgnUpPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)blackColorLine).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

       

        private bool apage;
        #endregion
        private topButtons t;
        private Panel panel1;
        private Label companyname1;
        private borderedPanels SIgnUpPanel1;
        private Button Applicantbtn;
        private Button Employerbtn;
        private Button Loginbtn;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picture;
        private PictureBox blackColorLine;
        private Button SignUpbtn;
        private Panel MainPanel;
    }
}



public class borderdTextbox : TextBox
{
    private int bordersize = 0;
    public int BorderSize
    {
        get { return bordersize; }
        set { bordersize = value; }
    }
    private int borderRadius = 10;
    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; }
    }
    private Color[] backColor = [Color.Coral, Color.RoyalBlue, Color.AliceBlue];
    private int ColorChoice;

    public borderdTextbox(int color)
    {
        //this.FlatStyle = FlatStyle.Flat;
        //this.FlatAppearance.BorderSize = 0;
        //  this.Size = new Size(400, 200);
        this.BackColor = backColor[color];
        if (color == 0)
        {
            this.ForeColor = Color.Black;
        }
        else if (color == 1)
        {
            this.ForeColor = Color.White;
        }
        else
        {
            this.ForeColor = Color.Coral;
        }
        ColorChoice = color;
    }
    private GraphicsPath GetFigurePath(Rectangle rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectSurface = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectSurface, bordersize, bordersize);
        int smoothSize = 2;
        if (bordersize > 0)
        {
            smoothSize = bordersize;
        }
        if (borderRadius > 2)
        {
            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(backColor[ColorChoice], bordersize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);
                if (bordersize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
        else
        {
            this.Region = new Region(rectSurface);
            if (bordersize >= 1)
            {
                using (Pen penBorder = new Pen(backColor[ColorChoice], bordersize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }
    private void Container_BackColorChanged(object sender, EventArgs e)
    {
        this.Invalidate();
    }
}

