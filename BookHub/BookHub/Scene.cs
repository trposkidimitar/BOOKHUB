using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub
{
    public class Scene
    {
        public List<Shape> Shapes { get; set; }
        public List<Polygon> Polygons { get; set; }
        public List<Line> Lines { get; set; }

        public Stack<Shape> ShapesStackUndoRedo { get; set; }
        public Stack<Line> LineUndoRedo { get; set; }

        public Shape SelectedShape { get; set; }
        public Polygon CurrentPolygon { get; set; }
        public Point LastPoint { get; set; }
        public Point Cursor { get; set; }

        public Color Color { get; set; }
        public int Size { get; set; }
        public int Thickness { get; set; }

        public bool Positioner { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Scene()
        {
            Shapes = new List<Shape>();
            Polygons = new List<Polygon>();
            Lines = new List<Line>();
            LineUndoRedo = new Stack<Line>();
            SelectedShape = null;
            CurrentPolygon = new Polygon(Thickness);
            LastPoint = Point.Empty;
            Color = Color.White;
            Size = 30;
            Thickness = 3;
            Positioner = false;
            this.Width = Width;
            this.Height = Height;
        }

        public void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        public void AddPointToPolygon(Point p)
        {
            CurrentPolygon.AddPointToPolygon(p);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon(this.Thickness);
            }
        }

        public void AddPointToLine(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, this.Thickness));
                LastPoint = new Point();
            }
            else
            {
                LastPoint = point;
            }
        }

        public void UpdateCursor(Point p)
        {
            CurrentPolygon.UpdateCursor(p);
        }

        public void Draw(Graphics g)
        {
            foreach (var shape in Shapes)
            {
                shape.Draw(g);
            }

            CurrentPolygon.Draw(g);
            foreach (Polygon polygon in Polygons)
            {
                polygon.Draw(g);
            }

            foreach (Line line in Lines)
            {
                line.Draw(g);
            }

            if (Positioner)
            {
                Pen p = new Pen(Color.Black);
                p.DashStyle = DashStyle.Dash;
                g.DrawLine(p, new Point(0, Cursor.Y), new Point(Width, Cursor.Y));
                g.DrawLine(p, new Point(Cursor.X, 0), new Point(Cursor.X, Height));
            }
        }

        public void SelectShape(Point point)
        {
            foreach (var shape in Shapes)
            {
                if (shape.SelectShape(point))
                {
                    if (SelectedShape == null)
                    {
                        SelectedShape = shape;
                        shape.IsSelected = !shape.IsSelected;
                    }
                    else //a form is selected
                    {
                        SelectedShape.IsSelected = false;
                        SelectedShape = shape;
                        SelectedShape.IsSelected = true;
                    }
                }
            }
        }
    }
}
