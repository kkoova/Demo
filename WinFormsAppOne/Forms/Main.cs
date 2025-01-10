using WinFormsAppOne.Useront;

namespace WinFormsAppOne.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        private void ShowTovar_Click(object sender, System.EventArgs e)
        {
            var myUserControl = new TovarControl();
            flowLayoutTovar.Controls.Add(myUserControl);
        }
    }
}
