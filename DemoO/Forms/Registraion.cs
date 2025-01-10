using DemoO;
using DemoO.Forms;
using DemoO.Models;
using DemoOne.Entity;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DemoOne.Forms
{
    public partial class Registraion : Form
    {
        readonly AuthService authService = new AuthService();

        public Registraion()
        {
            InitializeComponent();
        }

        private void Validating_txt(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTxt.Text))
            { errorProvider1.SetError(loginTxt, "Введите логин!"); }

            if (string.IsNullOrEmpty(PassTxt.Text))
            { errorProvider1.SetError(PassTxt, "Введите пароль!"); }
        }

        private void AvtoBtn_Click(object sender, EventArgs e)
        {
            var user = authService.Authenticate(loginTxt.Text, PassTxt.Text);

            if (user != null) 
            {
                var Main = new Main(user.UserName, user.UserSurname, user.RoleName);
                Main.Show();
            } 
            else { }
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            var Main = new Main(null, null, "Анонимный");
            Main.Show();
        }
    }
}
