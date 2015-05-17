using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame.Icons
{
    public partial class GenericIcon : UserControl
    {
        public GenericIcon()
        {
            InitializeComponent();
        }
        public int Speed { get; private set; }
        public int VelocityX { get; private set; }
        public int VelocityY { get; private set; }

        public void SetVelocity(int x, int y, int speed)
        {
            Speed = speed;
            int xdir = -1;
            int ydir = -1;
            if (x > 0)
            {
                xdir = 1;
            }
            if (y > 0)
            {
                ydir = 1;
            }
            double angle = Math.Atan(((double)y) / ((double)x));
            VelocityX = xdir * Math.Abs((int)(speed * Math.Cos(angle)));
            VelocityY = ydir * Math.Abs((int)(speed * Math.Sin(angle)));
        }

        public bool CheckCollision(GenericIcon icon)
        {
            return (checkCorner(icon.Left, icon.Top) || checkCorner(icon.Right, icon.Top) || checkCorner(icon.Left, icon.Bottom) || checkCorner(icon.Right, icon.Bottom));
        }

        private bool checkCorner(int x, int y)
        {
            return ((x >= this.Left) && (x <= this.Right) && (y >= this.Top) && (y <= this.Bottom));
        }
        public bool MoveIcon(PictureBox levelMap)
        {
            if ((this.Left > 0) && (this.Left < levelMap.Width) && (this.Top > 0) && (this.Top < levelMap.Height))
            {
                this.Left += this.VelocityX;
                this.Top += this.VelocityY;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
