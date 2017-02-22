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
        private int positionX = 254;
        private int positionY = 568;
        public const int longueur = 12;
        public const int largeur = 12;
        public int PositionX { get { return positionX; } set { positionX = value; } }
        public int PositionY { get { return positionY; } set { positionY = value; } }
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

        public void deplacerBalle()
        {

            if( this.positionX < 0 || compteurX == 0)
            {
                compteurX = 0;
                this.positionX += 10;
            }
            if (this.positionX > 492 || compteurX == 1)
            {
                compteurX = 1;
                this.positionX -= 10;
            }
            if (this.positionY >= 600 || compteurY == 0)
            {
                compteurY = 0;
                this.positionY -= 10;
            }
            if (this.positionY <= 0  || compteurY == 1)
            {
                compteurY = 1;
                this.positionY += 10;
            }

        }

    }
}
