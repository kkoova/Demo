using DemoBook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBook.Forms
{
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var deskr = textBoxDeck.Text;

            using (var context = new DemoBookEntities1())
            {
                var newGenre = new Genres
                {
                    Name = name,
                    Description = deskr,
                };

                context.Genres.Add(newGenre);
                context.SaveChangesAsync();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
