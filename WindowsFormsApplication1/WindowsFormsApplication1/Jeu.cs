using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasseBrique
{
    public partial class Jeu : Form
    {
        private Niveau niveau1;
        //private Barre barre;
        private Boule balle;
        private Accueil accueil;
        private Graphics p;

        private Plateau plateau;

        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
            //barre = new Barre(230, 60);
            plateau = new Plateau(230, 60, 100, this.Bottom - this.Bottom / 10);
            balle = new Boule(new Point(265,565));
            p = this.CreateGraphics();

            this.testPlateau = new Plateau();
            ((System.ComponentModel.ISupportInitialize)(this.testPlateau)).BeginInit();
            // 
            // testPlateau
            // 
            this.testPlateau.BackColor = System.Drawing.Color.DarkGray;
            this.testPlateau.Location = new System.Drawing.Point(115, 579);
            this.testPlateau.Name = "testPlateau";
            this.testPlateau.Size = new System.Drawing.Size(262, 16);
            this.testPlateau.TabIndex = 0;
            this.testPlateau.TabStop = false;
        }


        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.accueil.Visible = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //this.barre.dessinerBarre(e.Graphics);
            this.niveau1.dessinerNiveau(e.Graphics);
            this.balle.dessinerBalle(e.Graphics);
        }

        private void Jeu_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            // enleève le curseur 
            Cursor.Current = null;
            Graphics g;
            g = this.CreateGraphics();
            // met à jour la position de la barre
            g.Clip = new Region(new Rectangle(barre.PositionX, barre.PositionY, barre.Longueur, barre.Largeur ));
            this.barre.deplacerBarre(e.X - barre.Longueur/2, e.Y);
            g.Clear(Color.White);
            this.barre.dessinerBarre(g);
            g.Dispose();
            //Refresh();*/
            
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {
            // efface la balle précédente et la redessine à sa nouvelle position
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(balle.Centre.X - Boule.diametre / 2, balle.Centre.Y - Boule.diametre / 2, Boule.diametre, Boule.diametre);
             // met à jour la position de la balle
            p.Clip = new Region(path);
            p.Clear(Color.White);
            this.balle.deplacerBalle(collision(balle));
             path.Reset();
             path.AddEllipse(balle.Centre.X - Boule.diametre / 2, balle.Centre.Y - Boule.diametre / 2, Boule.diametre, Boule.diametre);
             p.Clip = new Region(path);
             this.balle.dessinerBalle(p);
        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }

        // retourne un int : 1 si tape en haut
        //                   2 si tape le bas
        //                   3 si tape la gauche
        //                   4 si tape la droite
        private int collision( Boule balle)
        {
            int i = 0;
            foreach (Brick b in niveau1.ListeBrick)
            {
                if (b != null) {
                    i++;
                    /* if ((balle.Centre.Y + Boule.diametre/2 <= b.PositionY + 2 && balle.Centre.Y + Boule.diametre / 2 >= b.PositionY - 2) && (balle.Centre.X - Boule.diametre / 2 <= b.PositionX + b.Longueur && balle.Centre.X + Boule.diametre/2 >= b.PositionX))
                      {
                         Graphics g;
                          g = this.CreateGraphics();
                          g.Clip = new Region( new Rectangle(b.PositionX -1 , b.PositionY-1, b.Longueur+1,b.Largeur+1));
                          b.redessinerBrick(g);
                          g.Dispose();
                          return 1; // vers le haut
                      }
                       if ((balle.Centre.Y + Boule.diametre / 2 <= b.PositionY + b.Largeur  + 2 && balle.Centre.Y + Boule.diametre / 2 >= b.PositionY + b.Largeur - 2) && (balle.Centre.X - Boule.diametre / 2 <= b.PositionX + b.Longueur && balle.Centre.X + Boule.diametre + Boule.diametre / 2 >= b.PositionX))
                      {
                          Graphics g;
                          g = this.CreateGraphics();
                          g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                          b.redessinerBrick(g);
                          g.Dispose();
                          return 2; // vers le bas
                      }
                       if ((balle.Centre.X + Boule.diametre / 2 <= b.PositionX + 2 && balle.Centre.X + Boule.diametre / 2 >= b.PositionX - 2) && (balle.Centre.Y + Boule.diametre / 2 >= b.PositionY && balle.Centre.Y - Boule.diametre/2 <= b.PositionY + b.Largeur))
                      {
                         Graphics g;
                          g = this.CreateGraphics();
                          g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                          b.redessinerBrick(g);
                          g.Dispose();
                          return 3; // vers la gauche
                      }
                      if ((balle.Centre.X + Boule.diametre / 2 <= b.PositionX + b.Largeur + 2 && balle.Centre.X + Boule.diametre / 2 >= b.PositionY + b.Largeur - 2) && (balle.Centre.Y + Boule.diametre / 2 >= b.PositionY && balle.Centre.Y - Boule.diametre / 2 <= b.PositionY + b.Largeur))
                      {
                          Graphics g;
                          g = this.CreateGraphics();
                          g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                          b.redessinerBrick(g);
                          g.Dispose();
                          return 4; // vers la droite
                      }*/

                    Graphics g;
                    g = this.CreateGraphics();
                    if (b.Rect.Contains(new Point(balle.Centre.X + Boule.diametre / 2,balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 3;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X - Boule.diametre / 2, balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 4;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y - Boule.diametre / 2)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 2;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + Boule.diametre / 2)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 1, b.Largeur + 1));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 1;
                    }


                }
            }

            return 0;
        }

    }
}
