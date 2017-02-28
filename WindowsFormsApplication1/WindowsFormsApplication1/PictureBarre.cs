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
            Centre = new Point(sourisX,this.centre.Y);
            if (sourisX < this.Width/2)
                Centre = new Point(this.Width / 2, this.centre.Y);
            else if (sourisX > j.Size.Width - this.Width/2)
                Centre = new Point(j.Size.Width - this.Width / 2, this.centre.Y);
        }

    }
}
