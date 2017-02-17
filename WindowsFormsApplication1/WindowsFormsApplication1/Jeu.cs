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
            this.balle.dessinerBall(e.Graphics);
        }

        private void Jeu_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            this.barre.deplacerBarre(e.X, e.Y);
            this.barre.dessinerBarre(g);
            //Refresh();
            
        }
    }
}
