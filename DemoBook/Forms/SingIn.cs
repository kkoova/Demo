using DemoBook.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoBook.Forms
{
    public partial class SingIn : Form
    {
        public string Username { get; private set; }
        public string Role { get; private set; }
        public SingIn()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Username = loginTxtBox.Text;
            var Password = passTxtBox.Text;

            using (var context = new DemoBookEntities1())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Username == Username && u.Password == Password);

                if (user != null)
                {
                    Role = user.Role;

                    MessageBox.Show($"Добро пожаловать! {user.Username} Роль: {user.Role}");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не правильный логин или пароль!");
                }
            }
        }
    }
}
