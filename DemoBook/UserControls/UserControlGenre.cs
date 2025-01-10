using System.Windows.Forms;

namespace DemoBook.UserControls
{
    public partial class UserControlGenre : UserControl
    {
        public UserControlGenre()
        {
            InitializeComponent();
        }

        public void SetGenreData(string name, string deck)
        {
            TitleLable.Text = name;
            deckLable.Text = deck;
        }
    }
}
