using DemoBook.Data;
using System.Windows.Forms;

namespace DemoBook.UserControls
{
    public partial class UserControlUser : UserControl
    {
        private Users user { get; set; }
        public UserControlUser(Users user)
        {
            InitializeComponent();

            this.user = user;
            SetUser();
        }

        private void SetUser()
        {
            textBoxLofin.Text = user.Username;
            textBoxRole.Text = user.Role;
        }
    }
}
