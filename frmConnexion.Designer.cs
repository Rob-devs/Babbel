namespace Mini_projet_Babbel
{
    partial class frmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.cboUtilisateurs = new System.Windows.Forms.ComboBox();
            this.picBoxUtil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUtil)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUtilisateurs
            // 
            this.cboUtilisateurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUtilisateurs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUtilisateurs.FormattingEnabled = true;
            this.cboUtilisateurs.Location = new System.Drawing.Point(268, 249);
            this.cboUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUtilisateurs.Name = "cboUtilisateurs";
            this.cboUtilisateurs.Size = new System.Drawing.Size(214, 24);
            this.cboUtilisateurs.TabIndex = 1;
            // 
            // picBoxUtil
            // 
            this.picBoxUtil.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUtil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxUtil.BackgroundImage")));
            this.picBoxUtil.Location = new System.Drawing.Point(315, 120);
            this.picBoxUtil.Name = "picBoxUtil";
            this.picBoxUtil.Size = new System.Drawing.Size(120, 120);
            this.picBoxUtil.TabIndex = 13;
            this.picBoxUtil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Identifiez-vous :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.button2;
            this.btnConnexion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(290, 403);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(171, 36);
            this.btnConnexion.TabIndex = 18;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.close;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitter.FlatAppearance.BorderSize = 3;
            this.btnQuitter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(682, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(40, 40);
            this.btnQuitter.TabIndex = 19;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mini_projet_Babbel.Properties.Resources.background_connexion;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxUtil);
            this.Controls.Add(this.cboUtilisateurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUtil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUtilisateurs;
        private System.Windows.Forms.PictureBox picBoxUtil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
    }
}