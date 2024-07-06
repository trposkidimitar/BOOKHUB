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
    public partial class ReturnForm : Form
    {
        public Book Book { get; set; }
        public ReturnForm(Book book)
        {
            InitializeComponent();
            this.Book = book;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0 && tbAddress.Text.Length > 0 && tbNumber.Text.Length > 0 && tbQuantity.Text.Length > 0)
            {
                Book.Quantity += Convert.ToInt32(tbQuantity.Text);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Thank you for your return.\nSee you next time.");
                this.Close();
            }
        }
    }
}
