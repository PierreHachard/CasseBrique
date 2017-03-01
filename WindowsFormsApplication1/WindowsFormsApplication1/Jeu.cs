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
        private Accueil accueil;
        public int tick = 0;
        private int viesRestantes = 3;
        private Bitmap viesImage =  new Bitmap(@"C:\Users\maxim\Source\Repos\CasseBrique2\WindowsFormsApplication1\coeur.jpg");
        private Bitmap gameOverImg = new Bitmap(@"C:\Users\maxim\Source\Repos\CasseBrique2\WindowsFormsApplication1\gameOver.jpg");
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
            if (mouvementBalle.Enabled == false)
            {
                balle.DeplacerBalleSurPlateau(pictureBarre1);
            }
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {

            if (collision(balle, 1) != 0)
                tick = 1;
            else
                tick = 0;
            balle.deplacerBalle(collision(balle, 1));
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
            //if (pictureBarre1.Contains(new Point(balle.Centre.X, balle.Centre.Y + balle.Width / 2)))
              //  return 5;
            if ((balle.Centre.Y >= pictureBarre1.Centre.Y - pictureBarre1.Height/2 && (balle.Centre.Y <= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 + 2)) && ( (balle.Centre.X < pictureBarre1.Centre.X + pictureBarre1.Width / 2) && (balle.Centre.X > pictureBarre1.Centre.X - pictureBarre1.Width / 2)))
            {
                return 5;
            }
            return 0;
        }

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
    }
}
