using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tryAgain(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new easy();
            newForm.Show();
        }

        private void closeGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}
