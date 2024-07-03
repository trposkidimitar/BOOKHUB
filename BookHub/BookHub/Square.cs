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
        public Square(Color color, Point location, int size, int thickness) : base(color, location, size, thickness)
        {
        }

        public override void Draw(Graphics g)
        {
            //if (IsSelected)
            //{
            Pen p = new Pen(Color.Black, Thickness);
            g.DrawRectangle(p, this.Location.X - Size / 2, this.Location.Y - Size / 2, this.Size, this.Size);
            p.Dispose();
            //}

            Brush brush = new SolidBrush(this.Color);
            g.FillRectangle(brush, this.Location.X - Size / 2, this.Location.Y - Size / 2, this.Size, this.Size);
            brush.Dispose();
        }

        public override bool SelectShape(Point point)
        {
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(this.Location.X - Size / 2, this.Location.Y - Size / 2, this.Size, this.Size);
            return r.Contains(point);
        }
    }
}
