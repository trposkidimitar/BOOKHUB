using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Point location { get; set; }
        public int size { get; set; }
        public abstract void Draw(Graphics g);
        public abstract bool SelectShape(Point point);
        public bool IsSelected { get; set; } = false;

        public Shape(Color color, Point location, int size)
        {
            Color = color;
            this.location = location;
            this.size = size;
        }
    }
}
