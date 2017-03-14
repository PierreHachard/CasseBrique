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

using CasseBrique.ViewModel;

namespace CasseBrique
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Jeu formJeu = new Jeu(this);
            //formJeu.Show(); 
        }


        private void btnInscription_Click(object sender, EventArgs e)
        {
            //On inscrit l'utilisateur dans la base de données (si son nom de compte n'existe pas déjà)
            ViewModel_User vm_user = new ViewModel_User();
            if (vm_user.IsInBdd(nomCompte.Text) == false)
            {
                vm_user.AddUser(nomCompte.Text, password.Text);
                MessageBox.Show(this, "Inscription réussie", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show(this, "Ce nom d'utilisateur existe déjà", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            //btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
        }

        private void btnInscription_MouseEnter(object sender, EventArgs e)
        {
            btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnInscription.FlatAppearance.BorderSize = 5;
            btnInscription.UseVisualStyleBackColor = true;
        }

        private void btnInscription_MouseLeave(object sender, EventArgs e)
        {
            btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            btnInscription.FlatAppearance.BorderSize = 3;
            btnInscription.UseVisualStyleBackColor = false;
        }

        //Bouton de connexion
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            /*
            //String nomDeCompte = nomCompte.Text;
            Console.WriteLine("Nom de compte : "+nomCompte.Text+", mot de passe : "+password.Text);

            //On vérifie que l'utilisateur/mot de passe appartient à la base de données
            ViewModel_User vm_user = new ViewModel_User();
            if (vm_user.IsInBdd(nomCompte.Text) == false) //le nom de compte n'est pas dans la base
            {
                MessageBox.Show(this, "Ce nom de compte n'existe pas", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (vm_user.IsInBdd(nomCompte.Text, password.Text) == true)
            {
                //si il a pu se connecter
               // Jeu formJeu = new Jeu(this);
                //formJeu.Show(); 
            }
            else
            {
                MessageBox.Show(this, "Le mot de passe ne correspond pas au nom de compte", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            */
            //Application.Exit();
            Jeu formJeu = new Jeu(this);
            formJeu.Show();
            this.Hide();// = false;
            //this.Visible = false;
        }

        private void btnConnexion_MouseLeave(object sender, EventArgs e)
        {
            btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            btnConnexion.FlatAppearance.BorderSize = 3;
            btnConnexion.UseVisualStyleBackColor = false;
        }

        private void btnConnexion_MouseEnter(object sender, EventArgs e)
        {
            btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            btnConnexion.FlatAppearance.BorderSize = 5;
            btnConnexion.UseVisualStyleBackColor = true;
        }


        
    }
}
