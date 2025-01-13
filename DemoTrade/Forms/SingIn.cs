using DemoTrade.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoTrade.Forms
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void exbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPass.Text;

            using (var context = new DemoTradeEF())
            {
                var user = context.User
                    .FirstOrDefault
                    (u => u.UserLogin == login &&
                    u.UserPassword == pass);

                if (user == null) return;

                var result = MessageBox.Show($"С возвращенем {user.UserName} {user.UserPatronymic} Роль: {user.Role.RoleName}", "", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {           
                    using (var main = new Main(user))
                    {
                        Hide();
                        if (main.ShowDialog() == DialogResult.Cancel) 
                        {
                            Show();
                        }
                    }
                }
            }
        }
    }
}
