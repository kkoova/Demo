using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBook.Forms
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();

            GenreAdd();
        }

        private void GenreAdd()
        {
            using (var context = new DemoBookEntities())
            {
                var genres = context.Genres.ToList();
                comboBoxGenre.DataSource = genres;
                comboBoxGenre.DisplayMember = "Name";
                comboBoxGenre.ValueMember = "Id";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var title = textBoxTitle.Text;
            var autor = textBoxAutor.Text;
            var year = Convert.ToInt16(textBoxYear.Text);
            var copy = Convert.ToInt16(domainUpDownCopy.Text);
            var genre = Convert.ToInt16(comboBoxGenre.SelectedValue);

            using (var context = new DemoBookEntities()) 
            {
                var newBook = new Books
                {
                    Title = title,
                    Author = autor,
                    PublishedYear = year,
                    AvailableCopies = copy,
                    GenreId = genre,
                };

                context.Books.Add(newBook);
                context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
