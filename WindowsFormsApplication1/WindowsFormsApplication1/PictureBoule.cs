using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasseBrique
{
    class PictureBoule : OvalPictureBox
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

        public PictureBoule()
        {

        }
        /* public void deplacerBalle(int collision)
         {

             if (this.Left < 0 || compteurX == 0 || collision == 4) // vers la droite
             {
                 compteurX = 0;
                 this.Left += 5;
             }
             if (this.Right >= 490 || compteurX == 1 || collision == 3) // vers la gauche
             {
                 compteurX = 1;
                 this.Left -= 5;
             }
             if (this.Top >= 600 || compteurY == 0 || collision == 1 || collision == 5) // vers le haut
             {
                 compteurY = 0;
                 this.Top -= 5;
             }
             if (this.Bottom < 0 || compteurY == 1 || collision == 2) // vers le bas
             {
                 compteurY = 1;
                 this.Top += 5;
             }

         }*/

        public void deplacerBalle(int collision)
        {

            if (Centre.X < 2 || (compteurX == 0 && collision ==0) || collision == 4) // vers la droite
            {
                compteurX = 0;
                Centre =  new Point(this.centre.X + 5, this.centre.Y);
            }
            if (Centre.X >= 490 || (compteurX == 1 && collision ==0) || collision == 3) // vers la gauche
            {
                compteurX = 1;
                Centre = new Point(this.centre.X - 5, this.centre.Y);
            }
            if (this.centre.Y >= 600 || (compteurY == 0 && collision ==0) || collision == 1 || collision == 5) // vers le haut
            {
                compteurY = 0;
                Centre = new Point(this.centre.X, this.centre.Y - 5);
            }
            if (this.centre.Y < 0 || (compteurY == 1 && collision ==0) || collision == 2) // vers le bas
            {
                compteurY = 1;
                Centre = new Point(this.centre.X, this.centre.Y + 5);
            }

        }


    }
}
