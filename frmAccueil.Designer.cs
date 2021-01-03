namespace Mini_projet_Babbel
{
    partial class frmAccueil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.lblCours = new System.Windows.Forms.Label();
            this.lblCoursActu = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblLeconActu = new System.Windows.Forms.Label();
            this.lblLeconCom = new System.Windows.Forms.Label();
            this.lblExoFini = new System.Windows.Forms.Label();
            this.lblExoFiniNb = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.imgListProgressBar = new System.Windows.Forms.ImageList(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.btnChangerExo = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.pnlBonjour = new System.Windows.Forms.Panel();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxShowInfos = new System.Windows.Forms.PictureBox();
            this.pnlProgression = new System.Windows.Forms.Panel();
            this.pnlBonjour.SuspendLayout();
            this.pnlInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowInfos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(132, 17);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(126, 18);
            this.lblCours.TabIndex = 1;
            this.lblCours.Text = "Votre cours actuel :";
            // 
            // lblCoursActu
            // 
            this.lblCoursActu.AutoSize = true;
            this.lblCoursActu.BackColor = System.Drawing.Color.Transparent;
            this.lblCoursActu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursActu.ForeColor = System.Drawing.Color.Red;
            this.lblCoursActu.Location = new System.Drawing.Point(261, 17);
            this.lblCoursActu.Name = "lblCoursActu";
            this.lblCoursActu.Size = new System.Drawing.Size(46, 18);
            this.lblCoursActu.TabIndex = 2;
            this.lblCoursActu.Text = "label1";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.ForeColor = System.Drawing.Color.White;
            this.lblLecon.Location = new System.Drawing.Point(207, 55);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(51, 18);
            this.lblLecon.TabIndex = 3;
            this.lblLecon.Text = "Leçon :";
            // 
            // lblLeconActu
            // 
            this.lblLeconActu.AutoSize = true;
            this.lblLeconActu.BackColor = System.Drawing.Color.Transparent;
            this.lblLeconActu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeconActu.ForeColor = System.Drawing.Color.LightCoral;
            this.lblLeconActu.Location = new System.Drawing.Point(261, 55);
            this.lblLeconActu.Name = "lblLeconActu";
            this.lblLeconActu.Size = new System.Drawing.Size(46, 18);
            this.lblLeconActu.TabIndex = 4;
            this.lblLeconActu.Text = "label1";
            // 
            // lblLeconCom
            // 
            this.lblLeconCom.AutoSize = true;
            this.lblLeconCom.BackColor = System.Drawing.Color.Transparent;
            this.lblLeconCom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeconCom.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLeconCom.Location = new System.Drawing.Point(261, 93);
            this.lblLeconCom.Name = "lblLeconCom";
            this.lblLeconCom.Size = new System.Drawing.Size(34, 18);
            this.lblLeconCom.TabIndex = 5;
            this.lblLeconCom.Text = "com";
            // 
            // lblExoFini
            // 
            this.lblExoFini.AutoSize = true;
            this.lblExoFini.BackColor = System.Drawing.Color.Transparent;
            this.lblExoFini.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExoFini.ForeColor = System.Drawing.Color.White;
            this.lblExoFini.Location = new System.Drawing.Point(400, 426);
            this.lblExoFini.Name = "lblExoFini";
            this.lblExoFini.Size = new System.Drawing.Size(131, 18);
            this.lblExoFini.TabIndex = 6;
            this.lblExoFini.Text = "Exercices terminés :";
            // 
            // lblExoFiniNb
            // 
            this.lblExoFiniNb.AutoSize = true;
            this.lblExoFiniNb.BackColor = System.Drawing.Color.Transparent;
            this.lblExoFiniNb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExoFiniNb.ForeColor = System.Drawing.Color.White;
            this.lblExoFiniNb.Location = new System.Drawing.Point(532, 426);
            this.lblExoFiniNb.Name = "lblExoFiniNb";
            this.lblExoFiniNb.Size = new System.Drawing.Size(28, 18);
            this.lblExoFiniNb.TabIndex = 7;
            this.lblExoFiniNb.Text = "1/1";
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button2;
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(503, 510);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 36);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Continuer la leçon";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(50, 510);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(171, 36);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // imgListProgressBar
            // 
            this.imgListProgressBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListProgressBar.ImageStream")));
            this.imgListProgressBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListProgressBar.Images.SetKeyName(0, "green.png");
            this.imgListProgressBar.Images.SetKeyName(1, "toDo.png");
            this.imgListProgressBar.Images.SetKeyName(2, "gray.png");
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(172, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 18);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description :";
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgressBar.Location = new System.Drawing.Point(200, 460);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(550, 25);
            this.pnlProgressBar.TabIndex = 15;
            // 
            // btnChangerExo
            // 
            this.btnChangerExo.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnChangerExo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChangerExo.ForeColor = System.Drawing.Color.Black;
            this.btnChangerExo.Location = new System.Drawing.Point(276, 510);
            this.btnChangerExo.Name = "btnChangerExo";
            this.btnChangerExo.Size = new System.Drawing.Size(171, 36);
            this.btnChangerExo.TabIndex = 16;
            this.btnChangerExo.Text = "Changer d\'exercice";
            this.btnChangerExo.UseVisualStyleBackColor = true;
            this.btnChangerExo.Click += new System.EventHandler(this.BtnChangerExo_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.close;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitter.FlatAppearance.BorderSize = 3;
            this.btnQuitter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(882, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(40, 40);
            this.btnQuitter.TabIndex = 20;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeco.ForeColor = System.Drawing.Color.Black;
            this.btnDeco.Location = new System.Drawing.Point(729, 510);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(171, 36);
            this.btnDeco.TabIndex = 21;
            this.btnDeco.Text = "Déconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.BtnDeco_Click);
            // 
            // pnlBonjour
            // 
            this.pnlBonjour.BackColor = System.Drawing.Color.Transparent;
            this.pnlBonjour.Controls.Add(this.lblBonjour);
            this.pnlBonjour.Location = new System.Drawing.Point(229, 195);
            this.pnlBonjour.Name = "pnlBonjour";
            this.pnlBonjour.Size = new System.Drawing.Size(492, 50);
            this.pnlBonjour.TabIndex = 22;
            // 
            // lblBonjour
            // 
            this.lblBonjour.BackColor = System.Drawing.Color.Transparent;
            this.lblBonjour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBonjour.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.ForeColor = System.Drawing.Color.White;
            this.lblBonjour.Location = new System.Drawing.Point(0, 0);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(492, 50);
            this.lblBonjour.TabIndex = 18;
            this.lblBonjour.Text = "Bonjour, nom Exemple !";
            this.lblBonjour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Voyons où vous vous étiez arrêté ...";
            // 
            // pnlInfos
            // 
            this.pnlInfos.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfos.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.fondBlanc;
            this.pnlInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfos.Controls.Add(this.label2);
            this.pnlInfos.Controls.Add(this.picBoxShowInfos);
            this.pnlInfos.Controls.Add(this.lblDescription);
            this.pnlInfos.Controls.Add(this.lblLeconCom);
            this.pnlInfos.Controls.Add(this.lblLeconActu);
            this.pnlInfos.Controls.Add(this.lblLecon);
            this.pnlInfos.Controls.Add(this.lblCoursActu);
            this.pnlInfos.Controls.Add(this.lblCours);
            this.pnlInfos.Location = new System.Drawing.Point(215, 279);
            this.pnlInfos.Name = "pnlInfos";
            this.pnlInfos.Size = new System.Drawing.Size(520, 128);
            this.pnlInfos.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Voir progression";
            // 
            // picBoxShowInfos
            // 
            this.picBoxShowInfos.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.showInfos;
            this.picBoxShowInfos.Location = new System.Drawing.Point(39, 34);
            this.picBoxShowInfos.Name = "picBoxShowInfos";
            this.picBoxShowInfos.Size = new System.Drawing.Size(50, 50);
            this.picBoxShowInfos.TabIndex = 14;
            this.picBoxShowInfos.TabStop = false;
            this.picBoxShowInfos.MouseEnter += new System.EventHandler(this.PicBoxShowInfos_MouseEnter);
            this.picBoxShowInfos.MouseLeave += new System.EventHandler(this.PicBoxShowInfos_MouseLeave);
            // 
            // pnlProgression
            // 
            this.pnlProgression.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgression.Location = new System.Drawing.Point(6, 78);
            this.pnlProgression.Name = "pnlProgression";
            this.pnlProgression.Size = new System.Drawing.Size(203, 366);
            this.pnlProgression.TabIndex = 25;
            this.pnlProgression.Visible = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_menu;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlProgression);
            this.Controls.Add(this.pnlInfos);
            this.Controls.Add(this.btnChangerExo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBonjour);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pnlProgressBar);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblExoFiniNb);
            this.Controls.Add(this.lblExoFini);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Casa de Babbel";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.pnlBonjour.ResumeLayout(false);
            this.pnlInfos.ResumeLayout(false);
            this.pnlInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowInfos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblCoursActu;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblLeconActu;
        private System.Windows.Forms.Label lblLeconCom;
        private System.Windows.Forms.Label lblExoFini;
        private System.Windows.Forms.Label lblExoFiniNb;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ImageList imgListProgressBar;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.Button btnChangerExo;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Panel pnlBonjour;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInfos;
        private System.Windows.Forms.PictureBox picBoxShowInfos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProgression;
    }
}

