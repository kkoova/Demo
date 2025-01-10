using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoOne.Forms
{
    public partial class Registraion : Form
    {
        public Registraion()
        {
            InitializeComponent();
        }

        private void Validating_txt(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(loginTxt.Text))
            { errorProvider1.SetError(loginTxt, "Введите логин!"); }

            if (String.IsNullOrEmpty(PassTxt.Text))
            { errorProvider1.SetError(PassTxt, "Введите пароль!"); }
        }
    }
}
