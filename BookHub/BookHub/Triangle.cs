using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Triangle : Shape
    {
        public Triangle(Color color, Point location, int size, int thickness) : base(color, location, size, thickness)
        {
        }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[3];
            double height = Math.Sqrt(3) * Size / 2;

            points[0] = new Point(Location.X, Location.Y - (int)height);
            points[1] = new Point(Location.X - Size, Location.Y + (int)(height / 2));
            points[2] = new Point(Location.X + Size, Location.Y + (int)(height / 2));

            Pen p = new Pen(Color.Black, Thickness);
            g.DrawPolygon(p, points);

            Brush brush = new SolidBrush(this.Color);
            g.FillPolygon(brush, points);
        }

        public override bool SelectShape(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
