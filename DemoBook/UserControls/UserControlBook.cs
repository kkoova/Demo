using System.Windows.Forms;

namespace DemoBook.UserControls
{
    public partial class UserControlBook : UserControl
    {
        public UserControlBook()
        {
            InitializeComponent();
        }

        public void SetBookData(string title, string author, string genre, int year, int copy)
        {
            TitleLable.Text = title;
            autorLable.Text = author;
            genreTextox.Text = genre;
            yearTextBox.Text = year.ToString();
            copiiLable.Text = copy.ToString();
        }
    }
}
