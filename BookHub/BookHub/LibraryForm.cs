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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }

        private void crimeThrillerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.ShowDialog();
        }
    }
}
