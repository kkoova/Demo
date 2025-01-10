using DemoBook.UserControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoBook.Forms
{
    public partial class Main : Form
    {
        private string UserLogin;
        private string UserRole;
        public Main()
        {
            InitializeComponent();
            EnableMenuBtn("Гость");
        }

        private void EnableMenuBtn(string Role)
        {
            switch (Role)
            {
                case ("Гость"):
                    break;
                case ("Admin"):
                    сдачаToolStripMenuItem.Enabled = true;
                    историяАрендыКнигToolStripMenuItem.Enabled = true;
                    добавитьКнигуToolStripMenuItem.Enabled = true;
                    добавитьЖанрToolStripMenuItem.Enabled = true;
                    списокПользToolStripMenuItem.Enabled = true;
                    break;
                case ("User"):
                    сдачаToolStripMenuItem.Enabled = true;
                    историяАрендыКнигToolStripMenuItem.Enabled = true;
                    добавитьКнигуToolStripMenuItem.Enabled = false;
                    добавитьЖанрToolStripMenuItem.Enabled = false;
                    списокПользToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var loginForm = new SingIn())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    UserLogin = loginForm.Username;
                    UserRole = loginForm.Role;

                    toolStripStatusLabelUser.Text = $"Добро пожаловать, {UserLogin} Роль: {UserRole}!";

                    EnableMenuBtn(UserRole);
                }
                else
                {
                    MessageBox.Show("Вы не авторизовались", "Гость", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBooks();
        }

        private void жанрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGenres();
        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addBook = new AddBook())
            {
                if (addBook.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Книга добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowBooks();
                }
            }
        }

        private void ShowBooks()
        {
            using (var context = new DemoBookEntities())
            {
                flowLayoutPanel.Controls.Clear();

                var books = context.Books.ToList();

                foreach (var book in books)
                {
                    var bookControl = new UserControlBook();

                    bookControl.SetBookData(
                        title: book.Title,
                        author: book.Author,
                        genre: book.Genres.Name,
                        year: book.PublishedYear,
                        copy: book.AvailableCopies
                    );

                    flowLayoutPanel.Controls.Add(bookControl);
                }
            }
        }

        private void ShowGenres()
        {
            using (var context = new DemoBookEntities())
            {
                flowLayoutPanel.Controls.Clear();

                var Genres = context.Genres.ToList();

                foreach (var genre in Genres)
                {
                    var genreControl = new UserControlGenre();

                    genreControl.SetGenreData
                        (
                            name: genre.Name,
                            deck: genre.Description
                        );

                    flowLayoutPanel.Controls.Add(genreControl);
                }
            }
        }
    }
}
