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
    public partial class BookImage : Form
    {
        public Book Book { get; set; }
        public BookImage(Book book)
        {
            InitializeComponent();
            this.Book = book;
            pictureBox1.Image = Image.FromFile(Book.ImageURL.ToString());
        }

        private void BookImage_Load(object sender, EventArgs e)
        {

        }
    }
}
