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

namespace Mini_projet_Babbel
{
    /*
     * Formulaire du menu administrateur, permettant de visualiser tous les exercices et leur solution
     */
    public partial class formAdmin : Form
    {
        //Déclaration et initialisation des objets et variables globales
        const string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base\baseLangue.mdb";

        OleDbConnection con = new OleDbConnection();
        Exercice exo = new Exercice();

        //Booléen qui détermine si oui ou non les informations ont été chargées
        bool loadFini = false;

        //Table locale
        readonly string[] tables = new string[] { "Cours", "Lecons", "Mots" };
        readonly string[] orderBy = new string[] { "numCours", "numLecon", "numMot" };
        DataSet ds = new DataSet();

        //Binding sources qui lieront les cours aux leçons
        BindingSource bsCours = new BindingSource();
        BindingSource bsLecons = new BindingSource();


        public formAdmin()
        {
            InitializeComponent();

            //Chargement de la table locale
            chargerDataSet();

            //Création de la relation entre Cours et Lecons
            DataColumn col1 = ds.Tables["Cours"].Columns["numCours"];
            DataColumn col2 = ds.Tables["Lecons"].Columns["numCours"];

            DataRelation rel = new DataRelation("fk_cours_lecons", col1, col2);

            //Ajout de la relation
            ds.Relations.Add(rel);

            //Chargement des informations dans les comboBox correspondants
            bsCours.DataSource = ds;
            bsCours.DataMember = "Cours";
            cboCours.DataSource = bsCours;
            cboCours.DisplayMember = "titreCours";
            cboCours.ValueMember = "numCours";

            bsLecons.DataSource = bsCours;
            bsLecons.DataMember = "fk_cours_lecons";
            cboLecons.DataSource = bsLecons;
            cboLecons.DisplayMember = "titreLecon";
            cboLecons.ValueMember = "numLecon";

            //Enregistrement de l'exercice actuel
            exo.numeroCours = cboCours.SelectedValue.ToString();
            exo.numeroLecon = Convert.ToInt32(cboLecons.SelectedValue);
            exo.numeroExercice = 1;

            //Actualisation des informations à afficher
            actualiserInfosExo();

            //Chargement des informations terminé
            loadFini = true;
        }

        /******************************************************************************/
        /* CONTRÔLES                                                                  */
        /******************************************************************************/
        /*
         * Click sur le bouton "Fermer"
         * L'utilisateur veut quitter le menu administrateur
         */
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Lorsque l'index de la comboBox Lecons change
         */
        private void CboLecons_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si le chargement des informations est fini
            if (loadFini)
            {
                //Enregistrement de l'exercice actuel
                exo.numeroCours = cboCours.SelectedValue.ToString();
                exo.numeroLecon = Convert.ToInt32(cboLecons.SelectedValue);
                exo.numeroExercice = 1;

                //Actualisation des informations à afficher
                actualiserInfosExo();
            }
        }

        /*
         * Click sur le bouton "<<"
         * L'utilisateur veut retourner au 1er exercice de la leçon
         */
        private void BtnRetourPlus_Click(object sender, EventArgs e)
        {
            //Retour à l'exercice 1
            exo.numeroExercice = 1;

            //Actualisation des informations à afficher
            actualiserInfosExo();
        }

        /*
         * Click sur le bouton "<"
         * L'utilisateur veut retourner à l'exercice précédent
         */
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            //Retour à l'exercice précédent
            exo.numeroExercice--;

            //Actualisation des informations à afficher
            actualiserInfosExo();
        }

        /*
         * Click sur le bouton ">"
         * L'utilisateur veut aller à l'exercice suivant
         */
        private void BtnAvancer_Click(object sender, EventArgs e)
        {
            //Aller à l'exercice suivant
            exo.numeroExercice++;

            //Actualisation des informations à afficher
            actualiserInfosExo();
        }

        /*
         * Click sur le bouton ">>"
         * L'utilisateur veut aller au dernier exercice de la leçon
         */
        private void BtnAvancerPlus_Click(object sender, EventArgs e)
        {
            //Aller au dernier exercice
            exo.numeroExercice = exo.nombreExercice;

            //Actualisation des informations à afficher
            actualiserInfosExo();
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure chargerDataSet qui remplie le DataSet local avec les informations nécessaires
         */
        private void chargerDataSet()
        {
            //Remplissage des informations de la base nécessaires en local
            con.ConnectionString = CONNECTION_STRING;

            try
            {
                //Ouverture de la connexion
                con.Open();

                OleDbCommand cd = new OleDbCommand();
                cd.Connection = con;

                OleDbDataAdapter da = new OleDbDataAdapter(cd);

                //Pour chacune des tables dans la liste des tables
                for (int i = 0; i < tables.Length; i++)
                {
                    //Remplissage
                    cd.CommandText = "SELECT * FROM " + tables[i] + " " +
                                     "ORDER BY " + orderBy[i];
                    da.Fill(ds, tables[i]);
                }
            }
            catch (Exception ex)
            {
                //Affichage d'une erreur
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //Fermeture de la connexion
                con.Close();
            }
        }

        /*
         * Procédure actualiserBoutons qui détermine si oui ou non les différents boutons sont cliquables
         */
        private void actualiserBoutons()
        {
            //Si l'exercice actuel est le premier de la leçon
            if (exo.numeroExercice == 1)
            {
                //Désactivation des boutons retours
                btnRetourPlus.Enabled = false;
                btnRetourPlus.BackColor = Color.DimGray;
                btnRetourPlus.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);

                btnRetour.Enabled = false;
                btnRetour.BackColor = Color.DimGray;
                btnRetour.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            }
            //Sinon
            else
            {
                //Activation des boutons retours
                btnRetourPlus.Enabled = true;
                btnRetourPlus.BackColor = Color.Gainsboro;
                btnRetourPlus.FlatAppearance.BorderColor = Color.Silver;

                btnRetour.Enabled = true;
                btnRetour.BackColor = Color.Gainsboro;
                btnRetour.FlatAppearance.BorderColor = Color.Silver;
            }

            //Si l'exercice actuel est le dernier de la leçon
            if (exo.numeroExercice == exo.nombreExercice)
            {
                //Désactivation des boutons avancer
                btnAvancerPlus.Enabled = false;
                btnAvancerPlus.BackColor = Color.DimGray;
                btnAvancerPlus.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);

                btnAvancer.Enabled = false;
                btnAvancer.BackColor = Color.DimGray;
                btnAvancer.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            }
            //Sinon
            else
            {
                //Activation des boutons avancer
                btnAvancerPlus.Enabled = true;
                btnAvancerPlus.BackColor = Color.Gainsboro;
                btnAvancerPlus.FlatAppearance.BorderColor = Color.Silver;

                btnAvancer.Enabled = true;
                btnAvancer.BackColor = Color.Gainsboro;
                btnAvancer.FlatAppearance.BorderColor = Color.Silver;
            }
        }

        /*
         * Procédure actualiserInfosExo qui affiche toutes les informations concernant l'exercice actuel
         */
        private void actualiserInfosExo()
        {
            //Actualisation du nombre d'exercices dans la leçon
            exo.actualiserNbMax();

            //Affichage du numéro de l'exercice
            lblNumeroExo.Text = "Exercice " + exo.numeroExercice.ToString() + "/" + exo.nombreExercice.ToString();

            //Affichage de la règle si disponible
            lblRegleActu.Text = exo.detRegle();
            if (lblRegleActu.Text != string.Empty)
            {
                lblRegle.Visible = true;
            }
            else
            {
                lblRegle.Visible = false;
            }

            //Affichage de l'énoncé
            lblEnonceActu.Text = exo.detEnonce();

            //Détermination du type de l'exercice
            int type = exo.detTypeExercice();

            //Phrase en désordre
            if (type == 1)
            {
                lblDetailsExo.Text = "Reconstituer la phrase : " + exo.detPhrases()[0];
            }
            //Phrase à trous
            else if (type == 2)
            {
                lblDetailsExo.Text = "Compléter la phrase : " + exo.detPhrases()[0];
            }
            //Vocabulaire
            else if (type == 3)
            {
                lblDetailsExo.Text = "Mots de vocabulaire : ";

                List<int> mots = exo.detNumMots();

                for (int i = 0; i < mots.Count; i++)
                {
                    DataRow[] data = ds.Tables["Mots"].Select($"numMot={mots[i]}");

                    if (data.Length > 0)
                    {
                        lblDetailsExo.Text += data[0]["libMot"];
                    }

                    if (i != mots.Count - 1)
                    {
                        lblDetailsExo.Text += ", ";
                    }
                }
            }
            //Grammaire
            else if (type == 4)
            {
                lblDetailsExo.Text = "Conjugaison du verbe " + exo.detVerbe();
            }

            //Actualisation des boutons
            actualiserBoutons();
        }
    }
}
