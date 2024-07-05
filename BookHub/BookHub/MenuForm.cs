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

        private void btnAboutUS_Click(object sender, EventArgs e)
        {
            string message = "Welcome to our quaint bookstore where we enhance the joy of reading with a delightful twist—by integrating a small game into our online library experience. Within our library, you'll discover a vast array of genres and a rich selection of books within each. Upon launching our application, you're presented with a choice: indulge in entertainment or search for the next addition to your home library shelves.\n\n" +
                "Every activity within our realm offers an opportunity to unwind, allowing you to engage in playful diversion. So, immerse yourself in our game and unleash your imagination. Let reading become not just a pastime, but a journey of discovery and delight.\n\n" +
                "Simeon Ristovski and Dimitar Trposki, students at the Faculty of Computer Science and Engineering (FINKI), proudly present our innovative creation: an online library that seamlessly integrates an engaging game. This concept blossomed during the rigorous preparation for our final exams.\n\n" +
                 "We dedicated our scarce free time to developing an application that is not only fun but also educational, merging enjoyment with learning in your leisure moments.\n\n" +
                 "This application offers more than just entertainment; it provides a convenient way to order your favorite books and have them delivered right to your doorstep. As passionate bibliophiles, we have meticulously selected only the finest and most noteworthy books across various genres, ensuring a collection that embodies excellence and quality.\n\n" +
                 "Our aim is to enrich your reading experience by offering an interactive platform where learning and play go hand in hand. Whether you’re looking to unwind with a captivating book or seek an educational yet entertaining pastime, our application is designed to meet your needs and exceed your expectations. Dive into a world where the joy of reading and the thrill of a game come together to create a unique and fulfilling experience.";

            MessageBox.Show(message, "About Us", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
