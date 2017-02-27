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
        private Brick[,] listeBrick = new Brick[3, 25];
        private int numeroNiveau;
        public Brick[,] ListeBrick { get { return listeBrick;  } }

        public Niveau(int niveau)
        {
            this.numeroNiveau = niveau;
            if(this.numeroNiveau ==1) {

                //première ligne
                listeBrick[0, 0] = new Brick(30, 20, 3);
                listeBrick[0, 1] = new Brick(70, 20, 2);
                listeBrick[0, 2] = new Brick(110, 20, 1);
                listeBrick[0, 3] = new Brick(150, 20, 2);
                listeBrick[0, 4] = new Brick(190, 20, 3);
                listeBrick[0, 5] = new Brick(270, 20, 3);
                listeBrick[0, 6] = new Brick(310, 20, 2);
                listeBrick[0, 7] = new Brick(350, 20, 1);
                listeBrick[0, 8] = new Brick(390, 20, 2);
                listeBrick[0, 9] = new Brick(430, 20, 3);

                //2eme ligne
                listeBrick[0, 10] = new Brick(30, 100, 2);
                listeBrick[0, 11] = new Brick(70, 100, 3);
                listeBrick[0, 12] = new Brick(150, 100, 3);
                listeBrick[0, 13] = new Brick(190, 100, 2);
                listeBrick[0, 14] = new Brick(270, 100, 2);
                listeBrick[0, 15] = new Brick(310, 100, 3);
                listeBrick[0, 16] = new Brick(390, 100, 3);
                listeBrick[0, 17] = new Brick(430, 100, 2);

                //3eme ligne
                listeBrick[0, 18] = new Brick(70, 200, 1);
                listeBrick[0, 19] = new Brick(110, 200, 2);
                listeBrick[0, 20] = new Brick(350, 200, 2);
                listeBrick[0, 21] = new Brick(390, 200, 1);

                //4eme ligne
                listeBrick[0, 22] = new Brick(30, 280, 3);
                listeBrick[0, 23] = new Brick(230, 280, 2);
                listeBrick[0, 24] = new Brick(430, 280, 3);
            }
            else if (this.numeroNiveau == 2)
            {

            }
            else if (this.numeroNiveau == 3)
            {

            }

        }

        public void dessinerNiveau(Graphics g)
        {
            foreach (Brick b in listeBrick)
            {
                if(b != null)
                b.dessinerBrick(g);
            }
        }

        public void setList(int i, int j, Brick b)
        { listeBrick[i, j] = b; }

    }
}
