namespace Mini_projet_Babbel
{
    partial class Grammaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grammaire));
            this.lblTitreCours = new System.Windows.Forms.Label();
            this.lblTitreLecon = new System.Windows.Forms.Label();
            this.lblEnonceActu = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.pnlVerbe = new System.Windows.Forms.Panel();
            this.lblVerbe = new System.Windows.Forms.Label();
            this.pnlVerbe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreCours
            // 
            this.lblTitreCours.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreCours.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCours.ForeColor = System.Drawing.Color.White;
            this.lblTitreCours.Location = new System.Drawing.Point(0, 0);
            this.lblTitreCours.Name = "lblTitreCours";
            this.lblTitreCours.Size = new System.Drawing.Size(884, 30);
            this.lblTitreCours.TabIndex = 37;
            this.lblTitreCours.Text = "Titre Cours";
            this.lblTitreCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitreLecon
            // 
            this.lblTitreLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreLecon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreLecon.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreLecon.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTitreLecon.Location = new System.Drawing.Point(0, 30);
            this.lblTitreLecon.Name = "lblTitreLecon";
            this.lblTitreLecon.Size = new System.Drawing.Size(884, 25);
            this.lblTitreLecon.TabIndex = 38;
            this.lblTitreLecon.Text = "Titre Lecon";
            this.lblTitreLecon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEnonceActu
            // 
            this.lblEnonceActu.AutoSize = true;
            this.lblEnonceActu.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonceActu.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonceActu.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblEnonceActu.Location = new System.Drawing.Point(121, 83);
            this.lblEnonceActu.Name = "lblEnonceActu";
            this.lblEnonceActu.Size = new System.Drawing.Size(52, 21);
            this.lblEnonceActu.TabIndex = 40;
            this.lblEnonceActu.Text = "label1";
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.ForeColor = System.Drawing.Color.White;
            this.lblEnonce.Location = new System.Drawing.Point(54, 83);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(70, 21);
            this.lblEnonce.TabIndex = 39;
            this.lblEnonce.Text = "Énoncé :";
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button2;
            this.btnSuivant.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(701, 413);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(171, 36);
            this.btnSuivant.TabIndex = 41;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // pnlVerbe
            // 
            this.pnlVerbe.BackColor = System.Drawing.Color.Transparent;
            this.pnlVerbe.Controls.Add(this.lblVerbe);
            this.pnlVerbe.Location = new System.Drawing.Point(268, 187);
            this.pnlVerbe.Name = "pnlVerbe";
            this.pnlVerbe.Size = new System.Drawing.Size(364, 86);
            this.pnlVerbe.TabIndex = 42;
            // 
            // lblVerbe
            // 
            this.lblVerbe.BackColor = System.Drawing.Color.Transparent;
            this.lblVerbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerbe.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerbe.ForeColor = System.Drawing.Color.White;
            this.lblVerbe.Location = new System.Drawing.Point(0, 0);
            this.lblVerbe.Name = "lblVerbe";
            this.lblVerbe.Size = new System.Drawing.Size(364, 86);
            this.lblVerbe.TabIndex = 43;
            this.lblVerbe.Text = "Conjugaison du verbe ";
            this.lblVerbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grammaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_exercice;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pnlVerbe);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.lblEnonceActu);
            this.Controls.Add(this.lblEnonce);
            this.Controls.Add(this.lblTitreLecon);
            this.Controls.Add(this.lblTitreCours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grammaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice : Grammaire";
            this.Load += new System.EventHandler(this.Grammaire_Load);
            this.pnlVerbe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreCours;
        private System.Windows.Forms.Label lblTitreLecon;
        private System.Windows.Forms.Label lblEnonceActu;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Panel pnlVerbe;
        private System.Windows.Forms.Label lblVerbe;
    }
}