using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    // Cette classe contient tous les différents niveaux avec le positionnement des briques.
    public class Niveau
    {
        private Brick[,] listeBrick = new Brick[3,25];
        private int numeroNiveau;

        public Niveau(int niveau)
        {
            this.numeroNiveau = niveau;
            listeBrick[0, 0] = new Brick(30, 20, 3);
            listeBrick[0, 1] = new Brick(70, 20, 3);
            listeBrick[0, 2] = new Brick(110, 20, 2);
            listeBrick[0, 3] = new Brick(150, 20, 1);
            listeBrick[0, 4] = new Brick(190, 20, 1);
            listeBrick[0, 5] = new Brick(30, 40, 2);
            listeBrick[0, 6] = new Brick(70, 40, 3);
            listeBrick[0, 7] = new Brick(150, 40, 3);
            listeBrick[0, 8] = new Brick(190, 40, 2);
            listeBrick[0, 9] = new Brick(30, 70, 1);
            listeBrick[0, 10] = new Brick(70, 70, 1);
            listeBrick[0, 11] = new Brick(110, 70, 2);
            listeBrick[0, 12] = new Brick(190, 70, 1);
            listeBrick[0, 13] = new Brick(30, 120, 2);
            listeBrick[0, 14] = new Brick(80, 120, 2);
            listeBrick[0, 15] = new Brick(130, 120, 3);
        }

        public void dessinerNiveau(Graphics g)
        {
            foreach (Brick b in listeBrick)
            {
                if(b != null)
                b.dessinerBrick(g);
            }
        }


    }
}
