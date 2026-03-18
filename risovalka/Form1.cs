using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovalka
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        public int x0, y0, x1, y1;
        string whatShape = "Rectangle";

        public Form1()
        {
            InitializeComponent();
            canvas = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e) // нерабочая
        {
            try
            {
                whatShape = "Rectangle";

                var r = Convert.ToInt32(textBox1.Text);
                var g = Convert.ToInt32(textBox2.Text);
                var b = Convert.ToInt32(textBox3.Text);

                x0 = 0;
                y0 = 0;
                x1 = 200;
                y1 = 200;

                Rectangle.Draw(canvas, x0, y0, x1, y1, r, g, b);
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;

            try
            {
                x1 = e.X;
                y1 = e.Y;

                var r = Convert.ToInt32(textBox1.Text);
                var g = Convert.ToInt32(textBox2.Text);
                var b = Convert.ToInt32(textBox3.Text);

                canvas = panel1.CreateGraphics();

                if (whatShape == "Rectangle")
                {
                    Rectangle.Draw(canvas, x0, y0, x1, y1, r, g, b);
                }
                else if (whatShape == "Ellipse")
                {
                    Ellipse.Draw(canvas, x0, y0, x1, y1, r, g, b);
                }
                else if (whatShape == "Triangle")
                {
                    Triangle.Draw(canvas, x0, y0, x1, y1, r, g, b);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}