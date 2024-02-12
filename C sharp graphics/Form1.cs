namespace C_sharp_graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            g=this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Red, 5);

            g.DrawLine(myPen, 20, 20, 200, 210);
            Rectangle rectangle = new Rectangle(20, 20, 250, 200);
            g.DrawRectangle(myPen, rectangle);
        }
    }
}
