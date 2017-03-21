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
using CasseBrique.Model;
using CasseBrique.ViewModel;
using System.Data.Entity;

namespace CasseBrique
{
    public partial class Accueil : Form
    {
        public static string username;
        public static int highscore;
        
        //Textfield password
        private int rPassword;
        private int gPassword;
        private int bPassword;

        //label password
        private int rLPassword;
        private int gLPassword;
        private int bLPassword;

        //Textfield Nomcompte
        private int rNomCompte;
        private int gNomCompte;
        private int bNomCompte;

        //label username
        private int rLUsername;
        private int gLUsername;
        private int bLUsername;


        public Accueil()
        {
            InitializeComponent();
            rPassword = password.BackColor.R;
            gPassword = password.BackColor.G;
            bPassword = password.BackColor.B;
            rLPassword = lPassword.ForeColor.R;
            gLPassword = lPassword.ForeColor.G;
            bLPassword = lPassword.ForeColor.B;
            rNomCompte = nomCompte.BackColor.R;
            gNomCompte = nomCompte.BackColor.G;
            bNomCompte = nomCompte.BackColor.B;
            rLUsername = lUsername.ForeColor.R;
            gLUsername = lUsername.ForeColor.G;
            bLUsername = lUsername.ForeColor.B;
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Jeu formJeu = new Jeu(this); 
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
        }

        //Bouton de connexion
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Jeu formJeu = new Jeu(this);
            //String nomDeCompte = nomCompte.Text;
            Console.WriteLine("Nom de compte : "+nomCompte.Text+", mot de passe : "+password.Text);

            //On vérifie que l'utilisateur/mot de passe appartient à la base de données
            ViewModel_User vm_user = new ViewModel_User();
            if (vm_user.IsInBdd(nomCompte.Text) == false) //le nom de compte n'est pas dans la base
            {
                MessageBox.Show(this, "Ce nom de compte n'existe pas", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Show();
            }
            else if (vm_user.IsInBdd(nomCompte.Text, password.Text) == true)
            {
                //si il a pu se connecter
                Accueil.highscore = vm_user.getHighscore(nomCompte.Text);
                Accueil.username = nomCompte.Text;
                formJeu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Le mot de passe ne correspond pas au nom de compte", "Casse-Brique", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Show();
            }
        }

        //Bouton connexion
        private void btnConnexion_MouseEnter(object sender, EventArgs e)
        {
            btnConnexion.FlatAppearance.BorderColor = Color.FromArgb(btnConnexion.FlatAppearance.BorderColor.R + 5, btnConnexion.FlatAppearance.BorderColor.G + 5, btnConnexion.FlatAppearance.BorderColor.B + 5);
            btnConnexion.FlatAppearance.BorderSize = 4;
            btnConnexion.UseVisualStyleBackColor = true;
        }

        private void btnConnexion_MouseLeave(object sender, EventArgs e)
        {
            btnConnexion.FlatAppearance.BorderColor = Color.FromArgb(btnConnexion.FlatAppearance.BorderColor.R - 5, btnConnexion.FlatAppearance.BorderColor.G - 5, btnConnexion.FlatAppearance.BorderColor.B - 5);
            btnConnexion.FlatAppearance.BorderSize = 3;
            btnConnexion.UseVisualStyleBackColor = false;
        }

        //Bouton Inscription
        private void btnInscription_MouseEnter(object sender, EventArgs e)
        {
            btnInscription.FlatAppearance.BorderColor = Color.FromArgb(btnInscription.FlatAppearance.BorderColor.R + 5, btnInscription.FlatAppearance.BorderColor.G + 5, btnInscription.FlatAppearance.BorderColor.B + 5);
            btnInscription.FlatAppearance.BorderSize = 4;
            btnInscription.UseVisualStyleBackColor = true;
        }

        private void btnInscription_MouseLeave(object sender, EventArgs e)
        {
            btnInscription.FlatAppearance.BorderColor = Color.FromArgb(btnInscription.FlatAppearance.BorderColor.R - 5, btnInscription.FlatAppearance.BorderColor.G - 5, btnInscription.FlatAppearance.BorderColor.B - 5);
            btnInscription.FlatAppearance.BorderSize = 3;
            btnInscription.UseVisualStyleBackColor = false;
        }
        

        //Username Label (lUsername) and TextField (nomCompte) animations
        private void nomCompte_Enter(object sender, EventArgs e)
        {
            nomCompte.BackColor = Color.FromArgb(rNomCompte + 30, gNomCompte + 30, bNomCompte + 30);
            nomCompte.BorderStyle = BorderStyle.Fixed3D;
            lUsername.ForeColor = Color.FromArgb(rLUsername + 50, gLUsername + 50, bLUsername + 50);
        }

        private void nomCompte_Leave(object sender, EventArgs e)
        {
            nomCompte.BackColor = Color.FromArgb(bNomCompte, bNomCompte, bNomCompte);
            nomCompte.BorderStyle = BorderStyle.FixedSingle;
            lUsername.ForeColor = Color.FromArgb(rLUsername, gLUsername, bLUsername);
        }

        //Password Label (lPassword) and TextField (password) animations
        private void password_Enter(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(rPassword + 30, gPassword + 30, bPassword + 30);
            password.BorderStyle = BorderStyle.Fixed3D;
            lPassword.ForeColor = Color.FromArgb(rLPassword + 50, gLPassword + 50, bLPassword + 50);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(rPassword, gPassword, bPassword);
            password.BorderStyle = BorderStyle.FixedSingle;
            lPassword.ForeColor = Color.FromArgb(rLPassword, gLPassword, bLPassword);
        }



        
    }
}
