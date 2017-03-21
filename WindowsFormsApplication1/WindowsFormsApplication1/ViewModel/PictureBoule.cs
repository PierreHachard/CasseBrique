using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasseBrique
{
    class Pictureballe : OvalPictureBox
    {
        public int compteurX = 0;
        public int compteurY = 0;
        private Point centre;
        public Point Centre
        {
            get { return centre; }
            set {
                centre = value;
                this.Top = centre.Y - this.Width /2 ;
                this.Left = centre.X - this.Width / 2; }
        }

        public Pictureballe()
        {

        }


        public void deplacerBalle(int collision,Pictureballe balle, PictureBarre barre , ref int angle)
        {
            if (Centre.X < 2 || (compteurX == 0 && collision ==0) || collision == 4) // vers la droite
            {
                compteurX = 0;
                this.centre.X += angle;
                if (Centre.X >= 490)
                    compteurX = 1;
                
            }
            else if (Centre.X >= 490 || (compteurX == 1 && collision ==0) || collision == 3) // vers la gauche
            {
                compteurX = 1;
                this.centre.X -= angle;  
                if (Centre.X < 2)
                    compteurX = 0;
            }
            if ((compteurY == 0 && collision ==0) || collision == 1 || collision == 5) // vers le haut
            {
                compteurY = 0;
                Centre = new Point(this.centre.X, this.centre.Y - 5);
                if (collision == 5)
                    angle = barre.angleRenvoieBalle(balle);
                if (Centre.Y < 0)
                    compteurY= 1;
            }
            else if (this.centre.Y < 0 || (compteurY == 1 && collision ==0) || collision == 2) // vers le bas
            {
                compteurY = 1;
                Centre = new Point(this.centre.X, this.centre.Y + 5);
            }
        }

        public void DeplacerBalleSurPlateau(PictureBarre plateau)
        {
            Centre = new Point(plateau.Centre.X, plateau.Centre.Y - plateau.Height/2 - this.Height/2 + 1);
        }



    }
}
