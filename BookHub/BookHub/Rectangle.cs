using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle(Color color, Point location, int size) : base(color, location, size)
        {
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override bool SelectShape(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
