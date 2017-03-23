using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CasseBrique
{
    public class BitmapScore
    {
        private Bitmap[] bitScore = new Bitmap[10];


        //initialise un tableau d'image
        public BitmapScore()
        {
            for(int i =0; i< 10; i++)
            {
                bitScore[i] = new Bitmap(@"..\..\..\bitmapscore\"+ i +".png");
            }
        }


        //Permet l'affiche du score sous un format "retro"
        public void convertToBitmap(int nombre, PictureBox b1, PictureBox b2,PictureBox b3)
        {
            int unite = nombre % 10;
            int dizaine = nombre / 10 % 10;
            int centaine = nombre / 100 % 10;
            int millier = nombre / 1000 % 10;
            if(centaine >= 0)
                b1.Image = bitScore[centaine];
            if( dizaine >= 0)
                b2.Image = bitScore[dizaine];
            if (unite >= 0)
                b3.Image = bitScore[unite];

        }
    }
}
