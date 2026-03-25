using System;
using System.Drawing;
using System.Windows.Forms;

namespace risovalka
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        public int x0, y0, x1, y1;
        string whatShape = "Rectangle";
        public Color currentLineColor = Color.Gray;
        public Color currentFillColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            canvas = panel1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                whatShape = "Ellipse";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                whatShape = "Triangle";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                whatShape = "Rectangle";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);
        }

        protected void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;

            try
            {
                x1 = e.X;
                y1 = e.Y;

                

                canvas = panel1.CreateGraphics();

                if (whatShape == "Rectangle")
                {
                    Rectangle rec = new Rectangle(x0, y0, x1, y1, currentLineColor, currentFillColor);
                    rec.Draw(canvas);
                }
                else if (whatShape == "Ellipse")
                {
                    Ellipse el = new Ellipse(x0, y0, x1, y1, currentLineColor, currentFillColor);
                    el.Draw(canvas);
                }
                else if (whatShape == "Triangle")
                {
                    Triangle tr = new Triangle(x0, y0, x1, y1, currentLineColor, currentFillColor);
                    tr.Draw(canvas);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        public void btnLineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentLineColor = colorDialog1.Color;
                panel3.BackColor = colorDialog1.Color;

            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                currentFillColor = colorDialog2.Color;
                panel2.BackColor = colorDialog2.Color;
            }
        }
    }
}