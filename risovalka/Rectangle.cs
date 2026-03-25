using System;
using System.Drawing;

namespace risovalka
{
    internal class Rectangle : Figure
    {
        public Rectangle(int x0, int y0, int x1, int y1, Color currentLineColor, Color currentFillColor) : base (x0, y0, x1, y1, currentLineColor, currentFillColor)
        {
        }

        public override void Draw(Graphics canvas)
        { 
            int x00 = Math.Min(x0, x1);
            int y00 = Math.Min(y0, y1);
            int x11 = x00;
            int y11 = Math.Max(y0, y1);
            int x22 = Math.Max(x0, x1);
            int y22 = y11;
            int x33 = x22;
            int y33 = y00;

            Pen pen = new Pen(currentLineColor);
            Brush brush = new SolidBrush(currentFillColor);

            Point[] points = { new Point(x00, y00), new Point(x11, y11), new Point(x22, y22), new Point(x33, y33) };

            canvas.FillPolygon(brush, points);
            canvas.DrawPolygon(pen, points);

            pen.Dispose();
            brush.Dispose();
        }
    }
}
