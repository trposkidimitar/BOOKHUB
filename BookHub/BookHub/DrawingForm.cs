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
    public partial class DrawingForm : Form
    {
        public Scene Scene { get; set; }
        public string ShapeType { get; set; } = "CIRCLE";
        public DrawingForm()
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
                    Scene.AddShape(new Circle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                }
                else if (ShapeType.Equals("SQUARE"))
                {
                    Scene.AddShape(new Square(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                }
                else if (ShapeType.Equals("RECTANGLE"))
                {
                    Scene.AddShape(new Rectangle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                }
                else if (ShapeType.Equals("TRIANGLE"))
                {
                    Scene.AddShape(new Triangle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
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

        private void DrawingForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            Scene.Size = Convert.ToInt32(toolStripMenuItem2.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            Scene.Size = Convert.ToInt32(toolStripMenuItem3.Text);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            Scene.Size = Convert.ToInt32(toolStripMenuItem4.Text);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem6.Checked = false;
            Scene.Size = Convert.ToInt32(toolStripMenuItem5.Text);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = true;
            Scene.Size = Convert.ToInt32(toolStripMenuItem6.Text);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text.Length > 0)
            {
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem4.Checked = false;
                toolStripMenuItem5.Checked = false;
                toolStripMenuItem6.Checked = false;
                Scene.Size = Convert.ToInt32(toolStripTextBox1.Text);
            }
            else
            {
                Scene.Size = 30;
                toolStripMenuItem4.Checked = true;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = true;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;
            Scene.Thickness = Convert.ToInt32(toolStripMenuItem7.Text);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = true;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;
            Scene.Thickness = Convert.ToInt32(toolStripMenuItem8.Text);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = true;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = false;
            Scene.Thickness = Convert.ToInt32(toolStripMenuItem9.Text);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = true;
            toolStripMenuItem11.Checked = false;
            Scene.Thickness = Convert.ToInt32(toolStripMenuItem10.Text);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem9.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem11.Checked = true;
            Scene.Thickness = Convert.ToInt32(toolStripMenuItem11.Text);

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text.Length > 0)
            {
                toolStripMenuItem7.Checked = false;
                toolStripMenuItem8.Checked = false;
                toolStripMenuItem9.Checked = false;
                toolStripMenuItem10.Checked = false;
                toolStripMenuItem11.Checked = false;
                Scene.Thickness = Convert.ToInt32(toolStripTextBox2.Text);
            }
            else
            {
                Scene.Thickness = 3;
                toolStripMenuItem9.Checked = true;
            }
            Invalidate();
        }
    }
}