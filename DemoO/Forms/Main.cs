using DemoO.Useront;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DemoO.Forms
{
    public partial class Main : Form
    {
        public Main(string Name = null, string SurName = null, string Role = null)
        {
            InitializeComponent();

            NameUserPol.Text = $"{Name} {SurName}";
            PravaRole(Role);

            flowLayoutTovar.WrapContents = false;
            flowLayoutTovar.FlowDirection = FlowDirection.TopDown;
        }

        public void PravaRole(string Role)
        {
            AllEnFalse();

            switch (Role)
            {
                case "Администратор":
                    AddZakaz.Enabled = true;
                    EditZakaz.Enabled = true;
                    DeliteTovar.Enabled = true;
                    EditTovar.Enabled = true;
                    AddTovar.Enabled = true;
                    ShoZakaz.Enabled = true;
                    break;
                case "Пользователь":
                    AddZakaz.Enabled = true;
                    break;
                case "Менеджер":
                    AddZakaz.Enabled = true;
                    EditZakaz.Enabled = true;
                    break;
                case "Гость":
                    break;
            }
        }

        public void AllEnFalse()
        {
            AddTovar.Enabled = false;
            EditTovar.Enabled = false;
            DeliteTovar.Enabled = false;
            AddZakaz.Enabled = false;
            EditZakaz.Enabled = false;
            ShoZakaz.Enabled = false;
        }

        private void ShowTovar_Click(object sender, System.EventArgs e)
        {
            TovarControl myUserControl = new TovarControl();
            flowLayoutTovar.Controls.Add(myUserControl);
        }
    }
}
