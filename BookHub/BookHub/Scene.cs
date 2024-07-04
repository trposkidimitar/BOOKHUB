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
    [Serializable]
    public class Scene
    {
        public List<Shape> Shapes { get; set; }
        public List<Polygon> Polygons { get; set; }
        public List<Line> Lines { get; set; }

        public Stack<Shape> ShapesUndoRedo { get; set; }
        public Stack<Polygon> PolygonsUndoRedo { get; set; }
        public Stack<Line> LineUndoRedo { get; set; }
        public Stack<string> ShapeTypes { get; set; }
        public Stack<string> ShapeTypesRedo { get; set; }

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

        public int CounterOfShapes { get; set; }

        public Scene()
        {
            Shapes = new List<Shape>();
            Polygons = new List<Polygon>();
            Lines = new List<Line>();
            ShapesUndoRedo = new Stack<Shape>();
            PolygonsUndoRedo = new Stack<Polygon>();
            LineUndoRedo = new Stack<Line>();
            ShapeTypes = new Stack<string>();
            ShapeTypesRedo = new Stack<string>();
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
            CounterOfShapes++;
        }

        public void AddPointToPolygon(Point p)
        {
            CurrentPolygon.AddPointToPolygon(p);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon(this.Thickness);
                CounterOfShapes++;
            }
        }

        public void AddPointToLine(Point point)
        {
            if (!LastPoint.IsEmpty)
            {
                Lines.Add(new Line(LastPoint, point, Color, this.Thickness));
                LastPoint = new Point();
                CounterOfShapes++;
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

        public void LineUndo()
        {
            if (Lines.Count > 0)
            {
                Line l = Lines[Lines.Count - 1];
                LineUndoRedo.Push(l);
                Lines.RemoveAt(Lines.Count - 1);
                if (Lines.Count == 0)
                {
                    LastPoint = Point.Empty;
                }
                else
                {
                    LastPoint = Lines[Lines.Count - 1].Right;
                }
            }
        }

        public void LineRedo()
        {
            if (LineUndoRedo.Count > 0)
            {
                Line l = LineUndoRedo.Pop();
                Lines.Add(l);
                LastPoint = l.Right;
            }
        }

        public void ShapeUndo()
        {
            if (Shapes.Count > 0)
            {
                Shape s = Shapes[Shapes.Count - 1];
                ShapesUndoRedo.Push(s);
                Shapes.RemoveAt(Shapes.Count - 1);
            }
        }

        public void ShapeRedo()
        {
            if (ShapesUndoRedo.Count > 0)
            {
                Shape s = ShapesUndoRedo.Pop();
                Shapes.Add(s);
            }
        }
        public void PolygonUndo()
        {
            if (Polygons.Count > 0)
            {
                Polygon m = Polygons[Polygons.Count - 1];
                PolygonsUndoRedo.Push(m);
                Polygons.RemoveAt(Polygons.Count - 1);
            }
        }

        public void PolygonRedo()
        {
            if (PolygonsUndoRedo.Count > 0)
            {
                Polygon m = PolygonsUndoRedo.Pop();
                Polygons.Add(m);
            }
        }
    }
}
