using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace risovalka
{
    internal class Triangle
    {
        int x0, y0, x1, y1, r, g, b;

        public Triangle(int x0, int y0, int x1, int y1, int r, int g, int b)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static void Draw(Graphics canvas, int x0, int y0, int x1, int y1, int r, int g, int b)
        {
            if (r > 255 || r < 0 || g > 255 || g < 0 || b > 255 || b < 0) { throw new Exception("цвет вне диапазона"); }

            int x00 = Math.Min(x0, x1);
            int y00 = Math.Max(y0, y1);

            int x11 = Math.Max(x0, x1);
            int y11 = y00;

            int x22 = (x00 + x11) / 2;
            int y22 = Math.Min(y0, y1);

            Pen pen = new Pen(Color.FromArgb(b, r, g));
            Brush brush = new SolidBrush(Color.FromArgb(r, g, b));

            Point[] points = { new Point(x00, y00), new Point(x11, y11), new Point(x22, y22) };

            canvas.FillPolygon(brush, points);
            canvas.DrawPolygon(pen, points);

            pen.Dispose();
            brush.Dispose();
        }
    }
}
