namespace Mini_projet_Babbel
{
    partial class formRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecap));
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.imgListProgressBar = new System.Windows.Forms.ImageList(this.components);
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.picBoxBook = new System.Windows.Forms.PictureBox();
            this.imgListMilieu = new System.Windows.Forms.ImageList(this.components);
            this.pnlPros = new System.Windows.Forms.Panel();
            this.pnlTextPros = new System.Windows.Forms.Panel();
            this.picBoxPros = new System.Windows.Forms.PictureBox();
            this.pnlCons = new System.Windows.Forms.Panel();
            this.pnlTextCons = new System.Windows.Forms.Panel();
            this.picBoxCons = new System.Windows.Forms.PictureBox();
            this.lblExoFiniNb = new System.Windows.Forms.Label();
            this.lblExoFini = new System.Windows.Forms.Label();
            this.lblLeconActu = new System.Windows.Forms.Label();
            this.lblLecon = new System.Windows.Forms.Label();
            this.lblCoursActu = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblRecap = new System.Windows.Forms.Label();
            this.btnRecommencer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).BeginInit();
            this.pnlPros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPros)).BeginInit();
            this.pnlCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCons)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlProgressBar.Location = new System.Drawing.Point(49, 38);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(550, 25);
            this.pnlProgressBar.TabIndex = 16;
            // 
            // imgListProgressBar
            // 
            this.imgListProgressBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListProgressBar.ImageStream")));
            this.imgListProgressBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListProgressBar.Images.SetKeyName(0, "green.png");
            this.imgListProgressBar.Images.SetKeyName(1, "toDo.png");
            this.imgListProgressBar.Images.SetKeyName(2, "gray.png");
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button2;
            this.btnSuivant.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.White;
            this.btnSuivant.Location = new System.Drawing.Point(240, 413);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(171, 36);
            this.btnSuivant.TabIndex = 17;
            this.btnSuivant.Text = "Exercice suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // btnTerminer
            // 
            this.btnTerminer.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnTerminer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminer.ForeColor = System.Drawing.Color.Black;
            this.btnTerminer.Location = new System.Drawing.Point(451, 413);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(171, 36);
            this.btnTerminer.TabIndex = 18;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = true;
            this.btnTerminer.Click += new System.EventHandler(this.BtnTerminer_Click);
            // 
            // picBoxBook
            // 
            this.picBoxBook.BackColor = System.Drawing.Color.Transparent;
            this.picBoxBook.Location = new System.Drawing.Point(213, 156);
            this.picBoxBook.Name = "picBoxBook";
            this.picBoxBook.Size = new System.Drawing.Size(220, 220);
            this.picBoxBook.TabIndex = 19;
            this.picBoxBook.TabStop = false;
            // 
            // imgListMilieu
            // 
            this.imgListMilieu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMilieu.ImageStream")));
            this.imgListMilieu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMilieu.Images.SetKeyName(0, "book.png");
            this.imgListMilieu.Images.SetKeyName(1, "bar.png");
            // 
            // pnlPros
            // 
            this.pnlPros.BackColor = System.Drawing.Color.Transparent;
            this.pnlPros.Controls.Add(this.pnlTextPros);
            this.pnlPros.Controls.Add(this.picBoxPros);
            this.pnlPros.Location = new System.Drawing.Point(38, 140);
            this.pnlPros.Name = "pnlPros";
            this.pnlPros.Size = new System.Drawing.Size(260, 228);
            this.pnlPros.TabIndex = 20;
            this.pnlPros.Visible = false;
            // 
            // pnlTextPros
            // 
            this.pnlTextPros.AutoScroll = true;
            this.pnlTextPros.BackColor = System.Drawing.Color.Black;
            this.pnlTextPros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextPros.ForeColor = System.Drawing.Color.Black;
            this.pnlTextPros.Location = new System.Drawing.Point(0, 68);
            this.pnlTextPros.Name = "pnlTextPros";
            this.pnlTextPros.Size = new System.Drawing.Size(260, 160);
            this.pnlTextPros.TabIndex = 2;
            // 
            // picBoxPros
            // 
            this.picBoxPros.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.pros;
            this.picBoxPros.Location = new System.Drawing.Point(105, 0);
            this.picBoxPros.Name = "picBoxPros";
            this.picBoxPros.Size = new System.Drawing.Size(50, 50);
            this.picBoxPros.TabIndex = 1;
            this.picBoxPros.TabStop = false;
            // 
            // pnlCons
            // 
            this.pnlCons.BackColor = System.Drawing.Color.Transparent;
            this.pnlCons.Controls.Add(this.pnlTextCons);
            this.pnlCons.Controls.Add(this.picBoxCons);
            this.pnlCons.Location = new System.Drawing.Point(348, 140);
            this.pnlCons.Name = "pnlCons";
            this.pnlCons.Size = new System.Drawing.Size(260, 228);
            this.pnlCons.TabIndex = 21;
            this.pnlCons.Visible = false;
            // 
            // pnlTextCons
            // 
            this.pnlTextCons.AutoScroll = true;
            this.pnlTextCons.BackColor = System.Drawing.Color.Black;
            this.pnlTextCons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextCons.Location = new System.Drawing.Point(0, 68);
            this.pnlTextCons.Name = "pnlTextCons";
            this.pnlTextCons.Size = new System.Drawing.Size(260, 160);
            this.pnlTextCons.TabIndex = 3;
            // 
            // picBoxCons
            // 
            this.picBoxCons.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.cons;
            this.picBoxCons.Location = new System.Drawing.Point(105, 0);
            this.picBoxCons.Name = "picBoxCons";
            this.picBoxCons.Size = new System.Drawing.Size(50, 50);
            this.picBoxCons.TabIndex = 2;
            this.picBoxCons.TabStop = false;
            // 
            // lblExoFiniNb
            // 
            this.lblExoFiniNb.AutoSize = true;
            this.lblExoFiniNb.BackColor = System.Drawing.Color.Transparent;
            this.lblExoFiniNb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExoFiniNb.ForeColor = System.Drawing.Color.White;
            this.lblExoFiniNb.Location = new System.Drawing.Point(375, 75);
            this.lblExoFiniNb.Name = "lblExoFiniNb";
            this.lblExoFiniNb.Size = new System.Drawing.Size(28, 18);
            this.lblExoFiniNb.TabIndex = 23;
            this.lblExoFiniNb.Text = "1/1";
            // 
            // lblExoFini
            // 
            this.lblExoFini.AutoSize = true;
            this.lblExoFini.BackColor = System.Drawing.Color.Transparent;
            this.lblExoFini.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExoFini.ForeColor = System.Drawing.Color.White;
            this.lblExoFini.Location = new System.Drawing.Point(245, 75);
            this.lblExoFini.Name = "lblExoFini";
            this.lblExoFini.Size = new System.Drawing.Size(131, 18);
            this.lblExoFini.TabIndex = 22;
            this.lblExoFini.Text = "Exercices terminés :";
            // 
            // lblLeconActu
            // 
            this.lblLeconActu.AutoSize = true;
            this.lblLeconActu.BackColor = System.Drawing.Color.Transparent;
            this.lblLeconActu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeconActu.ForeColor = System.Drawing.Color.LightCoral;
            this.lblLeconActu.Location = new System.Drawing.Point(67, 110);
            this.lblLeconActu.Name = "lblLeconActu";
            this.lblLeconActu.Size = new System.Drawing.Size(46, 18);
            this.lblLeconActu.TabIndex = 27;
            this.lblLeconActu.Text = "label1";
            // 
            // lblLecon
            // 
            this.lblLecon.AutoSize = true;
            this.lblLecon.BackColor = System.Drawing.Color.Transparent;
            this.lblLecon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecon.ForeColor = System.Drawing.Color.White;
            this.lblLecon.Location = new System.Drawing.Point(10, 110);
            this.lblLecon.Name = "lblLecon";
            this.lblLecon.Size = new System.Drawing.Size(51, 18);
            this.lblLecon.TabIndex = 26;
            this.lblLecon.Text = "Leçon :";
            // 
            // lblCoursActu
            // 
            this.lblCoursActu.AutoSize = true;
            this.lblCoursActu.BackColor = System.Drawing.Color.Transparent;
            this.lblCoursActu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursActu.ForeColor = System.Drawing.Color.Red;
            this.lblCoursActu.Location = new System.Drawing.Point(67, 85);
            this.lblCoursActu.Name = "lblCoursActu";
            this.lblCoursActu.Size = new System.Drawing.Size(46, 18);
            this.lblCoursActu.TabIndex = 25;
            this.lblCoursActu.Text = "label1";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(12, 85);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(50, 18);
            this.lblCours.TabIndex = 24;
            this.lblCours.Text = "Cours :";
            // 
            // lblRecap
            // 
            this.lblRecap.AutoSize = true;
            this.lblRecap.BackColor = System.Drawing.Color.Transparent;
            this.lblRecap.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecap.ForeColor = System.Drawing.Color.White;
            this.lblRecap.Location = new System.Drawing.Point(235, 106);
            this.lblRecap.Name = "lblRecap";
            this.lblRecap.Size = new System.Drawing.Size(181, 23);
            this.lblRecap.TabIndex = 28;
            this.lblRecap.Text = "Synthèse de la leçon :";
            this.lblRecap.Visible = false;
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnRecommencer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommencer.ForeColor = System.Drawing.Color.Black;
            this.btnRecommencer.Location = new System.Drawing.Point(28, 413);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(171, 36);
            this.btnRecommencer.TabIndex = 29;
            this.btnRecommencer.Text = "Recommencer la leçon";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Visible = false;
            this.btnRecommencer.Click += new System.EventHandler(this.BtnRecommencer_Click);
            // 
            // formRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_recap;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.lblRecap);
            this.Controls.Add(this.lblLeconActu);
            this.Controls.Add(this.lblLecon);
            this.Controls.Add(this.lblCoursActu);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblExoFiniNb);
            this.Controls.Add(this.lblExoFini);
            this.Controls.Add(this.pnlCons);
            this.Controls.Add(this.pnlPros);
            this.Controls.Add(this.picBoxBook);
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.pnlProgressBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formRecap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synthèse";
            this.Load += new System.EventHandler(this.FormRecap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).EndInit();
            this.pnlPros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPros)).EndInit();
            this.pnlCons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.ImageList imgListProgressBar;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnTerminer;
        private System.Windows.Forms.PictureBox picBoxBook;
        private System.Windows.Forms.ImageList imgListMilieu;
        private System.Windows.Forms.Panel pnlPros;
        private System.Windows.Forms.Panel pnlCons;
        private System.Windows.Forms.Label lblExoFiniNb;
        private System.Windows.Forms.Label lblExoFini;
        private System.Windows.Forms.PictureBox picBoxPros;
        private System.Windows.Forms.PictureBox picBoxCons;
        private System.Windows.Forms.Label lblLeconActu;
        private System.Windows.Forms.Label lblLecon;
        private System.Windows.Forms.Label lblCoursActu;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblRecap;
        private System.Windows.Forms.Panel pnlTextPros;
        private System.Windows.Forms.Panel pnlTextCons;
        private System.Windows.Forms.Button btnRecommencer;
    }
}