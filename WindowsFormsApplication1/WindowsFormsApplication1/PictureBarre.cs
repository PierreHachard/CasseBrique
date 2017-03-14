using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasseBrique
{
    class PictureBarre : System.Windows.Forms.PictureBox
    {
        private Point centre;
        public Point Centre
        {
            get { return centre; }
            set { centre = value;
            this.Top = centre.Y - this.Height / 2;
            this.Left = centre.X - this.Width / 2;

            }
        }

        /// <summary>
        /// Constructeur vide qui permet d'instancier l'objet en passant par l'interface graphique visualstudio
        /// </summary>
        public PictureBarre()
        {

        }

        public void deplacerBarre(int sourisX, Jeu j)
        {
            if (sourisX <= this.Width/2)
                Centre = new Point(this.Width / 2, this.centre.Y);
            else if (sourisX >= j.Size.Width - this.Width/2)
                Centre = new Point(j.Size.Width - this.Width / 2, this.centre.Y);
            else
            {
                Centre = new Point(sourisX, this.centre.Y);
            }
        }

        public int angleRenvoieBalle(Pictureballe balle)
        {
            Point p0 = this.centre;
            Point p1 = new Point(this.centre.X + 5, this.centre.Y);
            Point p2 = new Point(this.centre.X + 10, this.centre.Y);
            Point p3 = new Point(this.centre.X + 15, this.centre.Y);
            Point p4 = new Point(this.centre.X + 20, this.centre.Y);
            Point p5 = new Point(this.centre.X + 25, this.centre.Y);
            Point p6 = new Point(this.centre.X - 5, this.centre.Y);
            Point p7 = new Point(this.centre.X - 15, this.centre.Y);
            Point p8 = new Point(this.centre.X - 20, this.centre.Y);
            Point p9 = new Point(this.centre.X - 25, this.centre.Y);
            if (balle.Centre.X > p0.X && balle.Centre.X < p1.X )
            {
                return 10;
            }
            if (balle.Centre.X > p1.X && balle.Centre.X < p2.X )
            {
                return 9;
            }
            if (balle.Centre.X > p2.X && balle.Centre.X < p3.X )
            {
                return 8;
            }
            if (balle.Centre.X > p3.X && balle.Centre.X < p4.X )
            {
                return 7;
            }
            if (balle.Centre.X > p4.X && balle.Centre.X < p5.X )
            {
                return 6;
            }
            if (balle.Centre.X > p6.X && balle.Centre.X < p0.X )
            {
                return 5;
            }
            if (balle.Centre.X > p7.X && balle.Centre.X < p6.X )
            {
                return 6;
            }
            if (balle.Centre.X > p8.X && balle.Centre.X < p7.X )
            {
                return 7;
            }
            if (balle.Centre.X > p9.X && balle.Centre.X < p8.X )
            {
                return 8;
            }
            return 5;
        }
    }


}
