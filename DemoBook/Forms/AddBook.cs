using DemoBook.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoBook.Forms
{
    public partial class AddBook : Form
    {
        private Books editBook;

        public AddBook(Books editBook = null)
        {
            InitializeComponent();

            GenreAdd();
            this.editBook = editBook;

            if (editBook != null) 
            {
                Text = "Редактрование";
                addBtn.Text = "Редактировать книгу";
                textBoxTitle.Text = editBook.Title;
                textBoxAutor.Text = editBook.Author;
                textBoxYear.Text = editBook.PublishedYear.ToString();
                comboBoxGenre.SelectedValue = editBook.GenreId;
            }
        }

        private void GenreAdd()
        {
            using (var context = new DemoBookEntities1())
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

            using (var context = new DemoBookEntities1()) 
            {
                if (editBook != null)
                {
                    var book = context.Books.Find(editBook.Id);

                    if (book != null)
                    {
                        book.Title = title;
                        book.Author = autor;
                        book.GenreId = genre;
                        book.PublishedYear = year;
                        book.AvailableCopies = copy;
                    }
                }
                else 
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
                }

                context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
