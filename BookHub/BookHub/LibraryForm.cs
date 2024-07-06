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
        public SceneLibrary SceneLibrary { get; set; }

        public LibraryForm()
        {
            InitializeComponent();

            dgvBooks.BackgroundColor = Color.Beige;

            SceneLibrary = new SceneLibrary();
            LoadBooks();

            this.Controls.Add(dgvBooks);
            dgvBooks.Dock = DockStyle.Fill;
        }

        private void LoadBooks()
        {
            List<Book> booksToShow = SceneLibrary.ModernLiterature.ToList();
            dgvBooks.AutoGenerateColumns = false;

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Title", ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Author", HeaderText = "Author", ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price",
                ReadOnly = true,
                CellTemplate = new DataGridViewTextBoxCell()
                {
                    Style = new DataGridViewCellStyle { Format = "MKD." }
                }
            });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Quantity", ReadOnly = true });

            DataGridViewButtonColumn imageButtonColumn = new DataGridViewButtonColumn();
            imageButtonColumn.DataPropertyName = "Image";
            imageButtonColumn.Name = "Image";
            imageButtonColumn.HeaderText = "Image";
            imageButtonColumn.Text = "Image";
            imageButtonColumn.UseColumnTextForButtonValue = true;
            dgvBooks.Columns.Add(imageButtonColumn);

            DataGridViewButtonColumn buyButtonColumn = new DataGridViewButtonColumn();
            buyButtonColumn.DataPropertyName = "Buy";
            buyButtonColumn.Name = "Buy";
            buyButtonColumn.HeaderText = "Buy";
            buyButtonColumn.Text = "Buy";
            buyButtonColumn.UseColumnTextForButtonValue = true;
            dgvBooks.Columns.Add(buyButtonColumn);

            DataGridViewButtonColumn returnButtonColumn = new DataGridViewButtonColumn();
            returnButtonColumn.DataPropertyName = "Return";
            returnButtonColumn.Name = "Return";
            returnButtonColumn.HeaderText = "Return";
            returnButtonColumn.Text = "Return";
            returnButtonColumn.UseColumnTextForButtonValue = true;
            dgvBooks.Columns.Add(returnButtonColumn);

            string[] columnNames = { "Title", "Author", "Price", "Quantity", "Image", "Buy", "Return" };
            dgvBooks.Rows.Add(columnNames);

            BindingSource source = new BindingSource();
            source.DataSource = booksToShow;
            dgvBooks.DataSource = source;

            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBooks.Columns["Buy"].Index)
            {
                Book selectedBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;

                BuyForm bookForm = new BuyForm(selectedBook);

                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    dgvBooks.Refresh();
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvBooks.Columns["Return"].Index)
            {
                Book selectedBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;

                ReturnForm bookForm = new ReturnForm(selectedBook);

                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    dgvBooks.Refresh();
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == dgvBooks.Columns["Image"].Index)
            {
                Book selectedBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;

                BookImage bookForm = new BookImage(selectedBook);

                bookForm.ShowDialog();
            }
        }

        private void LoadBooks(string genre)
        {
            List<Book> booksToShow = SceneLibrary.returnList(genre);
            dgvBooks.AutoGenerateColumns = false;

            BindingSource source = new BindingSource();
            source.DataSource = booksToShow;
            dgvBooks.DataSource = source;

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.ShowDialog();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void modernLiteratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("ModernLiterature");
        }

        private void classicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Classics");
        }

        private void dramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Drama");
        }

        private void crimeThrillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("CrimeThriller");
        }

        private void adventureActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("AdventureAction");
        }

        private void romanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Romance");
        }

        private void horrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Horror");
        }

        private void comedyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Comedy");
        }

        private void scienceFictionFantasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("ScienceFictionFantasy");
        }

        private void historicFictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("HistoricFiction");
        }

        private void macedonianPoetryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("MacedonianPoetry");
        }

        private void foreignPoetryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("ForeignPoetry");
        }

        private void travelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Travel");
        }

        private void sportFitnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("SportFitness");
        }

        private void cookbooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Cookbooks");
        }

        private void economyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Economy");
        }

        private void otherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("SocialOther");
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Medicine");
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("ScienceOther");
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Music");
        }

        private void filmThToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("FilmStagecraft");
        }

        private void architectureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("Architecture");
        }

        private void encyclopediaLexiconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("EncyclopediaLexicon");
        }

        private void journalMagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SceneLibrary = new SceneLibrary();
            LoadBooks("JournalMagazine");
        }
    }
}
