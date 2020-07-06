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
    public partial class easy : Form
    {
        public easy()
        {
            InitializeComponent();
            moveToStart();
        }

        private void nextLevel(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations, now you are on the second level!!!");
            this.Hide();
            var newForm = new normal();
            newForm.Show();
        }

        private void moveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(70, 35);
            Cursor.Position = PointToScreen(startingPoint);
        }

        int x = 1;
        private void wall(object sender, EventArgs e)
        {


            if (x == 2)
            {
                MessageBox.Show("Last chance to win!!!");
            }
            if (x == 3)
            {
                this.Hide();
                var newForm = new Form5();
                newForm.Show();
                x = 1;
            }
            else
                x++;

            moveToStart();

        }
    }
}
