namespace CasseBrique
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.nomCompte = new System.Windows.Forms.TextBox();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accueilFond = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accueilFond)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1036, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casse-Brique";
            // 
            // lUsername
            // 
            this.lUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lUsername.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.lUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lUsername.Location = new System.Drawing.Point(2, 105);
            this.lUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(109, 20);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Username";
            this.lUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomCompte
            // 
            this.nomCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nomCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomCompte.CausesValidation = false;
            this.nomCompte.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.nomCompte.ForeColor = System.Drawing.SystemColors.Info;
            this.nomCompte.Location = new System.Drawing.Point(18, 125);
            this.nomCompte.Margin = new System.Windows.Forms.Padding(0);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(228, 29);
            this.nomCompte.TabIndex = 1;
            this.nomCompte.Enter += new System.EventHandler(this.nomCompte_Enter);
            this.nomCompte.Leave += new System.EventHandler(this.nomCompte_Leave);
            // 
            // btnInscription
            // 
            this.btnInscription.AutoEllipsis = true;
            this.btnInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnInscription.FlatAppearance.BorderSize = 3;
            this.btnInscription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInscription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnInscription.Location = new System.Drawing.Point(36, 389);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(194, 38);
            this.btnInscription.TabIndex = 4;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnInscription.UseVisualStyleBackColor = false;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            this.btnInscription.MouseEnter += new System.EventHandler(this.btnInscription_MouseEnter);
            this.btnInscription.MouseLeave += new System.EventHandler(this.btnInscription_MouseLeave);
            // 
            // btnConnexion
            // 
            this.btnConnexion.AutoEllipsis = true;
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConnexion.FlatAppearance.BorderSize = 3;
            this.btnConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnConnexion.Location = new System.Drawing.Point(36, 321);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(194, 38);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            this.btnConnexion.MouseEnter += new System.EventHandler(this.btnConnexion_MouseEnter);
            this.btnConnexion.MouseLeave += new System.EventHandler(this.btnConnexion_MouseLeave);
            // 
            // lPassword
            // 
            this.lPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lPassword.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            this.lPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lPassword.Location = new System.Drawing.Point(9, 174);
            this.lPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(89, 20);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "Password";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.SystemColors.Info;
            this.password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password.Location = new System.Drawing.Point(17, 194);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(228, 29);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nomCompte);
            this.panel1.Controls.Add(this.lUsername);
            this.panel1.Controls.Add(this.btnInscription);
            this.panel1.Controls.Add(this.btnConnexion);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.lPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(971, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 659);
            this.panel1.TabIndex = 13;
            this.panel1.TabStop = true;
            // 
            // accueilFond
            // 
            this.accueilFond.Dock = System.Windows.Forms.DockStyle.Left;
            this.accueilFond.Image = global::CasseBrique.Properties.Resources.BrickBreakerFull;
            this.accueilFond.Location = new System.Drawing.Point(0, 0);
            this.accueilFond.Name = "accueilFond";
            this.accueilFond.Size = new System.Drawing.Size(972, 659);
            this.accueilFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accueilFond.TabIndex = 12;
            this.accueilFond.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1225, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accueilFond);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accueilFond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.TextBox nomCompte;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox accueilFond;
        private System.Windows.Forms.Panel panel1;
    }
}