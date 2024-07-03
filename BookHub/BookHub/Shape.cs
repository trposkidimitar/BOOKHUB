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
        public Point Location { get; set; }
        public int Size { get; set; }
        public int Thickness { get; set; }
        public abstract void Draw(Graphics g);
        public abstract bool SelectShape(Point point);
        public bool IsSelected { get; set; } = false;

        public Shape(Color color, Point location, int size, int thickness)
        {
            this.Color = color;
            this.Location = location;
            this.Size = size;
            this.Thickness = thickness;
        }
    }
}
