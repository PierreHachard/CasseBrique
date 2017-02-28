﻿using System;
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
        private Accueil accueil;
        private Graphics p;
        public int tick = 0;
        public Jeu(Accueil accueil)
        {
            InitializeComponent();

            //La balle
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Name = "pictureBoule1";
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Name = "pictureBarre1";
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = new System.Drawing.Point(265, 580);


            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
           // barre = new Barre(230, 60);
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
            this.niveau1.dessinerNiveau(e.Graphics);
        }

        private void Jeu_MouseMove(object sender, MouseEventArgs e)
        {

            // enlève le curseur 
            Cursor.Current = null;

            pictureBarre1.deplacerBarre(e.X, this);

        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {

            if (collision(balle, 1) != 0)
                tick = 1;
            else
                tick = 0;
            balle.deplacerBalle(collision(balle, 1));

        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }

        // retourne un int : 1 si tape le haut
        //                   2 si tape le bas
        //                   3 si tape la gauche
        //                   4 si tape la droite
        private int collision(PictureBoule balle, int niveau)
        {
            int i = 0;
            niveau -= 1;
            Brick b;
            for (i = 0; i < 25; i++)
            {
                b = niveau1.ListeBrick[niveau, i];
                if (b != null)
                {
                    Graphics g;
                    g = this.CreateGraphics();
                    if (b.Rect.Contains(new Point(balle.Centre.X + balle.Width / 2, balle.Centre.Y)))
                    {

                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if(tick == 0){
                            //b.redessinerBrick(g);
                            if (b.Resistance == 0)
                                niveau1.ListeBrick[niveau, i] = null;
                            b.redessinerBrick(g);
                            g.Dispose();
                            
                        }
                        return 3;

                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X - 6, balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0)
                        {
                            //b.redessinerBrick(g);
                            if (b.Resistance == 0)
                                niveau1.ListeBrick[niveau, i] = null;
                            b.redessinerBrick(g);
                            g.Dispose();
                            
                        }
                        return 4;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y - 6)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0)
                        {
                            //b.redessinerBrick(g);
                            if (b.Resistance == 0)
                                niveau1.ListeBrick[niveau, i] = null;
                            b.redessinerBrick(g);
                            g.Dispose();
                            
                        }
                        return 2;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + 6)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0)
                        {
                            //b.redessinerBrick(g);
                            if (b.Resistance == 0)
                                niveau1.ListeBrick[niveau, i] = null;
                            b.redessinerBrick(g);
                            g.Dispose();
                            
                        }
                        return 1;
                    }
                }
            }
           // if (pictureBarre1.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + 6)))
            //return 5;
            return 0;
        }
    }
}
