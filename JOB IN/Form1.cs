namespace JOB_IN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            SIgnUpPanel1.BackColor = Color.RoyalBlue;
            companyname1.ForeColor = Color.White;
            panel1.BackColor = Color.RoyalBlue;
            button1.BackColor = Color.RoyalBlue;
            button3.BackColor = Color.Coral;
            button3.ForeColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
            //panel2.BackgroundImage = Image.FromFile("D:\\iconb.png");
            //panel2.Size = new Size(100, 83);
            picture.Image = Image.FromFile("..\\..\\..\\Image\\iconb.png");
        }

        private void button(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SIgnUpPanel1.BackColor = Color.Coral;
            companyname1.ForeColor = Color.Black;
            panel1.BackColor = Color.Coral;
            button1.BackColor = Color.Coral;
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.RoyalBlue;
            // panel2.BackgroundImage = Image.FromFile("D:\\or.png");
            //panel2.Size = new Size(100, 100);
            picture.Image = Image.FromFile("..\\..\\..\\Image\\or.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SIgnUpPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SIgnUpPanel1.Width, SIgnUpPanel1.Height, 150, 150));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 10, 10));
            textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 20, 20));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 20, 20));
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            blackColorLine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, blackColorLine.Width, blackColorLine.Height, 5, 5));
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
