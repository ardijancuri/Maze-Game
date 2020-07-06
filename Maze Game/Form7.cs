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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void closeGame(object sender, EventArgs e)
        {
            Close();
        }

        private void tryAgain(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new normal();
            newForm.Show();
        }
    }
}
