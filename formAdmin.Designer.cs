namespace Mini_projet_Babbel
{
    partial class formAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdmin));
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.cboLecons = new System.Windows.Forms.ComboBox();
            this.lblTitreCours = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.pnlTitreExo = new System.Windows.Forms.Panel();
            this.lblNumeroExo = new System.Windows.Forms.Label();
            this.btnRetourPlus = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAvancerPlus = new System.Windows.Forms.Button();
            this.btnAvancer = new System.Windows.Forms.Button();
            this.pnlExo = new System.Windows.Forms.Panel();
            this.pnlPhrase = new System.Windows.Forms.Panel();
            this.lblDetailsExo = new System.Windows.Forms.Label();
            this.lblEnonceActu = new System.Windows.Forms.Label();
            this.lblEnonce = new System.Windows.Forms.Label();
            this.lblRegleActu = new System.Windows.Forms.Label();
            this.lblRegle = new System.Windows.Forms.Label();
            this.pnlTitreExo.SuspendLayout();
            this.pnlExo.SuspendLayout();
            this.pnlPhrase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(50, 116);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(252, 24);
            this.cboCours.TabIndex = 0;
            this.cboCours.SelectedIndexChanged += new System.EventHandler(this.CboLecons_SelectedIndexChanged);
            // 
            // cboLecons
            // 
            this.cboLecons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecons.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLecons.FormattingEnabled = true;
            this.cboLecons.Location = new System.Drawing.Point(598, 116);
            this.cboLecons.Name = "cboLecons";
            this.cboLecons.Size = new System.Drawing.Size(252, 24);
            this.cboLecons.TabIndex = 1;
            this.cboLecons.SelectedIndexChanged += new System.EventHandler(this.CboLecons_SelectedIndexChanged);
            // 
            // lblTitreCours
            // 
            this.lblTitreCours.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreCours.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCours.ForeColor = System.Drawing.Color.White;
            this.lblTitreCours.Location = new System.Drawing.Point(0, 0);
            this.lblTitreCours.Name = "lblTitreCours";
            this.lblTitreCours.Size = new System.Drawing.Size(884, 66);
            this.lblTitreCours.TabIndex = 32;
            this.lblTitreCours.Text = "Administration";
            this.lblTitreCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Transparent;
            this.btnFermer.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnFermer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Black;
            this.btnFermer.Location = new System.Drawing.Point(701, 413);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(171, 36);
            this.btnFermer.TabIndex = 33;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCours.Location = new System.Drawing.Point(46, 92);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(59, 21);
            this.lblCours.TabIndex = 37;
            this.lblCours.Text = "Cours :";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLecon.Location = new System.Drawing.Point(594, 92);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(60, 21);
            this.lblLecon.TabIndex = 38;
            this.lblLecon.Text = "Leçon :";
            // 
            // pnlTitreExo
            // 
            this.pnlTitreExo.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitreExo.Controls.Add(this.lblNumeroExo);
            this.pnlTitreExo.Location = new System.Drawing.Point(208, 159);
            this.pnlTitreExo.Name = "pnlTitreExo";
            this.pnlTitreExo.Size = new System.Drawing.Size(484, 33);
            this.pnlTitreExo.TabIndex = 39;
            // 
            // lblNumeroExo
            // 
            this.lblNumeroExo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroExo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroExo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroExo.ForeColor = System.Drawing.Color.White;
            this.lblNumeroExo.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroExo.Name = "lblNumeroExo";
            this.lblNumeroExo.Size = new System.Drawing.Size(484, 33);
            this.lblNumeroExo.TabIndex = 38;
            this.lblNumeroExo.Text = "Exercice 1/12";
            this.lblNumeroExo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetourPlus
            // 
            this.btnRetourPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRetourPlus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRetourPlus.FlatAppearance.BorderSize = 3;
            this.btnRetourPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetourPlus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourPlus.Location = new System.Drawing.Point(50, 151);
            this.btnRetourPlus.Name = "btnRetourPlus";
            this.btnRetourPlus.Size = new System.Drawing.Size(50, 50);
            this.btnRetourPlus.TabIndex = 40;
            this.btnRetourPlus.Text = "<<";
            this.btnRetourPlus.UseVisualStyleBackColor = false;
            this.btnRetourPlus.Click += new System.EventHandler(this.BtnRetourPlus_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRetour.FlatAppearance.BorderSize = 3;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(115, 151);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(50, 50);
            this.btnRetour.TabIndex = 41;
            this.btnRetour.Text = "<";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // btnAvancerPlus
            // 
            this.btnAvancerPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAvancerPlus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAvancerPlus.FlatAppearance.BorderSize = 3;
            this.btnAvancerPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancerPlus.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancerPlus.Location = new System.Drawing.Point(800, 151);
            this.btnAvancerPlus.Name = "btnAvancerPlus";
            this.btnAvancerPlus.Size = new System.Drawing.Size(50, 50);
            this.btnAvancerPlus.TabIndex = 42;
            this.btnAvancerPlus.Text = ">>";
            this.btnAvancerPlus.UseVisualStyleBackColor = false;
            this.btnAvancerPlus.Click += new System.EventHandler(this.BtnAvancerPlus_Click);
            // 
            // btnAvancer
            // 
            this.btnAvancer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAvancer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAvancer.FlatAppearance.BorderSize = 3;
            this.btnAvancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancer.Location = new System.Drawing.Point(735, 151);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(50, 50);
            this.btnAvancer.TabIndex = 43;
            this.btnAvancer.Text = ">";
            this.btnAvancer.UseVisualStyleBackColor = false;
            this.btnAvancer.Click += new System.EventHandler(this.BtnAvancer_Click);
            // 
            // pnlExo
            // 
            this.pnlExo.BackColor = System.Drawing.Color.Transparent;
            this.pnlExo.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.fondBlanc;
            this.pnlExo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExo.Controls.Add(this.pnlPhrase);
            this.pnlExo.Controls.Add(this.lblEnonceActu);
            this.pnlExo.Controls.Add(this.lblEnonce);
            this.pnlExo.Controls.Add(this.lblRegleActu);
            this.pnlExo.Controls.Add(this.lblRegle);
            this.pnlExo.Location = new System.Drawing.Point(50, 209);
            this.pnlExo.Name = "pnlExo";
            this.pnlExo.Size = new System.Drawing.Size(800, 187);
            this.pnlExo.TabIndex = 44;
            // 
            // pnlPhrase
            // 
            this.pnlPhrase.Controls.Add(this.lblDetailsExo);
            this.pnlPhrase.Location = new System.Drawing.Point(62, 54);
            this.pnlPhrase.Name = "pnlPhrase";
            this.pnlPhrase.Size = new System.Drawing.Size(676, 68);
            this.pnlPhrase.TabIndex = 44;
            // 
            // lblDetailsExo
            // 
            this.lblDetailsExo.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailsExo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailsExo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsExo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDetailsExo.Location = new System.Drawing.Point(0, 0);
            this.lblDetailsExo.Name = "lblDetailsExo";
            this.lblDetailsExo.Size = new System.Drawing.Size(676, 68);
            this.lblDetailsExo.TabIndex = 39;
            this.lblDetailsExo.Text = "texte détails exo";
            this.lblDetailsExo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnonceActu
            // 
            this.lblEnonceActu.AutoSize = true;
            this.lblEnonceActu.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonceActu.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonceActu.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblEnonceActu.Location = new System.Drawing.Point(73, 10);
            this.lblEnonceActu.Name = "lblEnonceActu";
            this.lblEnonceActu.Size = new System.Drawing.Size(52, 21);
            this.lblEnonceActu.TabIndex = 43;
            this.lblEnonceActu.Text = "label1";
            // 
            // lblEnonce
            // 
            this.lblEnonce.AutoSize = true;
            this.lblEnonce.BackColor = System.Drawing.Color.Transparent;
            this.lblEnonce.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnonce.ForeColor = System.Drawing.Color.White;
            this.lblEnonce.Location = new System.Drawing.Point(6, 10);
            this.lblEnonce.Name = "lblEnonce";
            this.lblEnonce.Size = new System.Drawing.Size(70, 21);
            this.lblEnonce.TabIndex = 42;
            this.lblEnonce.Text = "Énoncé :";
            // 
            // lblRegleActu
            // 
            this.lblRegleActu.AutoSize = true;
            this.lblRegleActu.BackColor = System.Drawing.Color.Transparent;
            this.lblRegleActu.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegleActu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegleActu.Location = new System.Drawing.Point(62, 152);
            this.lblRegleActu.Name = "lblRegleActu";
            this.lblRegleActu.Size = new System.Drawing.Size(52, 21);
            this.lblRegleActu.TabIndex = 41;
            this.lblRegleActu.Text = "label1";
            // 
            // lblRegle
            // 
            this.lblRegle.AutoSize = true;
            this.lblRegle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegle.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegle.ForeColor = System.Drawing.Color.White;
            this.lblRegle.Location = new System.Drawing.Point(6, 152);
            this.lblRegle.Name = "lblRegle";
            this.lblRegle.Size = new System.Drawing.Size(59, 21);
            this.lblRegle.TabIndex = 40;
            this.lblRegle.Text = "Règle :";
            this.lblRegle.Visible = false;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_exercice;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pnlExo);
            this.Controls.Add(this.btnAvancer);
            this.Controls.Add(this.btnAvancerPlus);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnRetourPlus);
            this.Controls.Add(this.pnlTitreExo);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblTitreCours);
            this.Controls.Add(this.cboLecons);
            this.Controls.Add(this.cboCours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu administrateur";
            this.pnlTitreExo.ResumeLayout(false);
            this.pnlExo.ResumeLayout(false);
            this.pnlExo.PerformLayout();
            this.pnlPhrase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.ComboBox cboLecons;
        private System.Windows.Forms.Label lblTitreCours;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Panel pnlTitreExo;
        private System.Windows.Forms.Label lblNumeroExo;
        private System.Windows.Forms.Button btnRetourPlus;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAvancerPlus;
        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.Panel pnlExo;
        private System.Windows.Forms.Label lblRegleActu;
        private System.Windows.Forms.Label lblRegle;
        private System.Windows.Forms.Label lblEnonceActu;
        private System.Windows.Forms.Label lblEnonce;
        private System.Windows.Forms.Panel pnlPhrase;
        private System.Windows.Forms.Label lblDetailsExo;
    }
}