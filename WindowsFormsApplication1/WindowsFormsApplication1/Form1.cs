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
    public partial class Form1 : Form
    {
        private Barre barre = new Barre(60, 70);
        private Brick brick = new Brick(30, 50, 3);
        private Brick brick1 = new Brick(70, 50, 2);
        private Brick brick2 = new Brick(110, 50, 1);
        private Niveau niveau1 = new Niveau(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /*  this.barre.dessinerBarre(e.Graphics);
              this.brick.dessinerBrick(e.Graphics);
              this.brick1.dessinerBrick(e.Graphics);
              this.brick2.dessinerBrick(e.Graphics);*/
            this.niveau1.dessinerNiveau(e.Graphics);
        }

    }
}
