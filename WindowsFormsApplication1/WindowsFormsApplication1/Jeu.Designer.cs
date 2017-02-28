namespace CasseBrique
{
    partial class Jeu
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
            this.components = new System.ComponentModel.Container();
            this.mouvementBalle = new System.Windows.Forms.Timer(this.components);
            this.balle = new CasseBrique.PictureBoule();
            ((System.ComponentModel.ISupportInitialize)(this.balle)).BeginInit();
            this.SuspendLayout();
            // 
            // mouvementBalle
            // 
            this.mouvementBalle.Interval = 20;
            this.mouvementBalle.Tick += new System.EventHandler(this.mouvementBalle_Tick);
            // 
            // pictureBoule1
            // 
            this.balle.BackColor = System.Drawing.Color.DarkBlue;
            this.balle.Location = new System.Drawing.Point(197, 267);
            this.balle.Name = "pictureBoule1";
            this.balle.Size = new System.Drawing.Size(64, 25);
            this.balle.TabIndex = 0;
            this.balle.TabStop = false;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 641);
            this.Controls.Add(this.balle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jeu_FormClosed);
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Jeu_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Jeu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.balle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mouvementBalle;
        private PictureBoule balle;
    }
}