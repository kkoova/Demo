using DemoBook.Data;
using DemoBook.Forms;
using System.Windows.Forms;

namespace DemoBook.UserControls
{
    public partial class UserControlBook : UserControl
    {
        public Books BookData { get; set; }
        public UserControlBook(Books book, string role)
        {
            InitializeComponent();
            BookData = book;
            SetBookData();

            if (role == "Admin")
            {
                toolStripEdit.Visible = true;
            }
        }

        public void SetBookData()
        {
            TitleLable.Text = BookData.Title;
            autorLable.Text = BookData.Author;
            genreTextox.Text = BookData.Genres.Name;
            yearTextBox.Text = BookData.PublishedYear.ToString();
            copiiLable.Text = BookData.AvailableCopies.ToString();
        }

        private void toolStripButtonEdit_Click(object sender, System.EventArgs e)
        {
            using (var editBook = new AddBook(BookData))
            {
                if (editBook.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new DemoBookEntities1())
                    {
                        BookData = context.Books.Find(BookData.Id);
                        SetBookData();
                    }
                }
            }
        }

        private void toolStripButtonDelite_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить эту книгу?", "Удаление", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                using (var context = new DemoBookEntities1()) 
                {
                    var book = context.Books.Find(BookData.Id);

                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }
    }
}
