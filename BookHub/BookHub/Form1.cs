using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public string ShapeType { get; set; } = "CIRCLE";
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            this.DoubleBuffered = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Scene.Color = dlg.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ShapeType.Equals("CIRCLE"))
                {
                    Scene.AddShape(new Circle(Color.Red, e.Location, 20));
                }
                else if (ShapeType.Equals("SQUARE"))
                {
                    Scene.AddShape(new Square(Color.Red, e.Location, 40));
                }
                else if (ShapeType.Equals("RECTANGLE"))
                {
                    Scene.AddShape(new Rectangle(Color.Red, e.Location, 40));
                }
                else if (ShapeType.Equals("TRIANGLE"))
                {
                    Scene.AddShape(new Triangle(Color.Red, e.Location, 40));
                }
                else if (ShapeType.Equals("LINE"))
                {
                    Scene.AddPointToLine(e.Location);
                }
                else if (ShapeType.Equals("POLYGON"))
                {
                    Scene.AddPointToPolygon(e.Location);
                }
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            ShapeType = "CIRCLE";
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            ShapeType = "SQUARE";
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = true;
            lineToolStripMenuItem.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            ShapeType = "RECTANGLE";
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = true;
            polygonToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            ShapeType = "LINE";
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
            polygonToolStripMenuItem.Checked = true;
            triangleToolStripMenuItem.Checked = false;
            ShapeType = "POLYGON";
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
            polygonToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = true;
            ShapeType = "TRIANGLE";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.UpdateCursor(e.Location);
            Scene.Cursor = e.Location;
            Invalidate();
        }
    }
}
