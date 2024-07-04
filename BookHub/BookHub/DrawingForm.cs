﻿using System;

using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Windows.Forms;

using System.Net.Http;


namespace BookHub
{
    [Serializable]
    public partial class DrawingForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Scene Scene { get; set; }
        public string ShapeType { get; set; } = "CIRCLE";
        public int TimeLeft { get; set; }

        public DrawingForm()
        {
            InitializeComponent();
            Scene = new Scene();
            this.DoubleBuffered = true;
            //timer1.Enabled = true;
            TimeLeft = 300;
            lblTimer.Text = "05:00";
            pbTimeLeft.Value = 100;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string bookTitle = GenerateBookTitle();
            lblBookTitle.Text = bookTitle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Game over!\n Total points won: " + (int)((Scene.CounterOfShapes / 300.0) * 100) + ".");
                this.Close();
            }
            else
            {
                TimeLeft--;

                int minutes = TimeLeft / 60;
                int seconds = TimeLeft % 60;

                lblTimer.Text = $"{minutes}:{seconds}";

                pbTimeLeft.Value = (int)(100.0 * (TimeLeft / 300.0));
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Game over!\n Total points won: " + (int)((Scene.CounterOfShapes / (300.0 - TimeLeft)) * 100) + ".");
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game should be played...");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Scene.ShapeTypes.Count > 0)
            {
                if (Scene.ShapeTypes.Peek().Equals("Shape"))
                {
                    Scene.ShapeUndo();
                }
                else if (Scene.ShapeTypes.Peek().Equals("Line"))
                {
                    Scene.LineUndo();
                }
                else if (Scene.ShapeTypes.Peek().Equals("Polygon"))
                {
                    Scene.PolygonUndo();
                }
                Scene.ShapeTypesRedo.Push(Scene.ShapeTypes.Pop());
            }

            if (Scene.CounterOfShapes > 0)
            {
                lblNumShapes.Text = "Total number of shapes used: " + --Scene.CounterOfShapes;
            }
            pnlDraw.Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Scene.ShapeTypesRedo.Count > 0)
            {
                if (Scene.ShapeTypesRedo.Peek().Equals("Shape"))
                {
                    Scene.ShapeRedo();
                }
                else if (Scene.ShapeTypesRedo.Peek().Equals("Line"))
                {
                    Scene.LineRedo();
                }
                else if (Scene.ShapeTypesRedo.Peek().Equals("Polygon"))
                {
                    Scene.PolygonRedo();
                }
                Scene.ShapeTypes.Push(Scene.ShapeTypesRedo.Pop());
            }


            if (Scene.CounterOfShapes < Scene.Lines.Count + Scene.Shapes.Count + Scene.Polygons.Count)
            {
                lblNumShapes.Text = "Total number of shapes used: " + ++Scene.CounterOfShapes;
            }
            pnlDraw.Invalidate();
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
            /*if (e.Button == MouseButtons.Left)
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

            Invalidate();*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Scene.Draw(e.Graphics);
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
            //Scene.UpdateCursor(e.Location);
            //Scene.Cursor = e.Location;
            //Invalidate();
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
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
            //DoubleBuffered = true;
        }

        private void pnlDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (ShapeType.Equals("CIRCLE"))
                    {
                        Scene.AddShape(new Circle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                        Scene.ShapeTypes.Push("Shape");
                    }
                    else if (ShapeType.Equals("SQUARE"))
                    {
                        Scene.AddShape(new Square(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                        Scene.ShapeTypes.Push("Shape");
                    }
                    else if (ShapeType.Equals("RECTANGLE"))
                    {
                        Scene.AddShape(new Rectangle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                        Scene.ShapeTypes.Push("Shape");
                    }
                    else if (ShapeType.Equals("TRIANGLE"))
                    {
                        Scene.AddShape(new Triangle(Scene.Color, e.Location, Scene.Size, Scene.Thickness));
                        Scene.ShapeTypes.Push("Shape");
                    }
                    else if (ShapeType.Equals("LINE"))
                    {
                        Scene.AddPointToLine(e.Location);
                        Scene.ShapeTypes.Push("Line");
                    }
                    else if (ShapeType.Equals("POLYGON"))
                    {
                        Scene.AddPointToPolygon(e.Location);
                        Scene.ShapeTypes.Push("Polygon");
                    }
                }

                lblNumShapes.Text = "Total number of shapes used: " + Scene.CounterOfShapes;
                pnlDraw.Invalidate();
            }
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            Scene.UpdateCursor(e.Location);
            Scene.Cursor = e.Location;
            pnlDraw.Invalidate();
        }

        private void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Scene);

            fs.Close();
        }

        private void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = (Scene)formatter.Deserialize(fs);

            fs.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene();
            this.DoubleBuffered = true;
            TimeLeft = 300;
            lblTimer.Text = "05:00";
            pbTimeLeft.Value = 100;
            timer1.Enabled = false;
            Scene.CounterOfShapes = 0;
            lblNumShapes.Text = "Total number of shapes: " + Scene.CounterOfShapes;
            Invalidate();
            pnlDraw.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenScene(openFileDialog.FileName);
            }
            Invalidate();
            pnlDraw.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerateBookTitle()
        {
            string[] adjectives = { "Amazing", "Incredible", "Mysterious", "Enchanting", "Fantastic", "Majestic", "Brilliant", "Secret", "Ancient", "Modern" };
            string[] nouns = { "Adventure", "Journey", "Quest", "Saga", "Chronicle", "Tale", "Story", "Mystery", "Legend", "Odyssey" };

            Random random = new Random();
            string adjective = adjectives[random.Next(adjectives.Length)];
            string noun = nouns[random.Next(nouns.Length)];

            return $"{adjective} {noun}";
        }
    }
}