using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace risovalka
{
    internal class Figure
    {
        protected int x0, y0, x1, y1, r, g, b;
        Color lineColour, fillColour;

        public Figure(int x0, int y0, int x1, int y1, int r, int g, int b)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public virtual void Draw(Graphics canvas, int x0, int y0, int x1, int y1, int r, int g, int b)
        {

        }
    }
}
