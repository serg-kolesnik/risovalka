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
        public Ellipse(int x0, int y0, int x1, int y1, Color currentLineColor, Color currentFillColor) : base (x0, y0, x1, y1, currentLineColor, currentFillColor)
        {
        }

        public override void Draw(Graphics canvas)
        {
            int x = Math.Min(x0, x1);
            int y = Math.Min(y0, y1);

            int width = Math.Abs(x1 - x0);
            int height = Math.Abs(y1 - y0);

            Pen pen = new Pen(currentLineColor);
            Brush brush = new SolidBrush(currentFillColor);

            canvas.FillEllipse(brush, x, y, width, height);
            canvas.DrawEllipse(pen, x, y, width, height);

            pen.Dispose();
            brush.Dispose();
        }
    }
}
