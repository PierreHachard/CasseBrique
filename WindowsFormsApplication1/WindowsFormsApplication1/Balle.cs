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

        public Balle()
        {

        }

        public void dessinerBall(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.DarkBlue), this.positionX, this.positionY, longueur, largeur);
        }

    }
}
