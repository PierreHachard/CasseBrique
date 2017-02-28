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
        private Barre barre;
        private Accueil accueil;
        private Graphics p;

        public Jeu(Accueil accueil)
        {
            InitializeComponent();

            balle.Location = new System.Drawing.Point(265, 565);
            balle.Name = "pictureBoule1";
            balle.Size = new System.Drawing.Size(12, 12);
            balle.TabIndex = 0;
            balle.TabStop = false;


            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
            barre = new Barre(230, 60);
            p = this.CreateGraphics();
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
            this.barre.dessinerBarre(e.Graphics);
            this.niveau1.dessinerNiveau(e.Graphics);
        }

        private void Jeu_MouseMove(object sender, MouseEventArgs e)
        {

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
            
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {
            balle.deplacerBalle(collision(balle,1));
        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }

        // retourne un int : 1 si tape en haut
        //                   2 si tape le bas
        //                   3 si tape la gauche
        //                   4 si tape la droite
        private int collision( PictureBoule balle, int niveau)
        {
            int i = 0;
            niveau -= 1;
            Brick b;
            for (i = 0; i < 25; i++)
            {
                b = niveau1.ListeBrick[niveau, i];
                if (b!= null)
                {
                    Graphics g;
                    g = this.CreateGraphics();
                    if (b.Rect.Contains(new Point(balle.Centre.X + Boule.diametre / 2, balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        b.redessinerBrick(g);
                        if (b.Resistance == 0)
                            niveau1.ListeBrick[niveau, i] = null;
                        g.Dispose();
                        return 3;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X - Boule.diametre / 2, balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        b.redessinerBrick(g);
                        if (b.Resistance == 0)
                            niveau1.ListeBrick[niveau, i] = null;
                        g.Dispose();
                        return 4;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y - Boule.diametre / 2)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        b.redessinerBrick(g);
                        if (b.Resistance == 0)
                            niveau1.ListeBrick[niveau, i] = null;
                        g.Dispose();
                        return 2;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + Boule.diametre / 2)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        b.redessinerBrick(g);
                        if (b.Resistance == 0)
                            niveau1.ListeBrick[niveau, i] = null;
                        g.Dispose();
                        return 1;
                    }
                }
            }
            if (barre.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + Boule.diametre / 2)))
            {
                return 5;
            }
            return 0;
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
