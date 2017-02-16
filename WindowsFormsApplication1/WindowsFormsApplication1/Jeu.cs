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
        private Accueil accueil;
        public Jeu(Accueil accueil)
        {
            InitializeComponent();
            this.accueil = accueil;
            this.accueil.Visible = false;
        }

        private void Jeu_Load(object sender, EventArgs e)
        {

        }

        private void Jeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.accueil.Visible = true;
        }

    }
}
