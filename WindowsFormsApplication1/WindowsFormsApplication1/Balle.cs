using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Balle
    {
        private int positionX = 265;
        private int positionY = 565;
        public const int longueur = 15;
        public const int largeur = 15;
        public int PositionX { get { return positionX; } set { positionX = value; } }
        public int PositionY { get { return positionY; } set { positionY = value; } }
        public int Longueur { get { return longueur; } }
        public int Largeur { get { return largeur; } }
        public int compteurX = 0;
        public int compteurY = 0;

        public Balle()
        {
        }

        public Balle(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
        }

        public void dessinerBalle(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.DarkBlue), this.positionX, this.positionY, longueur, largeur);
        }

        public void deplacerBalle( int collision)
        {

            if( this.positionX < 0 || compteurX == 0 || collision == 4 ) // vers la droite
            {
                compteurX = 0;
                this.positionX += 5;
            }
            if (this.positionX >= 490 || compteurX == 1 || collision == 3) // vers la gauche
            {
                compteurX = 1;
                this.positionX -= 5;
            }
            if (this.positionY >= 600 || compteurY == 0 || collision == 1) // vers le haut
            {
                compteurY = 0;
                this.positionY -= 5;
            }
            if (this.positionY < 0  || compteurY == 1 || collision == 2) // vers le bas
            {
                compteurY = 1;
                this.positionY += 5;
            }

        }

    }
}
