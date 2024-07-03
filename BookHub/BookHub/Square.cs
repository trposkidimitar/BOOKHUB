using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Square : Shape
    {
        public Square(Color color, Point location, int size) : base(color, location, size)
        {
        }

        public override void Draw(Graphics g)
        {
            if (IsSelected)
            {
                Pen p = new Pen(Color.Yellow, 4);
                g.DrawRectangle(p, this.location.X - size / 2, this.location.Y - size / 2, this.size, this.size);
                p.Dispose();
            }

            Brush brush = new SolidBrush(this.Color);
            g.FillRectangle(brush, this.location.X - size / 2, this.location.Y - size / 2, this.size, this.size);
            brush.Dispose();
        }

        public override bool SelectShape(Point point)
        {
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(this.location.X - size / 2, this.location.Y - size / 2, this.size, this.size);
            return r.Contains(point);
        }
    }
}
