using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CasseBrique.ViewModel;

namespace CasseBrique
{

    public partial class Jeu : Form
    {

        public static int BORDER_SIZE = 20;
        private Niveau niveau1;
        private Accueil accueil;
        public Point tmp;
        public BitmapScore scoreb = new BitmapScore();
        public int angle = 5;
        public int score = 0;
        public int niveau = 1;
        public int hit = 0;
        public ViewModel_User vm_user = new ViewModel_User();
        private int viesRestantes = 3;
        private Bitmap viesImage = new Bitmap(@"..\..\..\coeur.jpg");
        private Bitmap gameOverImg = new Bitmap(@"..\..\..\gameOver.jpg"); //depuis le main.exe
   
        


        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.;

            //La balle
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Name = "pictureballe1";
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //label1.Text = "Score : " + score;
            scoreb.convertToBitmap(score, pictureBox5, pictureBox6, pictureBox7);


            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Name = "pictureBarre1";
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = pictureBarre1.Location;

            // Set the PictureBox to display the image.
            pictureBox1.Image = viesImage;
            pictureBox2.Image = viesImage;
            pictureBox3.Image = viesImage;
            pictureBox4.Image = gameOverImg;
            pictureBox4.Hide();

            this.accueil = accueil;
            /*this.accueil.Visible = false;*/
            niveau1 = new Niveau(niveau);
        }

        private void Jeu_Load(object sender, EventArgs e)
        {
            label2.Text = "Highscore : " + Accueil.highscore;
            Cursor.Clip = this.Bounds;
            Cursor.Hide();
        }



        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Show();
            Cursor.Clip = new Rectangle(0,0,50000,50000);
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
            Cursor.Clip = this.Bounds;

            pictureBarre1.deplacerBarre(e.X, this);
            if (mouvementBalle.Enabled == false)
            {
                balle.DeplacerBalleSurPlateau(pictureBarre1);
            }
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {
            if (hit == 0)
                balle.deplacerBalle(collision(), balle, pictureBarre1, ref angle);
            else
            {
                balle.deplacerBalle(hit, balle , pictureBarre1, ref angle);
                hit = 0;
            }
            //label1.Text = "Score : " + score;
            scoreb.convertToBitmap(score, pictureBox5, pictureBox6, pictureBox7);
            if (niveau1.niveauTerminé())
                nextLevel();

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
                score += 5;
                if (balle.Centre.Y > tmp.Y && balle.Centre.Y < tmp.Y + Brick.largeur && tmp.X + Brick.longueur /2 > balle.Centre.X)
                {
                    hit = 3;
                    return 3;
                }
                if (balle.Centre.Y > tmp.Y && balle.Centre.Y < tmp.Y + Brick.largeur && tmp.X + Brick.longueur / 2 < balle.Centre.X)
                {
                    hit = 4;
                    return 4;
                }
                if (balle.Centre.X > tmp.X && balle.Centre.X < tmp.X + Brick.longueur && tmp.Y + Brick.largeur / 2 < balle.Centre.Y)
                {
                    hit = 2;
                    return 2;
                }
                if (balle.Centre.X > tmp.X && balle.Centre.X < tmp.X + Brick.longueur && tmp.Y + Brick.largeur / 2 > balle.Centre.Y)
                {
                    hit = 1;
                    return 1;
                }
            }
            if ((balle.Centre.Y >= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 && (balle.Centre.Y <= pictureBarre1.Centre.Y - pictureBarre1.Height / 2 + 2)) && ((balle.Centre.X < pictureBarre1.Centre.X + pictureBarre1.Width / 2) && (balle.Centre.X > pictureBarre1.Centre.X - pictureBarre1.Width / 2)))
                return 5;
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
            if (Accueil.highscore < score)
            {
                Accueil.highscore = score;
                vm_user.setHighscore(Accueil.username, Accueil.highscore);
                label2.Text = "HighScore :" + Accueil.highscore;
                // rentrer le highscore dans la bdd
            }
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
            niveau =  1;
            niveau1 = new Niveau(niveau);
            score = 0;
            //label1.Text = "Score : " + score;
            scoreb.convertToBitmap(score, pictureBox5, pictureBox6, pictureBox7);
            Refresh();

        }

        public void nextLevel()
        {
            mouvementBalle.Enabled = false;
            balle.Location = new System.Drawing.Point(265, 568);
            balle.Size = new System.Drawing.Size(12, 12);
            balle.Centre = balle.Location;

            //La barre
            pictureBarre1.Location = new System.Drawing.Point(265, 580); //x,y
            pictureBarre1.Size = new System.Drawing.Size(50, 15);
            pictureBarre1.Centre = pictureBarre1.Location;
            if (niveau == 3)
                niveau = 1;
            else
            niveau++;
            niveau1 = new Niveau(niveau);
            Refresh();
        }



        private void pictureBox4_Click_1(object sender, EventArgs e)
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
