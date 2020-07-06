using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class hard : Form
    {
        public List<ObstacleConfiguration> obstacleConfigurations;

        public hard()
        {
            InitializeComponent();
            moveToStart();

            System.Timers.Timer moveTimer = new System.Timers.Timer();
            moveTimer.Elapsed += new ElapsedEventHandler(MoveTimeEvent);
            moveTimer.Interval = 50; //milliseconds
            moveTimer.Start();

            obstacleConfigurations = new List<ObstacleConfiguration>()
            {
                new ObstacleConfiguration(label45, MoveDirection.Left, 0, 30, 1),
                new ObstacleConfiguration(label46, MoveDirection.Right, 0, 30, 2),
                new ObstacleConfiguration(label47, MoveDirection.Left, 0, 30, 1),
                new ObstacleConfiguration(label64, MoveDirection.Top, 0, 40, 4),
                new ObstacleConfiguration(label56, MoveDirection.Right, 0, 55, 3),
                new ObstacleConfiguration(label39, MoveDirection.Top, 0, 65, 3),
                new ObstacleConfiguration(label40, MoveDirection.Bottom, 0, 38, 6),
                new ObstacleConfiguration(label41, MoveDirection.Bottom, 0, 260, 11),
                new ObstacleConfiguration(label43, MoveDirection.Right, 0, 130, 6),
                new ObstacleConfiguration(label23, MoveDirection.Bottom, 0, 170, 12)
            };
        }
        private void moveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(35, 29);
            Cursor.Position = PointToScreen(startingPoint);
        }

        public void MoveTimeEvent(object source, ElapsedEventArgs e)
        {
            foreach (var config in obstacleConfigurations)
            {
                MoveObstacle(config);
            }
        }

        private void MoveObstacle(ObstacleConfiguration obstacleConfiguration)
        {
            if (obstacleConfiguration.DistanceMoved < obstacleConfiguration.DistanceEnd)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    var step = obstacleConfiguration.Step;
                    switch (obstacleConfiguration.MoveDirection)
                    {
                        case MoveDirection.Left:
                            obstacleConfiguration.Control.Left -= step;
                            break;
                        case MoveDirection.Right:
                            obstacleConfiguration.Control.Left += step;
                            break;
                        case MoveDirection.Top:
                            obstacleConfiguration.Control.Top -= step;
                            break;
                        case MoveDirection.Bottom:
                            obstacleConfiguration.Control.Top += step;
                            break;
                    }

                    obstacleConfiguration.DistanceMoved += step;
                    
                });
            }
            else
            {
                switch (obstacleConfiguration.MoveDirection)
                {
                    case MoveDirection.Left:
                        obstacleConfiguration.MoveDirection = MoveDirection.Right;
                        break;
                    case MoveDirection.Right:
                        obstacleConfiguration.MoveDirection = MoveDirection.Left;
                        break;
                    case MoveDirection.Top:
                        obstacleConfiguration.MoveDirection = MoveDirection.Bottom;
                        break;
                    case MoveDirection.Bottom:
                        obstacleConfiguration.MoveDirection = MoveDirection.Top;
                        break;
                }
                obstacleConfiguration.DistanceMoved = 0;
            }
        }

        int x = 1;
        private void wall(object sender, EventArgs e)
        {
            if (x == 4)
            {
                MessageBox.Show("Last chance to win!!!");
                x++;
            }
            else if (x == 5)
            {
                this.Hide();
                var newForm = new Form8();
                newForm.Show();
                x = 1;
            }
            else
                x++;

            moveToStart();
        }

        private void moveToChackPoint()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(388, 136);
            Cursor.Position = PointToScreen(startingPoint);
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
                var newForm = new Form8();
                newForm.Show();
                x = 1;
            }
            else
                x++;

            moveToChackPoint();
        }

        private void congrats(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats, You Won!");
            this.Hide();
            var newForm = new Form9();
            newForm.Show();
        }
    }

    public enum MoveDirection
    {
        Left,
        Right,
        Top,
        Bottom
    }

    public class ObstacleConfiguration
    {
        public ObstacleConfiguration(Label control, MoveDirection moveDirection, int distanceStart, int distanceEnd, int step)
        {
            Control = control;
            MoveDirection = moveDirection;
            DistanceMoved = distanceStart;
            DistanceEnd = distanceEnd;
            Step = step;
        }

        public Label Control { get; set; }
        public MoveDirection MoveDirection { get; set; }
        public int DistanceMoved { get; set; }
        public int DistanceEnd { get; set; }
        public int Step { get; set; }
    }
}
