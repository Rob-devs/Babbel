namespace Mini_projet_Babbel
{
    partial class changerExo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changerExo));
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.cboLecon = new System.Windows.Forms.ComboBox();
            this.cboExo = new System.Windows.Forms.ComboBox();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnReinit = new System.Windows.Forms.Button();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblTitreCours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCours
            // 
            this.cboCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(157, 67);
            this.cboCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(255, 24);
            this.cboCours.TabIndex = 0;
            this.cboCours.SelectedIndexChanged += new System.EventHandler(this.CboCours_SelectedIndexChanged);
            // 
            // cboLecon
            // 
            this.cboLecon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLecon.FormattingEnabled = true;
            this.cboLecon.Location = new System.Drawing.Point(157, 119);
            this.cboLecon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLecon.Name = "cboLecon";
            this.cboLecon.Size = new System.Drawing.Size(255, 24);
            this.cboLecon.TabIndex = 1;
            this.cboLecon.SelectedIndexChanged += new System.EventHandler(this.CboLecon_SelectedIndexChanged);
            // 
            // cboExo
            // 
            this.cboExo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExo.FormattingEnabled = true;
            this.cboExo.Location = new System.Drawing.Point(157, 172);
            this.cboExo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboExo.Name = "cboExo";
            this.cboExo.Size = new System.Drawing.Size(255, 24);
            this.cboExo.TabIndex = 2;
            this.cboExo.SelectedIndexChanged += new System.EventHandler(this.CboExo_SelectedIndexChanged);
            // 
            // btnAccepter
            // 
            this.btnAccepter.BackColor = System.Drawing.Color.Transparent;
            this.btnAccepter.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button3;
            this.btnAccepter.Enabled = false;
            this.btnAccepter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccepter.ForeColor = System.Drawing.Color.White;
            this.btnAccepter.Location = new System.Drawing.Point(12, 258);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(171, 36);
            this.btnAccepter.TabIndex = 9;
            this.btnAccepter.Text = "Valider";
            this.btnAccepter.UseVisualStyleBackColor = false;
            this.btnAccepter.Click += new System.EventHandler(this.BtnAccepter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnuler.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button1;
            this.btnAnnuler.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(366, 258);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(171, 36);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Abandonner";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnReinit
            // 
            this.btnReinit.BackColor = System.Drawing.Color.Transparent;
            this.btnReinit.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button3;
            this.btnReinit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinit.ForeColor = System.Drawing.Color.White;
            this.btnReinit.Location = new System.Drawing.Point(189, 258);
            this.btnReinit.Name = "btnReinit";
            this.btnReinit.Size = new System.Drawing.Size(171, 36);
            this.btnReinit.TabIndex = 11;
            this.btnReinit.Text = "Réinitialiser";
            this.btnReinit.UseVisualStyleBackColor = false;
            this.btnReinit.Click += new System.EventHandler(this.BtnReinit_Click);
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCours.ForeColor = System.Drawing.Color.White;
            this.lblCours.Location = new System.Drawing.Point(101, 69);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(50, 18);
            this.lblCours.TabIndex = 12;
            this.lblCours.Text = "Cours :";
            // 
            // lblTitreCours
            // 
            this.lblTitreCours.BackColor = System.Drawing.Color.Transparent;
            this.lblTitreCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitreCours.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCours.ForeColor = System.Drawing.Color.White;
            this.lblTitreCours.Location = new System.Drawing.Point(0, 0);
            this.lblTitreCours.Name = "lblTitreCours";
            this.lblTitreCours.Size = new System.Drawing.Size(549, 30);
            this.lblTitreCours.TabIndex = 37;
            this.lblTitreCours.Text = "Changer d\'exercice";
            this.lblTitreCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Leçon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Exercice :";
            // 
            // changerExo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_change;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitreCours);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.btnReinit);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.cboExo);
            this.Controls.Add(this.cboLecon);
            this.Controls.Add(this.cboCours);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "changerExo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choisir un nouvel exercice";
            this.Load += new System.EventHandler(this.ChangerExo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.ComboBox cboLecon;
        private System.Windows.Forms.ComboBox cboExo;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnReinit;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblTitreCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}