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
            MessageBox.Show("Симеон и Димитар се студенти на Факултето за информатика и компјутерско инженерство кои се креатори на оваа апликација. Идеата за оваа апликација ја добивме при спремање на нашите завршни испити при што во малото слободно време кое го имавме немаше на што да го потрошеме а да биди тоа забава а во исто време и едукација. Или со други зборови забавна едукација во слободно време. Преку оваа апликација покрај забавата вие ќе можете да ја нарачате вашата посакувана книга и да ја добиете на вашата адреса. Ние како љубители на добрите книги на нашата апликација ги поставивме само оние книги кои сметаме дека се квалитетни и дека се едни од најдобрите од жанрот во кој се напишани.");
        }
    }
}
