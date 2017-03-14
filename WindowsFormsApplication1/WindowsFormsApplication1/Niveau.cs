using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CasseBrique
{
    // Cette classe contient tous les différents niveaux avec le positionnement des briques.
    public class Niveau
    {
        private Brick[,] listeBrick = new Brick[3, 25];
        private int numeroNiveau;
        public int NumeroNiveau { get { return numeroNiveau; } }

        public Brick[,] ListeBrick1
        {
            get
            {
                return listeBrick;
            }

            set
            {
                listeBrick = value;
            }
        }

        public Niveau(int niveau)
        {
            this.numeroNiveau = niveau;
            if(this.numeroNiveau ==1) {

                //première ligne
                ListeBrick1[0, 0] = new Brick(30, 20, 3);
                ListeBrick1[0, 1] = new Brick(70, 20, 2);
                ListeBrick1[0, 2] = new Brick(110, 20, 1);
                ListeBrick1[0, 3] = new Brick(150, 20, 2);
                ListeBrick1[0, 4] = new Brick(190, 20, 3);
                ListeBrick1[0, 5] = new Brick(270, 20, 3);
                ListeBrick1[0, 6] = new Brick(310, 20, 2);
                ListeBrick1[0, 7] = new Brick(350, 20, 1);
                ListeBrick1[0, 8] = new Brick(390, 20, 2);
                ListeBrick1[0, 9] = new Brick(430, 20, 3);

                //2eme ligne
                ListeBrick1[0, 10] = new Brick(30, 100, 2);
                ListeBrick1[0, 11] = new Brick(70, 100, 3);
                ListeBrick1[0, 12] = new Brick(150, 100, 3);
                ListeBrick1[0, 13] = new Brick(190, 100, 2);
                ListeBrick1[0, 14] = new Brick(270, 100, 2);
                ListeBrick1[0, 15] = new Brick(310, 100, 3);
                ListeBrick1[0, 16] = new Brick(390, 100, 3);
                ListeBrick1[0, 17] = new Brick(430, 100, 2);

                //3eme ligne
                ListeBrick1[0, 18] = new Brick(70, 200, 1);
                ListeBrick1[0, 19] = new Brick(110, 200, 2);
                ListeBrick1[0, 20] = new Brick(350, 200, 2);
                ListeBrick1[0, 21] = new Brick(390, 200, 1);

                //4eme ligne
                ListeBrick1[0, 22] = new Brick(30, 280, 3);
                ListeBrick1[0, 23] = new Brick(230, 280, 2);
                ListeBrick1[0, 24] = new Brick(430, 280, 3);
            }
            else if (this.numeroNiveau == 2)
            {

                //première ligne
                ListeBrick1[1, 0] = new Brick(130, 20, 1);
                ListeBrick1[1, 1] = new Brick(350, 20, 1);


                //Deuxieme ligne

                ListeBrick1[1, 2] = new Brick(90, 35, 1);
                ListeBrick1[1, 3] = new Brick(170, 35, 1);
                ListeBrick1[1, 4] = new Brick(310, 35, 1);
                ListeBrick1[1, 5] = new Brick(390, 35, 1);


                // Troisième ligne
                ListeBrick1[1, 6] = new Brick(50, 50, 1);
                ListeBrick1[1, 7] = new Brick(210, 50, 1);
                ListeBrick1[1, 8] = new Brick(270, 50, 1);
                ListeBrick1[1, 9] = new Brick(430, 50, 1);

                // Quatrieme ligne
                ListeBrick1[1, 10] = new Brick(50,65, 1);
                ListeBrick1[1, 11] = new Brick(210, 65, 1);
                ListeBrick1[1, 12] = new Brick(270, 65, 1);
                ListeBrick1[1, 13] = new Brick(430, 65, 1);

                //Cinquième ligne 
                ListeBrick1[1, 14] = new Brick(270, 100, 2);
                ListeBrick1[1, 15] = new Brick(310, 100, 3);
                ListeBrick1[1, 16] = new Brick(390, 100, 3);
                ListeBrick1[1, 17] = new Brick(430, 100, 2);

                //3eme ligne
                ListeBrick1[1, 18] = new Brick(70, 200, 1);
                ListeBrick1[1, 19] = new Brick(110, 200, 2);
                ListeBrick1[1, 20] = new Brick(350, 200, 2);
                ListeBrick1[1, 21] = new Brick(390, 200, 1);

                //4eme ligne
                ListeBrick1[1, 22] = new Brick(30, 280, 3);
                ListeBrick1[1, 23] = new Brick(230, 280, 2);
                ListeBrick1[1, 24] = new Brick(430, 280, 3);

            }
            else if (this.numeroNiveau == 3)
            {

            }

        }

        public void dessinerNiveau(Graphics g)
        {
            foreach (Brick b in ListeBrick1)
            {
                if(b != null)
                b.dessinerBrick(g);
            }
        }

        public bool ToucherBrique(Point p, ref Point p1, int niveau, Graphics g)
        {
            bool modif = false;
            niveau--;

            for (int i = 0; i < 25; ++i)
                    if (listeBrick[niveau,i] != null)
                    {
                     Brick b = listeBrick[niveau, i];
                    g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                    if (b.Rect.Contains(new Point(p.X + 4, p.Y))
                            || b.Rect.Contains(new Point(p.X - 4, p.Y))
                            || b.Rect.Contains(new Point(p.X, p.Y - 4))
                            || b.Rect.Contains(new Point(p.X, p.Y + 4)))
                        {
                        p1 = new Point(listeBrick[niveau, i].PositionX , listeBrick[niveau, i].PositionY );
                        if (listeBrick[niveau,i].Resistance == 3)
                            {
                            listeBrick[niveau, i].Resistance--;
                            b.dessinerBrick(g);
                            modif = true;
                            }
                         else if (listeBrick[niveau,i].Resistance == 2)
                            {

                            listeBrick[niveau,i].Resistance--;
                            b.dessinerBrick(g);
                            modif = true;
                            }
                        else
                            {
                                if (listeBrick[0,i].Resistance == 1)
                                {
                                listeBrick[niveau, i].Resistance--;
                                b.dessinerBrick(g);
                                listeBrick[0,i] = null;
                                modif = true;
                                }
                            }

                        }
 
                    }
            g.Dispose();
            return modif;
        }
            
        
    }
}
