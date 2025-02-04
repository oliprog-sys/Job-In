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
    /// <summary>
    /// organization custom panel
    /// </summary>
    class orgJobs : borderedPanels
    {
        private Job job;
        private Label jname;
        private Label jdesc;
        private Label jreq;
        private Label jcat;
        private Label DeadLine;
        private Label app;
        private Label jexplvl;
        public Customb Showbutton;
        public Label pestimate;
        

        public orgJobs(Job job)
        {
            this.job = job;
            jname = new Label();
            jdesc = new Label();
            jreq = new Label();
            jcat = new Label();
            jexplvl = new Label();
            DeadLine = new Label();
            app = new Label();
            Showbutton = new Customb();
            pestimate = new Label();

            jname.Text = "Job Name: " + job.name;
            jname.Font = Custom.font(16);
            jname.Size = new Size(500, 35);
            jname.Location = new Point(50, 30);

            jcat.Text = "Job Catagory: " + job.category;
            jcat.Font = Custom.font(12);
            jcat.Size = new Size(500, 30);
            jcat.Location = new Point(50, 70);

            jdesc.Text = "Job Description: " + "\n"+job.description;
            jdesc.Font = Custom.font(12);
            jdesc.Size = new Size(500,200);
            jdesc.Location = new Point(50, 100);


            app.Text = "No of applicants needed : " + job.capacity;
            app.Font = Custom.font(12);
            app.Size = new Size(500, 30);
            app.Location = new Point(50, 300);

            pestimate.Text = "Pay Estimate : " + job.payestimate+" ETB";
            pestimate.Font = Custom.font(12);
            pestimate.Size = new Size(500, 30);
            pestimate.Location = new Point(50, 265);


            jreq.Text = "Job Requirement : " +"\n"+ job.requirement;
            jreq.Font = Custom.font(12);
            jreq.Size = new Size(700, 300);
            jreq.Location = new Point(700, 40);

            jexplvl.Text = "Job Experience: " + job.Explevel+" Years";
            jexplvl.Font = Custom.font(12);
            jexplvl.Size = new Size(500, 30);
            jexplvl.Location = new Point(700, 200);

            DeadLine.Text = "Dead Line: " + job.Deadline;
            DeadLine.Font = Custom.font(12);
            DeadLine.Size = new Size(500, 30);
            DeadLine.Location = new Point(700, 230);

            Showbutton.Text = "Show Applicants";
            Showbutton.Font = Custom.font(12);
            Showbutton.Size = new Size(300, 50);
            Showbutton.BackColor = Color.RoyalBlue;
            Showbutton.BorderRadius = 20;
            Showbutton.BorderSize = 0;
            Showbutton.FlatAppearance.BorderSize = 0;
            Showbutton.FlatStyle = FlatStyle.Flat;
            Showbutton.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Showbutton.ForeColor = Color.White;
            Showbutton.Location = new Point(1000, 280);


            this.Size = new Size(1405, 350);
            //this.Anchor = AnchorStyles.None;
            this.Controls.Add(jname);
            this.Controls.Add(jexplvl);
            this.Controls.Add(Showbutton);
            this.Controls.Add(jcat);
            this.Controls.Add(pestimate); 
            this.Controls.Add(app);
            this.Controls.Add(DeadLine);
            this.Controls.Add(jdesc); 
            this.Controls.Add(jreq);
           
            this.BackColor = Color.White;




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
            jobName.Font = Custom.font(24);
            jobName.Size = new Size(600, 60);
            jobName.Text ="Job Name: " +JobName;
            //jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550, -70);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(14);
            jobDescription.Size = new Size(600, 70);
            jobDescription.Text ="Job Description:\n"+ JobDescription;
            jobDescription.Location = new Point(-500, 30);

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(16);
            jobRequirement.Size = new Size(800, 60);
            jobRequirement.Text = "Job Requirement: "+JobRequirement;
            jobRequirement.Location = new Point(-545, 100);

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
        public topButtons Apply;
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
            jobName.Font = Custom.font(27);
            jobName.Size = new Size(500, 60);
            jobName.Text ="Title: " + j.name;
            //jobName.BackColor = Color.AliceBlue;
            jobName.Location = new Point(-550, -330);

            Employer.Anchor = AnchorStyles.None;
            Employer.Font = Custom.font(17);
            Employer.Size = new Size(400, 60);
            Employer.Text = "Posted by: "+j.oEmail;
            Employer.Location = new Point(-520, -230);

            jobDescription.Anchor = AnchorStyles.None;
            jobDescription.Font = Custom.font(12);
            jobDescription.Size = new Size(500, 100);
            jobDescription.Text = "Description: \n" + j.description;
            jobDescription.Location = new Point(-500, -150);
          //  jobDescription.BackColor = Color.Coral;
          //  jobDescription.ForeColor= Color.White;


            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(14);
            jobRequirement.Size = new Size(500, 140);
            jobRequirement.Text = "Requirement: \n" + j.requirement;
            jobRequirement.Location = new Point(-500, 0);
          //  jobRequirement.BackColor = Color.Coral;
          //  jobRequirement.ForeColor = Color.White;

            PayEstimate.Anchor = AnchorStyles.None;
            PayEstimate.Font = Custom.font(13);
            PayEstimate.Size = new Size(200, 90);
            PayEstimate.Text = "Pay estimate: \n30,000 ETB";
            PayEstimate.Location = new Point(-500, 130);

            TotalApplicant.Anchor = AnchorStyles.None;
            TotalApplicant.Font = Custom.font(14);
            TotalApplicant.Size = new Size(400, 60);
            TotalApplicant.Text = j.capacity.ToString();
            TotalApplicant.Location = new Point(450, -80);

            Deadline.Anchor = AnchorStyles.None;
            Deadline.Font = Custom.font(14);
            Deadline.Size = new Size(400, 100);
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

            this.BackColor = Color.AliceBlue;
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
            jobName.Font = Custom.font(14);
            jobName.Size = new Size(250, 70);
            jobName.Text = "Job Name: " + JobName;
            //jobName.BackColor = Color.Red;
            jobName.Location = new Point(-400, -20);
            //  jobName.Click += Enlarge;

            employer.Anchor = AnchorStyles.None;
            employer.Font = Custom.font(10);
            employer.Size = new Size(250, 70);
            employer.Text ="Org. email: "+ Employer;
            employer.Location = new Point(-400, 60);
            //employer.BackColor = Color.Blue;
            // employer.Click += Enlarge;

            jobType.Anchor = AnchorStyles.None;
            jobType.Font = Custom.font(10);
            jobType.Size = new Size(225, 70);
            jobType.Text = "Job Category: "+ JobType;
            jobType.Location = new Point(0, -20);
            //jobType.BackColor = Color.Blue;
            // jobType.Click += Enlarge;

            jobRequirement.Anchor = AnchorStyles.None;
            jobRequirement.Font = Custom.font(10);
            jobRequirement.Size = new Size(225, 70);
            jobRequirement.Text = "Job requirement: " + JobRequirement;
            jobRequirement.Location = new Point(0, 60);
            //jobRequirement.BackColor = Color.Blue;
            //  jobRequirement.Click += Enlarge;

            deadline.Anchor = AnchorStyles.None;
            deadline.Font = Custom.font(10);
            deadline.Size = new Size(200, 70);
            deadline.Text ="Deadline: \n" + Deadline;
            deadline.Location = new Point(450, -20);
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


    public class Applicant_desc : borderedPanels
    {
        public Label name;
        public Label email;
        public Label experience;
        public Label skill_desc;
        public Label work_Status;
        public Customb cv;
        public Customb accept;
        public Customb reject;
        public Customb certificate;

        public Applicant_desc() { }

        public Applicant_desc(applicants app)
        {
            name = new Label();
            email = new Label();
            experience = new Label();
            skill_desc = new Label();
            work_Status = new Label();
            cv = new Customb();
            accept = new Customb();
            reject = new Customb();
            certificate = new Customb();

            name.Text = "Name: " + app.name;
            name.Size = new Size(500,35);
            //name.Anchor = AnchorStyles.None;
            name.Font = Custom.font(16);
            name.Location = new Point(100, 50);



            email.Text = "Email: " + app.email;
            email.Size = new Size(500, 35);
            //email.Anchor = AnchorStyles.None;
            email.Font = Custom.font(16);
            email.Location = new Point(100, 100);


            experience.Text ="Experience: "+ app.experience + " years";
            experience.Size = new Size(500, 35);
            //experience.Anchor = AnchorStyles.None;
            experience.Font = Custom.font(16);
            experience.Location = new Point(900, 150);


            work_Status.Text = "Status: "+app.work_status;
            work_Status.Size = new Size(500, 35);
           // work_Status.Anchor = AnchorStyles.None;
            work_Status.Font = Custom.font(16);
            work_Status.Location = new Point(900, 50);


            skill_desc.Text = "Skill Description: " +"\n" +app.skill_description;
            skill_desc.Size = new Size(500, 135);
            //skill_desc.Anchor = AnchorStyles.None;
            skill_desc.Font = Custom.font(12);
            skill_desc.Location = new Point(100, 150);

            cv.Text = "CV";
            cv.Size = new Size(50,50);
            cv.BackColor = Color.RoyalBlue;
            cv.BorderRadius = 20;
            cv.BorderSize = 0;
            cv.FlatAppearance.BorderSize = 0;
            cv.FlatStyle = FlatStyle.Flat;
            cv.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cv.ForeColor = Color.White;
            cv.Location = new Point(100, 390);
            

            accept.Text = "Accept";
            accept.Size = new Size(100, 60);
            accept.BackColor = Color.RoyalBlue;
            accept.BorderRadius = 20;
            accept.BorderSize = 0;
            accept.FlatAppearance.BorderSize = 0;
            accept.FlatStyle = FlatStyle.Flat;
            accept.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept.ForeColor = Color.White;
            accept.Location = new Point(1000, 390);
            

            reject.Text = "Reject";
            reject.Size = new Size(100, 60);
            reject.BackColor = Color.RoyalBlue;
            reject.BorderRadius = 20;
            reject.BorderSize = 0;
            reject.FlatAppearance.BorderSize = 0;
            reject.FlatStyle = FlatStyle.Flat;
            reject.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reject.ForeColor = Color.White;
            reject.Location = new Point(1200, 390);
            

            certificate.Text = "Certficate";
            
            certificate.Size = new Size(200, 50);
            certificate.BackColor = Color.RoyalBlue;
            certificate.BorderRadius = 20;
            certificate.BorderSize = 0;
            certificate.FlatAppearance.BorderSize = 0;
            certificate.FlatStyle = FlatStyle.Flat;
            certificate.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            certificate.ForeColor = Color.White;
            certificate.Location = new Point(160, 390);


            this.Controls.Add(name);
            this.Controls.Add(email);
            this.Controls.Add(skill_desc);
            this.Controls.Add(work_Status);
            this.Controls.Add(experience);
            this.Controls.Add(cv);
            this.Controls.Add(accept);
            this.Controls.Add(reject);
            this.Controls.Add(certificate);
            this.BackColor = Color.White;
            this.Size = new Size(1405,500);
          

        }
    }
    public class Applicant_desc_his : borderedPanels
    {
        public Label name;
        public Label email;
        public Label experience;
        public Label skill_desc;
        public Label work_Status;
        public Customb cv;
        public Customb accept;
        public Customb reject;
        public Customb certificate;


        public Label acceptance_status;
       

        public Applicant_desc_his() { }

        public Applicant_desc_his(applicants app,int jid)
        {
            name = new Label();
            email = new Label();
            experience = new Label();
            skill_desc = new Label();
            work_Status = new Label();
            acceptance_status = new Label();


            name.Text = "Name: " + app.name;
            name.Size = new Size(500, 35);
            //name.Anchor = AnchorStyles.None;
            name.Font = Custom.font(16);
            name.Location = new Point(100, 50);



            email.Text = "Email: " + app.email;
            email.Size = new Size(500, 35);
            //email.Anchor = AnchorStyles.None;
            email.Font = Custom.font(16);
            email.Location = new Point(100, 100);


            experience.Text = "Experience: " + app.experience + " years";
            experience.Size = new Size(500, 35);
            //experience.Anchor = AnchorStyles.None;
            experience.Font = Custom.font(16);
            experience.Location = new Point(900, 150);

            acceptance_status.Text = "Acceptance status: " ;
            acceptance_status.Size = new Size(500, 35);
            //experience.Anchor = AnchorStyles.None;
            acceptance_status.Font = Custom.font(16);
            acceptance_status.Location = new Point(900, 200);



            work_Status.Text = "Status: " + app.work_status;
            work_Status.Size = new Size(500, 35);
            // work_Status.Anchor = AnchorStyles.None;
            work_Status.Font = Custom.font(16);
            work_Status.Location = new Point(900, 50);


            skill_desc.Text = "Skill Description: " + "\n" + app.skill_description;
            skill_desc.Size = new Size(500, 135);
            //skill_desc.Anchor = AnchorStyles.None;
            skill_desc.Font = Custom.font(12);
            skill_desc.Location = new Point(100, 150);

          


          


            
            this.Controls.Add(name);
            this.Controls.Add(email);
            this.Controls.Add(skill_desc);
            this.Controls.Add(work_Status);
            this.Controls.Add(experience);
            this.Controls.Add(acceptance_status);
            
            // this.Controls.Add(close);
            this.BackColor = Color.White;
            this.Size = new Size(1405, 400);


        }
    }
}
