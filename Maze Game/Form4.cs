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
    public partial class normal : Form
    {
        public normal()
        {
            InitializeComponent();
            moveToStart();
        }

        private void nextLevel(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations, now you are on the last level!!!");
            this.Hide();
            var newForm = new hard();
            newForm.Show();
        }

        private void moveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(619, 399);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void moveToChackPoint()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(142, 36);
            Cursor.Position = PointToScreen(startingPoint);
        }

        int x = 1;
        private void wall(object sender, EventArgs e)
        {
            if (x == 3)
            {
                MessageBox.Show("Last chance to win!!!");
                x++;
            }
            else if (x == 4)
            {
                this.Hide();
                var newForm = new Form7();  
                newForm.Show();
                x = 1;
            }
            else
                x++;

            moveToStart();
        }

        private void checkPoint(object sender, EventArgs e)
        {
            if (x == 3)
            {
                MessageBox.Show("Last chance to win!!!");
                x++;
            }
            else if (x == 4)
            {
                this.Hide();
                var newForm = new Form7(); 
                newForm.Show();
                x = 1;
            }
            else
                x++;

            moveToChackPoint();
        }
    }
}
