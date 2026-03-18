using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace risovalka
{
    internal class Rectangle : Figure
    {
        public Rectangle(int x0, int y0, int x1, int y1, int r, int g, int b) : base(x0, y0, x1, y1, r, g, b)
        {
        }

        public static void Draw(Graphics canvas, int x0, int y0, int x1, int y1, int r, int g, int b)
        {
            if (r > 255 || r < 0 || g > 255 || g < 0 || b > 255 || b < 0) { throw new Exception("цвет вне диапазона"); }

            int x00 = Math.Min(x0, x1);
            int y00 = Math.Min(y0, y1);

            int x11 = x00;
            int y11 = Math.Max(y0, y1);

            int x22 = Math.Max(x0, x1);
            int y22 = y11;

            int x33 = x22;
            int y33 = y00;

            Pen pen = new Pen(Color.FromArgb(b, r, g));
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));

            Point[] points = { new Point(x00, y00), new Point(x11, y11), new Point(x22, y22), new Point(x33, y33) };

            canvas.FillPolygon(brush, points);
            canvas.DrawPolygon(pen, points);

            pen.Dispose();
            brush.Dispose();
        }
    }
}
