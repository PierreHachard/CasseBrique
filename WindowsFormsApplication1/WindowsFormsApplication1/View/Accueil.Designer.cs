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
            this.label2 = new System.Windows.Forms.Label();
            this.nomCompte = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casse-Brique";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(255, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de compte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomCompte
            // 
            this.nomCompte.BackColor = System.Drawing.SystemColors.Window;
            this.nomCompte.Location = new System.Drawing.Point(405, 202);
            this.nomCompte.Name = "nomCompte";
            this.nomCompte.Size = new System.Drawing.Size(428, 20);
            this.nomCompte.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(405, 285);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(428, 20);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(255, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mot de passe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInscription
            // 
            this.btnInscription.AutoEllipsis = true;
            this.btnInscription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscription.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInscription.FlatAppearance.BorderSize = 3;
            this.btnInscription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInscription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInscription.Location = new System.Drawing.Point(703, 406);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(130, 67);
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
            this.btnConnexion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnexion.FlatAppearance.BorderSize = 3;
            this.btnConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnexion.Location = new System.Drawing.Point(255, 406);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(130, 67);
            this.btnConnexion.TabIndex = 9;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            this.btnConnexion.MouseEnter += new System.EventHandler(this.btnConnexion_MouseEnter);
            this.btnConnexion.MouseLeave += new System.EventHandler(this.btnConnexion_MouseLeave);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1225, 659);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nomCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomCompte;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnConnexion;
    }
}