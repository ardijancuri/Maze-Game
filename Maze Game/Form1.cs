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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void game_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form2();
            newForm.Show();
          
        }

        private void controls_Click(object sender, EventArgs e)
        {
            var newForm = new controls();
            newForm.Show();
        }

        private void credits_Click(object sender, EventArgs e)
        {
            var newForm = new credits();
            newForm.Show();
        }
    }
}
