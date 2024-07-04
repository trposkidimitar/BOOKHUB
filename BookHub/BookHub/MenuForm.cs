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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.ShowDialog();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
