using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace risovalka
{
    internal class Ellipse : Figure
    {

        public Ellipse(int x0, int y0, int x1, int y1, int r, int g, int b) : base(x0, y0, x1, y1, r, g, b)                  
        {
        }

        public static void Draw(Graphics canvas, int x0, int y0, int x1, int y1, int r, int g, int b)
        {
            if (r > 255 || r < 0 || g > 255 || g < 0 || b > 255 || b < 0) { throw new Exception("цвет вне диапазона"); }

            int x = Math.Min(x0, x1);
            int y = Math.Min(y0, y1);

            int width = Math.Abs(x1 - x0);
            int height = Math.Abs(y1 - y0);

            Pen pen = new Pen(Color.FromArgb(b, r, g));
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));

            canvas.FillEllipse(brush, x, y, width, height);
            canvas.DrawEllipse(pen, x, y, width, height);

            pen.Dispose();
            brush.Dispose();
        }
    }
}
