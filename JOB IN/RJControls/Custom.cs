using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.ComponentModel;



namespace JOB_IN.RJControls
{
    
    public class Custom
    {
        public static List<string> job_category = new List<string>() { "Architecture and Engineering", "Arts and design", "Maintenance ", "Business and Financial", "Social Services", "Construction", "Farming and Forestry", "Healthcare support", "Installation and repair", "Legal", "Office and Administrative", "Personal care and service ", "Sales", "Tech and Web development","Others" };
        public static Font font(float s)
        {
            Font f = new Font("Cascadia Mono", s);
            return f;
        }
    }
    public class Customb : Button
    {
       
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        [Category("Advanced buttonSetting")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public int BorderSize1 { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public int BorderRadius1 { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public Color BorderColor1 { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Advanced buttonSetting")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set {  this.BackColor = value; }
        }
        [Category("Advanced buttonSetting")]
        public Color TextColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Customb() {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;


        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius) {


            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();


            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent) {


            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);


            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);

                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if(borderSize>=1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0,this.Width-1,this.Height-1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            if(this.DesignMode)
                this.Invalidate();
        }
    }

    // Class of Custom Button
    public class topButtons : Button
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
        private Color ColorChoice;

        public topButtons(int color)
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
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
            ColorChoice = backColor[color];
        }
        public topButtons(Color Back, Color For)
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            //  this.Size = new Size(400, 200);
            this.BackColor = Back;
            this.ForeColor = For;
            ColorChoice = Back;
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
                using (Pen penBorder = new Pen(ColorChoice, bordersize))
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
                    using (Pen penBorder = new Pen(ColorChoice, bordersize))
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


    public class borderedPanels : Panel
    {
        private int bordersize = 0;
        public int BorderSize
        {
            get { return bordersize; }
            set { bordersize = value; }
        }
        private int borderRadius = 40;
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; }
        }
        private Color[] backColor = [Color.Coral, Color.RoyalBlue];
        private int ColorChoice;

        public borderedPanels()
        {
           
            //  this.Size = new Size(400, 200);

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
         //   this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }



    public class borderedscrollPanels : FlowLayoutPanel
    {
        private int bordersize = 0;
        public int BorderSize
        {
            get { return bordersize; }
            set { bordersize = value; }
        }
        private int borderRadius = 40;
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; }
        }
        private Color[] backColor = [Color.Coral, Color.RoyalBlue];
        private int ColorChoice;

        public borderedscrollPanels()
        {
           // AutoScroll = true;
            VerticalScroll.Enabled = true;
            AutoSize = false;
            DoubleBuffered = true;
            //  WrapContents = false;
          

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //  this.Size = new Size(400, 200);

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
            //   this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }



    class jobDesc : borderedPanels
    {
        private string jobID;
        public Label jobName;
        public Label jobDescription;
        public Label jobRequirement;
        public topButtons more;
        public static int Y = 42;
        public jobDesc(string JobName, string JobDescription, string JobRequirement)
        {
            jobName = new Label();
            jobDescription = new Label();
            jobRequirement = new Label();
            more = new topButtons(0);


            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(29);
            jobName.Size = new Size(200, 60);
            jobName.Text = JobName;
            jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550, -70);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(14);
            jobDescription.Size = new Size(200, 60);
            jobDescription.Text = JobDescription;
            jobDescription.Location = new Point(-500, 30);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(20);
            jobRequirement.Size = new Size(400, 60);
            jobRequirement.Text = JobRequirement;
            jobRequirement.Location = new Point(-525, 80);

            more.Anchor = AnchorStyles.None;
            more.Font = Custom.font(17);
            more.Text = "More Info";
            more.Size = new Size(290, 50);
            more.Location = new Point(450, 130);

            this.BackColor = Color.White;
            this.Controls.Add(jobName);
            this.Controls.Add(jobDescription);
            this.Controls.Add(jobRequirement);
            this.Controls.Add(more);
            this.Size = new Size(1405, 300);

            this.Anchor = AnchorStyles.None;
            this.Location = new Point(42, Y);
            recalculateY();


        }
        public static void recalculateY()
        {
            Y += 342;
        }
    }



    class jobDescDetail : borderedPanels
    {
        private int jobID;
        private Label jobName;
        private Label jobDescription;
        private Label jobRequirement;
        private Label JobField;
        private Label Deadline;
        private Label TotalApplicant;
        private Label PayEstimate;
        private Label Employer;
        private topButtons Apply;
        private topButtons close;

        public jobDescDetail(int jid)
        {
            Job j = Db.fetchJobId(jid);
            jobID = j.id;



            jobName = new Label();
            jobDescription = new Label();
            jobRequirement = new Label();
            JobField = new Label();
            Deadline = new Label();
            TotalApplicant = new Label();
            PayEstimate = new Label();
            Employer = new Label();
            Apply = new topButtons(0);
            close = new topButtons(0);

            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(29);
            jobName.Size = new Size(200, 60);
            jobName.Text = j.name;
            //jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550, -300);

            Employer.Anchor = AnchorStyles.None;
            Employer.Font = Custom.font(22);
            Employer.Size = new Size(400, 60);
            Employer.Text = j.oEmail;
            Employer.Location = new Point(-520, -230);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(14);
            jobDescription.Size = new Size(200, 60);
            jobDescription.Text = j.description;
            jobDescription.Location = new Point(-500, -150);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(14);
            jobRequirement.Size = new Size(200, 60);
            jobRequirement.Text = j.requirement;
            jobRequirement.Location = new Point(-520, 100);

            PayEstimate.Anchor = AnchorStyles.None;
            PayEstimate.Font = Custom.font(13);
            PayEstimate.Size = new Size(200, 90);
            PayEstimate.Text = "Pay estimate: \n30,000 ETB";
            PayEstimate.Location = new Point(-520, 0);

            TotalApplicant.Anchor = AnchorStyles.None;
            TotalApplicant.Font = Custom.font(14);
            TotalApplicant.Size = new Size(400, 60);
            TotalApplicant.Text = j.capacity.ToString();
            TotalApplicant.Location = new Point(450, -80);

            Deadline.Anchor = AnchorStyles.None;
            Deadline.Font = Custom.font(14);
            Deadline.Size = new Size(200, 60);
            Deadline.Text = "Deadline: \n" + j.Deadline;
            Deadline.Location = new Point(450, -150);

            Apply.Anchor = AnchorStyles.None;
            Apply.Font = Custom.font(17);
            Apply.Text = "Apply";
            Apply.Size = new Size(290, 50);
            Apply.Location = new Point(450, 150);

            close.Anchor = AnchorStyles.None;
            close.Font = Custom.font(17);
            close.Text = "Close";
            close.Size = new Size(290, 50);
            close.Location = new Point(450, 220);
            close.Click += rem;

            this.BackColor = Color.LightGoldenrodYellow;
            this.Controls.Add(jobName);
            this.Controls.Add(Employer);
            this.Controls.Add(jobDescription);
            this.Controls.Add(jobRequirement);
            this.Controls.Add(Deadline);
            this.Controls.Add(TotalApplicant);
            this.Controls.Add(PayEstimate);
            this.Controls.Add(Apply);
            this.Controls.Add(close);
            this.Size = new Size(1560, 840);


            this.Anchor = AnchorStyles.None;
            this.Location = new Point(195, 150);


        }

        public jobDescDetail(string JobName, string JobDescription, string JobRequirement)
        {
            jobName = new Label();
            jobDescription = new Label();
            jobRequirement = new Label();
            JobField = new Label();
            Deadline = new Label();
            TotalApplicant = new Label();
            PayEstimate = new Label();
            Employer = new Label();
            Apply = new topButtons(0);
            close = new topButtons(0);

            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(29);
            jobName.Size = new Size(200, 60);
            jobName.Text = JobName;
            //jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550, -300);

            Employer.Anchor = AnchorStyles.None;
            Employer.Font = Custom.font(22);
            Employer.Size = new Size(400, 60);
            Employer.Text = "Organization";
            Employer.Location = new Point(-520, -230);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(14);
            jobDescription.Size = new Size(200, 60);
            jobDescription.Text = JobDescription;
            jobDescription.Location = new Point(-500, -150);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(14);
            jobRequirement.Size = new Size(200, 60);
            jobRequirement.Text = "requirements";
            jobRequirement.Location = new Point(-520, 100);

            PayEstimate.Anchor = AnchorStyles.None;
            PayEstimate.Font = Custom.font(13);
            PayEstimate.Size = new Size(200, 90);
            PayEstimate.Text = "Pay estimate: \n30,000 ETB";
            PayEstimate.Location = new Point(-520, 0);

            TotalApplicant.Anchor = AnchorStyles.None;
            TotalApplicant.Font = Custom.font(14);
            TotalApplicant.Size = new Size(400, 60);
            TotalApplicant.Text = "Total Applicants:\n19/20";
            TotalApplicant.Location = new Point(450, -80);

            Deadline.Anchor = AnchorStyles.None;
            Deadline.Font = Custom.font(14);
            Deadline.Size = new Size(200, 60);
            Deadline.Text = "Deadline: \n12/7/25";
            Deadline.Location = new Point(450, -150);

            Apply.Anchor = AnchorStyles.None;
            Apply.Font = Custom.font(17);
            Apply.Text = "Apply";
            Apply.Size = new Size(290, 50);
            Apply.Location = new Point(450, 150);

            close.Anchor = AnchorStyles.None;
            close.Font = Custom.font(17);
            close.Text = "Close";
            close.Size = new Size(290, 50);
            close.Location = new Point(450, 220);
            close.Click += rem;

            this.BackColor = Color.LightGoldenrodYellow;
            this.Controls.Add(jobName);
            this.Controls.Add(Employer);
            this.Controls.Add(jobDescription);
            this.Controls.Add(jobRequirement);
            this.Controls.Add(Deadline);
            this.Controls.Add(TotalApplicant);
            this.Controls.Add(PayEstimate);
            this.Controls.Add(Apply);
            this.Controls.Add(close);
            this.Size = new Size(1560, 840);
            

            this.Anchor = AnchorStyles.None;
            this.Location = new Point(195, 150);

            


        }

        private void rem(object? sender, EventArgs e)
        {
            this.Dispose();
        }
    }




    class jobHistory : borderedPanels
    {
        private Label jobName;
        private Label employer;
        private Label jobType;
        private Label jobRequirement;
        private Label deadline;
        private topButtons more;


        public static int Y = 42;
        public jobHistory(string JobName, string Employer, string JobType, string JobRequirement, string Deadline)
        {
            jobName = new Label();
            employer = new Label();
            jobType = new Label();
            jobRequirement = new Label();
            deadline = new Label();
            more = new topButtons(0);


            jobName.Anchor = AnchorStyles.None;
            jobName.Font = Custom.font(17);
            jobName.Size = new Size(120, 40);
            jobName.Text = JobName;
            //jobName.BackColor = Color.Red;
            jobName.Location = new Point(-350, -20);
            //  jobName.Click += Enlarge;

            employer.Anchor = AnchorStyles.None;
            employer.Font = Custom.font(12);
            employer.Size = new Size(120, 40);
            employer.Text = Employer;
            employer.Location = new Point(-350, 40);
            //employer.BackColor = Color.Blue;
            // employer.Click += Enlarge;

            jobType.Anchor = AnchorStyles.None;
            jobType.Font = Custom.font(12);
            jobType.Size = new Size(120, 40);
            jobType.Text = JobType;
            jobType.Location = new Point(0, -20);
            //jobType.BackColor = Color.Blue;
            // jobType.Click += Enlarge;

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(11);
            jobRequirement.Size = new Size(140, 40);
            jobRequirement.Text = JobRequirement;
            jobRequirement.Location = new Point(0, 40);
            //jobRequirement.BackColor = Color.Blue;
            //  jobRequirement.Click += Enlarge;

            deadline.Anchor = AnchorStyles.None;
            deadline.Font = Custom.font(10);
            deadline.Size = new Size(200, 60);
            deadline.Text = Deadline;
            deadline.Location = new Point(400, -20);
            //deadline.BackColor = Color.Blue;
            // deadline.Click += Enlarge;

            more.Anchor = AnchorStyles.None;
            more.Font = Custom.font(10);
            more.Text = "More Info";
            more.Size = new Size(290, 50);
            more.Location = new Point(450, 90);




            this.BackColor = Color.LightGray;
            this.Controls.Add(jobName);
            this.Controls.Add(employer);
            this.Controls.Add(jobType);
            this.Controls.Add(jobRequirement);
            this.Controls.Add(deadline);
            //this.Controls.Add(more);

            this.Size = new Size(1205, 150);


            this.Anchor = AnchorStyles.None;
            this.Location = new Point(42, Y);
            recalculateY();


        }

       
        public static void recalculateY()
        {
            Y += 342;
        }
    }

}
