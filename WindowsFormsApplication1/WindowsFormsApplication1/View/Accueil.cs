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

            //Boucle for pour l'affichage de l'image
            /*for (int x = 0; x < accueilFond.Width; x++)
            {
                for (int y = 0; y < accueilFond.Height; y++)
                {
                    Color pixelColor = accueilFond.GetPixel(x, y);
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                    viesImage.SetPixel(x, y, newColor);
                }
            }*/
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
            nomCompte.BackColor = Color.FromArgb(nomCompte.BackColor.R + 30, nomCompte.BackColor.G + 30, nomCompte.BackColor.B + 30);
            nomCompte.BorderStyle = BorderStyle.Fixed3D;
            //lUsername.ForeColor = Color.FromArgb(lUsername.ForeColor.R + 50, lUsername.ForeColor.G + 50, lUsername.ForeColor.B + 50);
        }

        private void nomCompte_Leave(object sender, EventArgs e)
        {
            nomCompte.BackColor = Color.FromArgb(nomCompte.BackColor.R - 30, nomCompte.BackColor.G - 30, nomCompte.BackColor.B - 30);
            nomCompte.BorderStyle = BorderStyle.FixedSingle;
            //lUsername.ForeColor = Color.FromArgb(lUsername.ForeColor.R - 50, lUsername.ForeColor.G - 50, lUsername.ForeColor.B - 50);
        }

        //Password Label (lPassword) and TextField (password) animations
        private void password_Enter(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(password.BackColor.R + 30, password.BackColor.G + 30, password.BackColor.B + 30);
            password.BorderStyle = BorderStyle.Fixed3D;
            lPassword.ForeColor = Color.FromArgb(lPassword.ForeColor.R + 50, lPassword.ForeColor.G + 50, lPassword.ForeColor.B + 50);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            password.BackColor = Color.FromArgb(password.BackColor.R - 30, password.BackColor.G - 30, password.BackColor.B - 30);
            password.BorderStyle = BorderStyle.FixedSingle;
            lPassword.ForeColor = Color.FromArgb(lPassword.ForeColor.R - 50, lPassword.ForeColor.G - 50, lPassword.ForeColor.B - 50);
        }

        private void nomCompte_MouseClick(object sender, MouseEventArgs e)
        {
            /*nomCompte.BackColor = Color.FromArgb(nomCompte.BackColor.R + 30, nomCompte.BackColor.G + 30, nomCompte.BackColor.B + 30);
            nomCompte.BorderStyle = BorderStyle.Fixed3D;
            lUsername.ForeColor = Color.FromArgb(lUsername.ForeColor.R + 50, lUsername.ForeColor.G + 50, lUsername.ForeColor.B + 50);*/
        }


        
    }
}
