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
        public int r = 0;
        public int g = 0;
        public int b = 0;
        public int r1 = 0;
        public int g1 = 0;
        public int b1 = 0;
        public int r2 = 0;
        public int g2 = 0;
        public int b2 = 0;
        public int r3 = 0;
        public int g3 = 0;
        public int b3 = 0;


        public Accueil()
        {
            InitializeComponent();
            r = password.BackColor.R;
            g = password.BackColor.G;
            b = password.BackColor.B;
            r1 = lPassword.ForeColor.R;
            g1 = lPassword.ForeColor.G;
            b1 = lPassword.ForeColor.B;
            r2 = nomCompte.BackColor.R;
            g2 = nomCompte.BackColor.G;
            b2 = nomCompte.BackColor.B;
            r3 = lUsername.ForeColor.R;
            g3 = lUsername.ForeColor.G;
            b3 = lUsername.ForeColor.B;
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Jeu formJeu = new Jeu(this);
          /*  IDatabaseInitializer<BddContext> init = new CreateDatabaseIfNotExists<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
            using (IDal dal = new Dal())
            {
                dal.AddUser(new Model_User { Id = 1, Pseudo = "toto" });
            }*/
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
            //Application.Exit();
            // = false;

           // this.Visible = true;
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
            nomCompte.BackColor = Color.FromArgb(r2 + 30, g2 + 30, b2 + 30);
            nomCompte.BorderStyle = BorderStyle.Fixed3D;
            lUsername.ForeColor = Color.FromArgb(r3 + 50, g3 + 50, b3 + 50);
        }

        private void nomCompte_Leave(object sender, EventArgs e)
        {
            nomCompte.BackColor = Color.FromArgb(r2, g2, b2);
            nomCompte.BorderStyle = BorderStyle.FixedSingle;
            lUsername.ForeColor = Color.FromArgb(r3, g3, b3);
        }

        //Password Label (lPassword) and TextField (password) animations
        private void password_Enter(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(r + 30, g + 30, b + 30);
            password.BorderStyle = BorderStyle.Fixed3D;
            lPassword.ForeColor = Color.FromArgb(r1 + 50, g1 + 50, b1 + 50);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(r, g , b);
            password.BorderStyle = BorderStyle.FixedSingle;
            lPassword.ForeColor = Color.FromArgb(r1, g1, b1);
        }

        private void nomCompte_MouseClick(object sender, MouseEventArgs e)
        {
            /*nomCompte.BackColor = Color.FromArgb(nomCompte.BackColor.R + 30, nomCompte.BackColor.G + 30, nomCompte.BackColor.B + 30);
            nomCompte.BorderStyle = BorderStyle.Fixed3D;
            lUsername.ForeColor = Color.FromArgb(lUsername.ForeColor.R + 50, lUsername.ForeColor.G + 50, lUsername.ForeColor.B + 50);*/
        }


        
    }
}
