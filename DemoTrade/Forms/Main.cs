using DemoTrade.Data;
using System.Windows.Forms;

namespace DemoTrade.Forms
{
    public partial class Main : Form
    {
        private readonly User user;

        public Main(User user = null)
        {
            InitializeComponent();

            this.user = user;

            ShowCurentFunc();
            ShowUser();
        }

        private void ShowUser()
        {
            toolStripStatusLabelUser.Text = $"С возвращенем {user.UserName} " +
                $"{user.UserPatronymic} " +
                $"Роль: {user.Role.RoleName}";
        }

        private void ShowCurentFunc()
        {
            switch (user.Role.RoleName)
            {
                case ("Администратор"):
                    addTovarToolStripMenuItem.Visible = true;
                    addZakToolStripMenuItem.Visible = true;
                    showToolStripMenuItem.Visible = true;
                    break;
                case ("Пользователь"):
                    addZakToolStripMenuItem.Visible = true;
                    break ;
                case ("Менеджер"):
                    addZakToolStripMenuItem.Visible = true;
                    showToolStripMenuItem.Visible = true;
                    break;
            }
        }

        private void showTovarToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
