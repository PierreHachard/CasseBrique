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
        private Accueil accueil;
        public Point tmp;
        public int hit = 0;
        private int viesRestantes = 3;
        private Bitmap viesImage = new Bitmap(@"..\..\..\coeur.jpg");
        private Bitmap gameOverImg = new Bitmap(@"..\..\..\gameOver.jpg"); //depuis le main.exe
   
        


        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;

            //La balle
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Name = "pictureballe1";
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Name = "pictureBarre1";
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = pictureBarre1.Location;

            int x, y;

            // Loop through the images pixels to reset color.
            for (x = 0; x < viesImage.Width; x++)
            {
                for (y = 0; y < viesImage.Height; y++)
                {
                    Color pixelColor = viesImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                    viesImage.SetPixel(x, y, newColor);
                }
            }
            x = 0;
            y = 0;
            for (x = 0; x < gameOverImg.Width; x++)
            {
                for (y = 0; y < gameOverImg.Height; y++)
                {
                    Color pixelColor = gameOverImg.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                    gameOverImg.SetPixel(x, y, newColor);
                }
            }

            // Set the PictureBox to display the image.
            pictureBox1.Image = viesImage;
            pictureBox2.Image = viesImage;
            pictureBox3.Image = viesImage;
            pictureBox4.Image = gameOverImg;
            pictureBox4.Hide();

            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
        }



        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Show();
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
            //Cursor.Current = null;

            pictureBarre1.deplacerBarre(e.X, this);
            if (mouvementBalle.Enabled == false)
            {
                balle.DeplacerBalleSurPlateau(pictureBarre1);
            }
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {
            if (hit == 0)
                balle.deplacerBalle(collision());
            else
            {
                balle.deplacerBalle(hit);
                hit = 0;
            }

            //Gestion perte de vies
            if (balle.Centre.Y > 600)
            {
                viesRestantes -= 1;
                if (viesRestantes == 2)
                {
                    pictureBox3.Hide();
                    ResetGame();
                }
                if (viesRestantes == 1)
                {
                    pictureBox2.Hide();
                    ResetGame();
                }
                if (viesRestantes == 0)
                {
                    pictureBox1.Hide();
                    GameOver();
                }
            }

        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }

        // retourne un int : 1 si tape le haut
        //                   2 si tape le bas
        //                   3 si tape la gauche
        //                   4 si tape la droite

        public int collision()
        {
            Graphics g;
            g = this.CreateGraphics();
            if (niveau1.ToucherBrique(balle.Centre, ref tmp, niveau1.NumeroNiveau, g))
            {
                if (balle.Centre.Y > tmp.Y && balle.Centre.Y < tmp.Y + 15 && tmp.X + 40 / 2 > balle.Centre.X)
                {
                    hit = 3;
                    return 3;
                }
                if (balle.Centre.Y > tmp.Y && balle.Centre.Y < tmp.Y + 15 && tmp.X + 40 / 2 < balle.Centre.X)
                {
                    hit = 4;
                    return 4;
                }
                if (balle.Centre.X > tmp.X && balle.Centre.X < tmp.X + 40 && tmp.Y + 15 / 2 < balle.Centre.Y)
                {
                    hit = 2;
                    return 2;
                }
                if (balle.Centre.X > tmp.X && balle.Centre.X < tmp.X + 40 && tmp.Y + 15 / 2 > balle.Centre.Y)
                {
                    hit = 1;
                    return 1;
                }
            }
            if ((balle.Centre.Y >= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 && (balle.Centre.Y <= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 + 2)) && ((balle.Centre.X < pictureBarre1.Centre.X + pictureBarre1.Width / 2) && (balle.Centre.X > pictureBarre1.Centre.X - pictureBarre1.Width / 2)))
                return 5;
            return 0;
        }
       /* private int collision(Pictureballe balle, int niveau)
        {
            int i = 0;
            niveau -= 1;
            for (i = 0; i < 25; i++)
            {
                Brick b = niveau1.ListeBrick1[niveau, i];
                if ( b!=null && b.Resistance!=0)
                {
                    Graphics g;
                    g = this.CreateGraphics();
                    if (b.Rect.Contains(new Point(balle.Centre.X + balle.Width / 2, balle.Centre.Y)))
                    {

                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if(tick == 0){
                            b.redessinerBrick(g);
                            niveau1.ListeBrick1[niveau, i] = b;
                            g.Dispose();
                            
                        }
                        return 3;

                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X - 6, balle.Centre.Y)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0)
                        {
                            b.redessinerBrick(g);
                            niveau1.ListeBrick1[niveau, i] = b;                  
                            g.Dispose();
                            
                        }
                        return 4;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y - 6)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0){
                            b.redessinerBrick(g);
                            niveau1.ListeBrick1[niveau, i] = b;
                            g.Dispose();
                            
                        }
                        return 2;
                    }
                    else if (b.Rect.Contains(new Point(balle.Centre.X, balle.Centre.Y + 6)))
                    {
                        g.Clip = new Region(new Rectangle(b.PositionX - 1, b.PositionY - 1, b.Longueur + 2, b.Largeur + 2));
                        if (tick == 0)
                       {
                            b.redessinerBrick(g);
                            niveau1.ListeBrick1[niveau, i] = b;
                            g.Dispose();
                       }
                        return 1;
                    }
                }
            }
            if ((balle.Centre.Y >= pictureBarre1.Centre.Y - pictureBarre1.Height/2 && (balle.Centre.Y <= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 + 2)) && ( (balle.Centre.X < pictureBarre1.Centre.X + pictureBarre1.Width / 2) && (balle.Centre.X > pictureBarre1.Centre.X - pictureBarre1.Width / 2)))
            {
                return 5;
            }
            return 0;
        }*/




        public void ResetGame()
        {
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = pictureBarre1.Location;
            mouvementBalle.Enabled = false;
        }

        public void GameOver()
        {
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = pictureBarre1.Location;
            pictureBox3.Show();
            pictureBox2.Show();
            pictureBox1.Show();
            pictureBox4.Show();
            viesRestantes = 3;
            mouvementBalle.Enabled = false;
            niveau1 = new Niveau(1);
            Refresh();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Hide();
        }

        private void Jeu_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Hide();
            //Cursor.Current = null;
        }

        private void Jeu_MouseLeave(object sender, EventArgs e)
        {
            //Cursor.Show();
            //Cursor.Current = Cursor;
        }
    }
}
