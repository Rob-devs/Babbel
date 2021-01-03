namespace Mini_projet_Babbel
{
    partial class PhraseTrous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhraseTrous));
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.lblTitreCours = new System.Windows.Forms.Label();
            this.lblTitreLecon = new System.Windows.Forms.Label();
            this.lblEnonceActu = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.lblRegle = new System.Windows.Forms.Label();
            this.lblRegleActu = new System.Windows.Forms.Label();
            this.pnlPhrase = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTraducPhrase = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerif
            // 
            this.btnVerif.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button3;
            this.btnVerif.Enabled = false;
            this.btnVerif.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerif.ForeColor = System.Drawing.Color.White;
            this.btnVerif.Location = new System.Drawing.Point(368, 413);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(171, 36);
            this.btnVerif.TabIndex = 19;
            this.btnVerif.Text = "Vérifier";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.BtnVerif_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button3;
            this.btnValider.Enabled = false;
            this.btnValider.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(701, 413);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(171, 36);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnSolution
            // 
            this.btnSolution.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnSolution.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolution.ForeColor = System.Drawing.Color.Black;
            this.btnSolution.Location = new System.Drawing.Point(12, 413);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(171, 36);
            this.btnSolution.TabIndex = 21;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.BtnSolution_Click);
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
            this.lblTitreCours.TabIndex = 30;
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
            this.lblTitreLecon.TabIndex = 33;
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
            this.lblEnonceActu.TabIndex = 35;
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
            this.lblEnonce.TabIndex = 34;
            this.lblEnonce.Text = "Énoncé :";
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegle.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegle.ForeColor = System.Drawing.Color.White;
            this.lblRegle.Location = new System.Drawing.Point(53, 357);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(59, 21);
            this.lblRegle.TabIndex = 36;
            this.lblRegle.Text = "Règle :";
            this.lblRegle.Visible = false;
            // 
            // lblRegleActu
            // 
            this.lblRegleActu.AutoSize = true;
            this.lblRegleActu.BackColor = System.Drawing.Color.Transparent;
            this.lblRegleActu.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegleActu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegleActu.Location = new System.Drawing.Point(109, 357);
            this.lblRegleActu.Name = "lblRegleActu";
            this.lblRegleActu.Size = new System.Drawing.Size(52, 21);
            this.lblRegleActu.TabIndex = 37;
            this.lblRegleActu.Text = "label1";
            // 
            // pnlPhrase
            // 
            this.pnlPhrase.AutoScroll = true;
            this.pnlPhrase.BackColor = System.Drawing.Color.Transparent;
            this.pnlPhrase.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.fondBlanc;
            this.pnlPhrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhrase.Location = new System.Drawing.Point(234, 180);
            this.pnlPhrase.Name = "pnlPhrase";
            this.pnlPhrase.Size = new System.Drawing.Size(432, 167);
            this.pnlPhrase.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTraducPhrase);
            this.panel1.Location = new System.Drawing.Point(144, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 40);
            this.panel1.TabIndex = 39;
            // 
            // lblTraducPhrase
            // 
            this.lblTraducPhrase.BackColor = System.Drawing.Color.Transparent;
            this.lblTraducPhrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTraducPhrase.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraducPhrase.ForeColor = System.Drawing.Color.White;
            this.lblTraducPhrase.Location = new System.Drawing.Point(0, 0);
            this.lblTraducPhrase.Name = "lblTraducPhrase";
            this.lblTraducPhrase.Size = new System.Drawing.Size(612, 40);
            this.lblTraducPhrase.TabIndex = 44;
            this.lblTraducPhrase.Text = "\"traduction\"";
            this.lblTraducPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhraseTrous
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_exercice;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPhrase);
            this.Controls.Add(this.lblRegleActu);
            this.Controls.Add(this.lblRegle);
            this.Controls.Add(this.lblEnonceActu);
            this.Controls.Add(this.lblEnonce);
            this.Controls.Add(this.lblTitreLecon);
            this.Controls.Add(this.lblTitreCours);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnVerif);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PhraseTrous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercice : Phrase à trous";
            this.Load += new System.EventHandler(this.PhraseTrous_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblTitreCours;
        private System.Windows.Forms.Label lblTitreLecon;
        private System.Windows.Forms.Label lblEnonceActu;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Label lblRegle;
        private System.Windows.Forms.Label lblRegleActu;
        private System.Windows.Forms.Panel pnlPhrase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTraducPhrase;
    }
}