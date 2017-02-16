namespace WindowsFormsApplication1
{
    partial class InscForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.conButton = new System.Windows.Forms.Button();
            this.InsButton = new System.Windows.Forms.Button();
            this.pseudoTxtB = new System.Windows.Forms.Label();
            this.pwdTxtB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conButton
            // 
            this.conButton.Location = new System.Drawing.Point(38, 173);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(93, 44);
            this.conButton.TabIndex = 0;
            this.conButton.Text = "Connexion";
            this.conButton.UseVisualStyleBackColor = true;
            // 
            // InsButton
            // 
            this.InsButton.Location = new System.Drawing.Point(159, 173);
            this.InsButton.Name = "InsButton";
            this.InsButton.Size = new System.Drawing.Size(93, 44);
            this.InsButton.TabIndex = 1;
            this.InsButton.Text = "Inscription";
            this.InsButton.UseVisualStyleBackColor = true;
            // 
            // pseudoTxtB
            // 
            this.pseudoTxtB.AutoSize = true;
            this.pseudoTxtB.Location = new System.Drawing.Point(50, 48);
            this.pseudoTxtB.Name = "pseudoTxtB";
            this.pseudoTxtB.Size = new System.Drawing.Size(43, 13);
            this.pseudoTxtB.TabIndex = 2;
            this.pseudoTxtB.Text = "Pseudo";
            // 
            // pwdTxtB
            // 
            this.pwdTxtB.AutoSize = true;
            this.pwdTxtB.Location = new System.Drawing.Point(53, 114);
            this.pwdTxtB.Name = "pwdTxtB";
            this.pwdTxtB.Size = new System.Drawing.Size(71, 13);
            this.pwdTxtB.TabIndex = 3;
            this.pwdTxtB.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            // 
            // InscForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pwdTxtB);
            this.Controls.Add(this.pseudoTxtB);
            this.Controls.Add(this.InsButton);
            this.Controls.Add(this.conButton);
            this.Name = "InscForm";
            this.Text = "CasseBrique";
            this.Load += new System.EventHandler(this.InscForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conButton;
        private System.Windows.Forms.Button InsButton;
        private System.Windows.Forms.Label pseudoTxtB;
        private System.Windows.Forms.Label pwdTxtB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

