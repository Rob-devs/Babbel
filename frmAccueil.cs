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
     * Formulaire principal de l'application, qui gère tous les autres formulaires
     */
    public partial class frmAccueil : Form
    {
        //Déclaration et initialisation des objets et variables globales
        const string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base\baseLangue.mdb";

        OleDbConnection con = new OleDbConnection();
        Exercice exo = new Exercice();

        //Informations transmises par frmConnexion
        int codeUtil;
        string nomUtil;

        //Liste contenant les codes utilisateurs des administrateurs
        List<int> admins = new List<int>();

        public frmAccueil(int codeUtil, string nomUtil)
        {
            InitializeComponent();

            //Initialisation des informations de l'utilisateur
            this.codeUtil = codeUtil;
            this.nomUtil = nomUtil;
        }

        /******************************************************************************/
        /* CONTRÔLES                                                                  */
        /******************************************************************************/
        /*
         * Au lancement du formulaire
         */
        private void frmAccueil_Load(object sender, EventArgs e)
        {
            //Ajout des administrateurs
            admins.Add(5);
            admins.Add(6);

            //Actualisation des informations à afficher
            lblBonjour.Text = "Bonjour, " + nomUtil + " !";
            changeInformations();

            //Actualisation du panel de progression
            remplirProgression();
        }

        /*
         * Click sur le bouton "Commencer l'exercice"
         * L'utilisateur veut commencer une série d'exercice
         */
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //On cache les boutons pour plus de lisibilité
            btnAdmin.Hide();
            btnStart.Hide();
            btnDeco.Hide();
            btnChangerExo.Hide();

            //Actualisation du nombre d'exercices et du nombre de leçons maximal dans la leçon et le cours actuel
            exo.actualiserNbMax();

            exo.lancerExercice();

            //Tant que l'utilisateur choisit "exercice suivant"
            while (new formRecap(exo).ShowDialog() == DialogResult.OK)
            {
                //Si l'exercice précédent a généré un rapport
                if (exo.rapport)
                {
                    //Réinitialisation du récap de la leçon
                    exo.clearTableRes();
                }

                //Actualisation des données de l'exercice suivant
                exo.exerciceSuivant();

                //Lancement de l'exercice
                exo.lancerExercice();
            }
            //Si l'exercice précédent a généré un rapport
            if (exo.rapport)
            {
                //Réinitialisation du récap de la leçon
                exo.clearTableRes();
            }

            //Actualisation des données de l'exercice suivant
            exo.exerciceSuivant();

            actualiserBase();

            //Actualisation des informations de l'utilisateur
            changeInformations();

            //Réaffichage des boutons
            administrateur(codeUtil);
            btnStart.Show();
            btnDeco.Show();
            btnChangerExo.Show();

            //Actualisation du panel de progression
            remplirProgression();
        }

        /*
         * Click sur le bouton "X"
         * L'utilisateur veut quitter l'application
         */
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Click sur le bouton "Choisir un exercice"
         * L'utilisateur veut sélectionner un nouvel exercice
         */
        private void BtnChangerExo_Click(object sender, EventArgs e)
        {
            //On cache les boutons pour plus de lisibilité
            btnAdmin.Hide();
            btnStart.Hide();
            btnDeco.Hide();
            btnChangerExo.Hide();

            changerExo chg = new changerExo(exo);

            //Si le bouton "Accepter" a été cliqué
            if (chg.ShowDialog() == DialogResult.OK)
            {
                //Changement de l'exercice
                exo.numeroCours = chg.changedNumCours;
                exo.numeroLecon = chg.changedNumLecon;
                exo.numeroExercice = chg.changedNumExo;

                //Actualisation
                actualiserBase();
                changeInformations();

                //Réinitialisation de la table des résultats+
                exo.clearTableRes();

            }

            //Réaffichage des boutons
            administrateur(codeUtil);
            btnStart.Show();
            btnDeco.Show();
            btnChangerExo.Show();

            //Actualisation du panel de progression
            remplirProgression();
        }

        /*
         * Click sur le bouton "Administration"
         * L'utilisateur veut afficher le menu administrateur
         */
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            //On cache les boutons pour plus de lisibilité
            btnAdmin.Hide();
            btnStart.Hide();
            btnDeco.Hide();
            btnChangerExo.Hide();

            //Affichage du menu administrateur
            new formAdmin().ShowDialog();

            //Réaffichage des boutons
            administrateur(codeUtil);
            btnStart.Show();
            btnDeco.Show();
            btnChangerExo.Show();
        }

        /*
         * Click sur le bouton "Déconnexion"
         * L'utilisateur veut se déconnecter
         */
        private void BtnDeco_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
         * Lorsque la souris entre sur l'image "Voir progression"
         */
        private void PicBoxShowInfos_MouseEnter(object sender, EventArgs e)
        {
            //Affichage de la progression
            pnlProgression.Visible = true;
        }

        /*
         * Lorsque la souris sors de l'image "Voir progression"
         */
        private void PicBoxShowInfos_MouseLeave(object sender, EventArgs e)
        {
            //Progression retirée
            pnlProgression.Visible = false;
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure commencerExo qui détermine et actualise si le bouton "Exercice suivant" est cliquable
         */
        public void commencerExo()
        {
            exo.actualiserNbMax();

            //Si l'exercice existe et n'est pas le dernier
            if (exo.cours.Contains(exo.numeroCours)
                && exo.numeroLecon <= exo.nombreLecon
                && exo.numeroExercice <= exo.nombreExercice)
            {
                btnStart.Enabled = true;
                btnStart.BackgroundImage = Properties.Resources.button2;
            }
            //Sinon
            else
            {
                btnStart.Enabled = false;
                btnStart.BackgroundImage = Properties.Resources.button3;
            }
        }

        /*
         * Procédure actualiserBarre qui affiche dynamiquement la barre de progression
         * Paramètres :
         *   numExo: int: numéro de l'exercice
         *   nbExo: int: nombre d'exercices dans la leçon
         */
        private void actualiserBarre(int numExo, int nbExo)
        {
            //Déclaration et initialisation des variables
            const int xEndPosition = 525;
            double ecart = (double)xEndPosition / (nbExo - 1);
            double i;

            //Clear de la barre de progression précédente
            pnlProgressBar.Controls.Clear();

            //Affichage des exercices terminés
            for (i = 0; i < (numExo-1); i++)
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(25, 25);
                picBox.BackColor = Color.Transparent;
                picBox.Image = imgListProgressBar.Images[0];
                picBox.Top = 0;
                picBox.Left = (int)Math.Round(i * ecart);

                pnlProgressBar.Controls.Add(picBox);
            }
            //Affichage de l'exercice suivant à faire
            if (i < nbExo)
            {
                PictureBox picBox2 = new PictureBox();
                picBox2.Size = new Size(25, 25);
                picBox2.BackColor = Color.Transparent;
                picBox2.Image = imgListProgressBar.Images[1];
                picBox2.Top = 0;
                picBox2.Left = (int)Math.Round(i * ecart);

                pnlProgressBar.Controls.Add(picBox2);

                i++;

                //Affichage des exercices suivants restants dans la leçon
                while (i < nbExo)
                {
                    PictureBox picBox3 = new PictureBox();
                    picBox3.Size = new Size(25, 25);
                    picBox3.BackColor = Color.Transparent;
                    picBox3.Image = imgListProgressBar.Images[2];
                    picBox3.Top = 0;
                    picBox3.Left = (int)Math.Round(i * ecart);

                    pnlProgressBar.Controls.Add(picBox3);

                    i++;
                }
            }
        }

        /*
         * Procédure changeInformations qui recherche et actualise les informations liées à un
         * utilisateur et les affiche
         */
        public void changeInformations()
        {
            con.ConnectionString = CONNECTION_STRING;

            try
            {
                //Ouverture de la connexion
                con.Open();

                //Remplissage d'une DataTable avec les informations d'un exercice
                string request = @"SELECT C.titreCours, L.titreLecon, L.commentLecon, U.codeExo, C.numCours, L.numLecon
                            FROM ((Utilisateurs U INNER JOIN Cours C
                            ON U.codeCours = C.numCours)
                            LEFT JOIN Lecons L
                            ON L.numLecon = U.codeLeçon AND L.numCours = U.codeCours)
                            WHERE U.codeUtil = " + codeUtil;

                DataTable dt = new DataTable();
                OleDbCommand cd = new OleDbCommand(request, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cd);

                da.SelectCommand = cd;
                da.Fill(dt);

                //Actualisation des informations dans la classe Exercice
                exo.numeroExercice = dt.Rows[0].Field<int>(3);
                exo.numeroLecon = dt.Rows[0].Field<int>(5);
                exo.numeroCours = dt.Rows[0].Field<string>(4);

                int nombreExercices = exo.calculerNbExo();

                //Actualisation des informations à afficher
                lblCoursActu.Text = dt.Rows[0].Field<string>(0);
                lblLeconActu.Text = dt.Rows[0].Field<string>(1);
                lblLeconCom.Text = dt.Rows[0].Field<string>(2);
                lblExoFiniNb.Text = (dt.Rows[0].Field<int>(3) - 1).ToString();
                lblExoFiniNb.Text += "/" + nombreExercices;


                /** Actualisation des différentes informations d'affichage */
                //Description
                actualiserDescription();

                //Barre de progression
                actualiserBarre(dt.Rows[0].Field<int>(3), nombreExercices);

                //Bouton administrateur
                administrateur(codeUtil);

                //Bouton de commencement des exercices
                commencerExo();
            }
            catch (Exception ex)
            {
                //Affichage d'une erreur
                MessageBox.Show("Error: " +ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //Fermeture de la connexion
                con.Close();
            }
        }

        /*
         * Procédure administateur qui actualise le bouton Administrateur en visible / invisible selon l'utilisateur
         * Paramètres :
         *   util: int: code de l'utilisateur
         */
        private void administrateur(int util)
        {
            //Si l'utilisateur est un administrateur
            if (admins.Contains(util))
                //Bouton administrateur visible
                btnAdmin.Show();
            //Sinon
            else
                //Bouton administrateur invisible
                btnAdmin.Hide();
        }

        /*
         * Procédure actualiserDescription qui détermine si le label Description est visible ou non selon le contenu du commentaire
         */
        private void actualiserDescription()
        {
            //Si la description est vide
            if (lblLeconCom.Text == String.Empty)
            {
                //Label "Description" invisible
                lblDescription.Hide();
            }
            //Sinon
            else
            {
                //Label "Description" visible
                lblDescription.Show();

                //Si la description est trop longue pour l'affichage
                if (lblLeconCom.Text.Length > 35)
                {
                    //Découpage
                    lblLeconCom.Text = lblLeconCom.Text.Substring(0, 35) + "...";
                }
            }
        }

        /*
         * Procédure actualiserBase qui actualise la base avec les nouvelles données de l'utilisateur
         */
        private void actualiserBase()
        {
            try
            {
                //Ouverture de la connexion
                con.Open();

                //Actualisation des données de l'utilisateur dans la base
                string request = @"UPDATE Utilisateurs
                                    SET
                                     codeExo = " + exo.numeroExercice +", " +
                                    "codeLeçon = " + exo.numeroLecon +", " +
                                    "codeCours = '" +exo.numeroCours +"' " +
                                  "WHERE codeUtil = " + codeUtil;

                OleDbCommand cd = new OleDbCommand(request, con);
                cd.ExecuteNonQuery();
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
         * Procédure remplirProgression qui remplit le panel de la progression
         */
        private void remplirProgression()
        {
            //Clear de l'affichage précédent
            pnlProgression.Controls.Clear();

            //Variables de positionnement
            int yPosition = 10;
            const int xStartPosition = 5;
            const int xEcartLecon = 10;
            const int yEcartApresCours = 18;
            const int yEcartApresLecon = 15;

            //Pour chaque cours, triés par numéro
            foreach (DataRow drCours in exo.ds.Tables["Cours"].Select($"","numCours"))
            {
                //Création d'un label contenant le nom du cours
                Label lblCours = new Label();
                lblCours.AutoSize = true;
                lblCours.Top = yPosition;
                lblCours.Left = xStartPosition;
                lblCours.Font = new Font("Arial", 11, FontStyle.Bold);
                lblCours.Text = drCours["titreCours"].ToString();

                //Si sa longueur dépasse la limite affichable
                if (lblCours.Text.Length > 20)
                {
                    //Découpe du nom
                    lblCours.Text = lblCours.Text.Substring(0, 20) + "...";
                }

                //Si c'est le cours actuel de l'utilisateur
                if (drCours["numCours"].ToString() == exo.numeroCours)
                {
                    //Couleur rouge
                    lblCours.ForeColor = Color.Red;
                }
                //Sinon
                else
                {
                    //Couleur blanche
                    lblCours.ForeColor = Color.White;
                }

                //Ajout du label au panel de la progression
                pnlProgression.Controls.Add(lblCours);

                //Actualisation de la position verticale
                yPosition += yEcartApresCours;

                //Pour chaque leçons dans le cours, triées par numéro
                foreach (DataRow drLecon in exo.ds.Tables["Lecons"].Select($"numCours='{drCours["numCours"]}'","numLecon"))
                {
                    //Création d'un label contenant le titre de la leçon
                    Label lblLecon = new Label();
                    lblLecon.AutoSize = true;
                    lblLecon.Top = yPosition;
                    lblLecon.Left = xStartPosition + xEcartLecon;
                    lblLecon.Font = new Font("Arial", 9, FontStyle.Regular);
                    lblLecon.Text = drLecon["titreLecon"].ToString();

                    //Si sa longueur dépasse la limite affichable
                    if (lblLecon.Text.Length > 25)
                    {
                        //Découpe du titre
                        lblLecon.Text = lblLecon.Text.Substring(0, 25) + "...";
                    }

                    //Si c'est la leçon actuelle de l'utilisateur
                    if (Convert.ToInt32(drLecon["numLecon"]) == exo.numeroLecon
                        && drLecon["numCours"].ToString() == exo.numeroCours)
                    {
                        //Couleur rouge
                        lblLecon.ForeColor = Color.LightCoral;
                    }
                    //Sinon
                    else
                    {
                        //Couleur blanche
                        lblLecon.ForeColor = Color.LightGray;
                    }

                    //Ajout du label au panel de la progression
                    pnlProgression.Controls.Add(lblLecon);

                    //Actualisation de la position verticale
                    yPosition += yEcartApresLecon;
                }

            }
        }
    }
}
