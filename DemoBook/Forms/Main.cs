using DemoBook.Data;
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

                ShowBooks();
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

        public void ShowBooks()
        {
            using (var context = new DemoBookEntities1())
            {
                flowLayoutPanel.Controls.Clear();

                var books = context.Books.ToList();

                foreach (var book in books)
                {
                    var bookControl = new UserControlBook(book, UserRole);

                    flowLayoutPanel.Controls.Add(bookControl);
                }
            }
        }

        private void ShowGenres()
        {
            using (var context = new DemoBookEntities1())
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

        public void ShowUsers()
        {
            using (var context = new DemoBookEntities1())
            {
                flowLayoutPanel.Controls.Clear();

                var users = context.Users.ToList();

                foreach (var user in users)
                {
                    var userControl = new UserControlUser(user);

                    flowLayoutPanel.Controls.Add(userControl);
                }
            }
        }
        private void добавитьЖанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addGenre = new AddGenre())
            {
                if (addGenre.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Жанр добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowBooks();
                }
            }
        }

        private void списокПользToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }
    }
}
