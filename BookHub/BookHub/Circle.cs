using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Circle : Shape
    {
        public Circle(Color color, Point location, int size) : base(color, location, size)
        {
        }

        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                Pen p = new Pen(Color.Yellow, 4);
                g.DrawEllipse(p, this.location.X - this.size, this.location.Y - this.size, 2 * this.size, 2 * this.size);
                p.Dispose();
            }

            Brush brush = new SolidBrush(this.Color);
            g.FillEllipse(brush, this.location.X - this.size, this.location.Y - this.size, 2 * this.size, 2 * this.size);
            brush.Dispose();
        }

        public override bool SelectShape(Point point)
        {
            return Math.Sqrt(Math.Pow(this.location.X - point.X, 2) + Math.Pow(this.location.Y - point.Y, 2)) <= this.size;
        }
    }
}
