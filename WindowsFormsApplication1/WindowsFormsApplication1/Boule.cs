using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasseBrique
{
    class Boule
    {
        public static int diametre = 12;
        private Point centre;
        public int compteurX = 0;
        public int compteurY = 0;
        public Point Centre
        {
            get { return centre; }
            set { centre = value; }
        }


        public Boule(Point Centre)
        {
            this.centre = Centre;
        }

        public void dessinerBalle(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(Color.Blue), centre.X - diametre / 2, centre.Y - diametre / 2, diametre, diametre);
        }

        public void deplacerBalle(int collision)
        {

            if (this.centre.X < 0 || compteurX == 0 || collision == 4) // vers la droite
            {
                compteurX = 0;
                this.centre.X += 5;
            }
            if (this.centre.X >= 490 || compteurX == 1 || collision == 3) // vers la gauche
            {
                compteurX = 1;
                this.centre.X -= 5;
            }
            if (this.centre.Y >= 600 || compteurY == 0 || collision == 1) // vers le haut
            {
                compteurY = 0;
                this.centre.Y -= 5;
            }
            if (this.centre.Y < 0 || compteurY == 1 || collision == 2) // vers le bas
            {
                compteurY = 1;
                this.centre.Y += 5;
            }

        }
    }
}
