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
        private Barre barre;
        private Balle balle;
        private Accueil accueil;
        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            this.accueil.Visible = false;
            niveau1 = new Niveau(1);
            barre = new Barre(230, 60);
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
            this.barre.dessinerBarre(e.Graphics);
            this.niveau1.dessinerNiveau(e.Graphics);
            this.balle.dessinerBalle(e.Graphics);
        }

        private void Jeu_MouseMove(object sender, MouseEventArgs e)
        {

            // enleève le curseur 
            Cursor.Current = null;
            Graphics g;
            g = this.CreateGraphics();
            // met à jour la position de la barre
            g.Clip = new Region(new Rectangle(barre.PositionX, 580, barre.Longueur, 15));
            this.barre.deplacerBarre(e.X - 30, e.Y);
            g.Clear(Color.White);
            this.barre.dessinerBarre(g);
            g.Dispose();
            //Refresh();
            
        }

        private void mouvementBalle_Tick(object sender, EventArgs e)
        {

            Graphics p;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(balle.PositionX, balle.PositionY,12,12);
            p = this.CreateGraphics();
             // met à jour la position de la balle
            p.Clip = new Region(path);
            p.Clear(Color.White);
            this.balle.deplacerBalle();
            path.Reset();
            path.AddEllipse(balle.PositionX, balle.PositionY, 12, 12);
            p.Clip = new Region(path);
            this.balle.dessinerBalle(p);
            p.Dispose();
        }

        private void Jeu_MouseClick(object sender, MouseEventArgs e)
        {
            mouvementBalle.Enabled = true;
        }
    }
}
