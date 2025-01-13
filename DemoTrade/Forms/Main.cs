using DemoTrade.Data;
using System.Windows.Forms;

namespace DemoTrade.Forms
{
    public partial class Main : Form
    {
        private User user;

        public Main(User user = null)
        {
            InitializeComponent();

            this.user = user;
        }
    }
}
