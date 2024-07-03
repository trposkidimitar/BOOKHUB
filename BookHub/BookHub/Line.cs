using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Line
    {
        public Point Left { get; set; }
        public Point Right { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }

        public Line(Point left, Point right, Color color, int thickness)
        {
            Left = left;
            Right = right;
            Color = color;
            Thickness = thickness;
        }

        public void Draw(Graphics g)
        {
            if (Color == Color.White)
            {
                Color = Color.Black;
            }
            Pen p = new Pen(Color, Thickness);
            g.DrawLine(p, Left, Right);
            p.Dispose();
        }
    }
}
