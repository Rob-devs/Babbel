using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

/*
 * BRUMBTER Robin
 */

namespace Mini_projet_Babbel
{
    /*
     * Formulaire de lancement de l'application, où l'utilisateur se connecte
     */
    public partial class frmConnexion : Form
    {
        //Déclaration et initialisation des objets et variables globales
        const string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base\baseLangue.mdb";

        OleDbConnection con = new OleDbConnection();

        public frmConnexion()
        {
            InitializeComponent();
        }

        /******************************************************************************/
        /* CONTRÔLES                                                                  */
        /******************************************************************************/
        /*
         * Au lancement du formulaire
         */
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            //Remplissage de la liste des utilisateurs

            con.ConnectionString = CONNECTION_STRING;

            try
            {
                //Ouverture de la connexion
                con.Open();

                //Remplissage d'une DataTable avec les noms et code des utilisateurs
                string request = @"SELECT [pnUtil] &' ' &[nomUtil] AS Nom, [codeUtil] AS Code FROM Utilisateurs";

                DataTable dtUtil = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter();

                OleDbCommand cd = new OleDbCommand(request, con);
                da.SelectCommand = cd;
                da.Fill(dtUtil);

                cboUtilisateurs.DataSource = dtUtil;
                cboUtilisateurs.DisplayMember = "Nom";
                cboUtilisateurs.ValueMember = "Code";

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
         * Click sur le bouton "X"
         * L'utilisateur veut quitter l'application
         */
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /*
         * Click sur le bouton "Connexion"
         * L'utilisateur veut se connecter
         */
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //Si le formulaire d'accueil se ferme autrement qu'avec "déconnexion"
            if (new frmAccueil(Convert.ToInt32(cboUtilisateurs.SelectedValue), cboUtilisateurs.Text).ShowDialog() != DialogResult.OK)
            {
                //Fermeture du formulaire
                this.Close();
            }
        }
    }
}
