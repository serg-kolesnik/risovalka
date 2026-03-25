using System.Drawing;

namespace risovalka
{
    public class Figure
    {
        protected int x0, y0, x1, y1;
        protected Color currentLineColor, currentFillColor;

        public Figure(int x0, int y0, int x1, int y1, Color currentLineColor, Color currentFillColor)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.currentLineColor = currentLineColor;
            this.currentFillColor = currentFillColor;
        }

        public virtual void Draw (Graphics canvas)
        {
            
        }
    }
}