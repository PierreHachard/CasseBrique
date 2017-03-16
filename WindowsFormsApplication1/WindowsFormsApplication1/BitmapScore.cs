using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CasseBrique
{
    class BitmapScore
    {
        private Bitmap[] bitScore = new Bitmap[10];

        BitmapScore()
        {
            for(int i =0; i< 10; i++)
            {
                bitScore[i] = new Bitmap(@"..\..\..\bitmapscore\"+ i +".png");
            }
        }

        public void convertToBitmap(int nombre, PictureBox b1, PictureBox b2,PictureBox b3)
        {
            int unite = nombre % 10;
            int dizaine = nombre / 10 % 10;
            int centaine = nombre / 100 % 10;
            int millier = nombre / 1000 % 10;
            if(centaine > 0)
                b1.Image = bitScore[centaine - 1];
            if( dizaine > 0)
                b2.Image = bitScore[dizaine - 1];
            if (dizaine > 0)
                b3.Image = bitScore[unite - 1];

        }
    }
}
