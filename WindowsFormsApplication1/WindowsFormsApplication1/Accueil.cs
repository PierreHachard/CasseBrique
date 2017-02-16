using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //String nomDeCompte = nomCompte.Text;
            Console.WriteLine("Nom de compte : "+nomCompte.Text+", mot de passe : "+password.Text);

            //On vérifie que l'utilisateur/mot de passe appartient à la base de données

            //si il a pu se connecter
            //Application.Exit();
            Jeu formJeu = new Jeu(this);
            formJeu.Show();
            //this.Hide();// = false;
            //this.Visible = false;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            //On inscrit l'utilisateur dans la base de données (si son nom de compte n'existe pas déjà)
            MessageBox.Show(this, "Inscription réussie", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        
    }
}
