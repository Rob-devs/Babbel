using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_projet_Babbel
{
    /*
     * Formulaire permettant de sélectionner un nouvel exercice
     */
    public partial class changerExo : Form
    {
        //Déclaration et initialisation des objets et variables globales
        const string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base\baseLangue.mdb";

        OleDbConnection con = new OleDbConnection();
        Exercice exo = new Exercice();

        readonly string[] tables = new string[] { "Cours", "Lecons", "Exercices" };
        DataSet ds = new DataSet();

        public string changedNumCours
        {
            get { return cboCours.SelectedValue.ToString(); }
            set {; }
        }

        public int changedNumLecon
        {
            get { return Convert.ToInt32(cboLecon.SelectedValue); }
            set {; }
        }

        public int changedNumExo
        {
            get { return Convert.ToInt32(cboExo.SelectedValue); }
            set {; }
        }

        public changerExo(Exercice exo)
        {
            InitializeComponent();

            this.exo = exo;
        }

        /******************************************************************************/
        /* CONTRÔLES                                                                  */
        /******************************************************************************/
        /*
         * Au lancement du formulaire
         */
        private void ChangerExo_Load(object sender, EventArgs e)
        {
            chargerDataSet();

            DataTable dt = ds.Tables["Cours"];
            dt.DefaultView.Sort = "numCours";

            cboCours.ValueMember = "numCours";
            cboCours.DisplayMember = "titreCours";
            cboCours.DataSource = dt;

            cboCours.SelectedValue = exo.numeroCours;
            cboLecon.SelectedValue = exo.numeroLecon;
            cboExo.SelectedValue = exo.numeroExercice;
        }

        /*
         * Click sur le bouton "Annuler"
         * L'utilisateur ne veut conserver aucun changement
         */
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /*
         * Click sur le bouton "Accepter"
         * L'utilisateur veut conserver les changements effectués
         */
        private void BtnAccepter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
         * Click sur le bouton "Réinitialiser"
         * L'utilisateur veut recommencer au tout premier exercice
         */
        private void BtnReinit_Click(object sender, EventArgs e)
        {
            cboCours.SelectedIndex = 0;
            cboLecon.SelectedIndex = 0;
            cboExo.SelectedIndex = 0;
        }

        /*
         * Lorsque le cours est changé
         */
        private void CboCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Lecons"].Clone();

            DataRow[] data = ds.Tables["Lecons"].Select($"numCours='{cboCours.SelectedValue}'");

            foreach (DataRow dr in data)
            {
                dt.ImportRow(dr);
            }

            dt.DefaultView.Sort = "numLecon";

            cboLecon.ValueMember = "numLecon";
            cboLecon.DisplayMember = "titreLecon";
            cboLecon.DataSource = dt;
        }

        /*
         * Lorsque la leçon est changée
         */
        private void CboLecon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Exercices"].Clone();

            DataRow[] data = ds.Tables["Exercices"].Select($"numCours='{cboCours.SelectedValue}' AND numLecon={cboLecon.SelectedValue}");

            foreach (DataRow dr in data)
            {
                dt.ImportRow(dr);
            }

            dt.DefaultView.Sort = "numExo";

            cboExo.ValueMember = "numExo";
            cboExo.DisplayMember = "enonceExo";
            cboExo.DataSource = dt;
        }

        /*
         * Lorsque l'exercice est changé
         */
        private void CboExo_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifBoutons();
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure chargerDataSet qui remplie le DataSet local avec les informations nécessaires
         */
        private void chargerDataSet()
        {
            con.ConnectionString = CONNECTION_STRING;

            try
            {
                //Ouverture de la connexion
                con.Open();

                OleDbCommand cd = new OleDbCommand();
                cd.Connection = con;

                OleDbDataAdapter da = new OleDbDataAdapter(cd);

                foreach (string table in tables)
                {
                    cd.CommandText = "SELECT * FROM " + table;
                    da.Fill(ds, table);
                }
            }
            catch (Exception ex)
            {
                //Affichage d'une erreur
                MessageBox.Show("Error");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //Fermeture de la connexion
                con.Close();
            }
        }

        /*
         * Procédure verifBoutons qui vérifie et actualise si les boutons "Accepter" et "Réinitialiser" sont cliquables
         */
        private void verifBoutons()
        {
            if (cboCours.SelectedValue.ToString() == exo.numeroCours &&
                Convert.ToInt32(cboLecon.SelectedValue) == exo.numeroLecon &&
                Convert.ToInt32(cboExo.SelectedValue) == exo.numeroExercice)
            {
                btnAccepter.Enabled = false;
                btnAccepter.BackgroundImage = Properties.Resources.button3;
            }
            else
            {
                btnAccepter.Enabled = true;
                btnAccepter.BackgroundImage = Properties.Resources.button2;
            }

            if (cboCours.SelectedIndex == 0 &&
               Convert.ToInt32(cboLecon.SelectedValue) == 1 &&
               Convert.ToInt32(cboExo.SelectedValue) == 1)
            {
                btnReinit.Enabled = false;
            }
            else
            {
                btnReinit.Enabled = true;
            }
        }

    }
}
