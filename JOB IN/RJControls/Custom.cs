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
    
    public class Custom : Button
    {
        public static Font font(float s) {
          Font f  = new Font("Cascadia Mono", s);
          return f;
        } 
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

        public Custom() {
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
        private int ColorChoice;

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
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }

}
