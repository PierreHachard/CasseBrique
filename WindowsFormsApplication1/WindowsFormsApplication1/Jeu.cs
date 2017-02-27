using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Jeu : Form
    {
        private Niveau niveau1;
        //private Barre barre;
        private Barre2 barre;
        private Balle balle;
        private Accueil accueil;
        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
            //barre = new Barre(230, 60);
            barre = new Barre2(new Point(100,100));
            balle = new Balle();
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
            //Refresh();
             * */
            Cursor.Current = null;
            
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {
            // efface la balle précédente et la redessine à sa nouvelle position
            Graphics p;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(balle.PositionX, balle.PositionY,balle.Longueur,balle.Largeur);
            p = this.CreateGraphics();
             // met à jour la position de la balle
            p.Clip = new Region(path);
            p.Clear(Color.White);
            this.balle.deplacerBalle(collision(balle));
            path.Reset();
            path.AddEllipse(balle.PositionX, balle.PositionY, balle.Longueur, balle.Largeur);
            p.Clip = new Region(path);
            this.balle.dessinerBalle(p);
            p.Dispose();
        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }

        // retourne un int : 1 si tape en haut
        //                   2 si tape le bas
        //                   3 si tape la gauche
        //                   4 si tape la droite
        private int collision( Balle balle)
        {
            foreach (Brick b in niveau1.ListeBrick)
            {
                if (b != null) {
                   if (balle.PositionY + balle.Largeur == b.PositionY && (balle.PositionX + balle.Largeur / 2 <= b.PositionX + b.Longueur && balle.PositionX + balle.Largeur / 2 >= b.PositionX))
                    {
                        Graphics g;
                        g = this.CreateGraphics();
                        g.Clip = new Region( new Rectangle(b.PositionX , b.PositionY, b.Longueur,b.Largeur));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 1;
                    }
                     if (balle.PositionY == b.PositionY + b.Largeur && (balle.PositionX <= b.PositionX + b.Longueur && balle.PositionX >= b.PositionX))
                    {
                        Graphics g;
                        g = this.CreateGraphics();
                        g.Clip = new Region(new Rectangle(b.PositionX, b.PositionY, b.Longueur, b.Largeur));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 2;
                    }
                     if (balle.PositionX + balle.Largeur == b.PositionX && (balle.PositionY + balle.Largeur / 2 >= b.PositionY && balle.PositionY + balle.Largeur / 2 <= b.PositionY + b.Largeur))
                    {
                        Graphics g;
                        g = this.CreateGraphics();
                        g.Clip = new Region(new Rectangle(b.PositionX, b.PositionY, b.Longueur, b.Largeur));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 3;
                    }
                    if (balle.PositionX == b.PositionX + b.Longueur && (balle.PositionY + balle.Largeur/2 >= b.PositionY && balle.PositionY + b.Largeur / 2 <= b.PositionY + b.Largeur))
                    {
                        Graphics g;
                        g = this.CreateGraphics();
                        g.Clip = new Region(new Rectangle(b.PositionX, b.PositionY, b.Longueur, b.Largeur));
                        b.redessinerBrick(g);
                        g.Dispose();
                        return 4;
                    }

                }
            }

            return 0;
        }

    }
}
