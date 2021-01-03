using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_projet_Babbel
{
    /*
     * Formulaire de fin d'exercice, gérant la décision de l'utilisateur et le récap de la leçon
     */
    public partial class formRecap : Form
    {
        //Déclaration et initialisation des objets et variables globales
        Exercice exo = new Exercice();

        //DataTable contenant les résultats de l'utilisateur
        DataTable tableResultats;

        public formRecap(Exercice exo)
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
        private void FormRecap_Load(object sender, EventArgs e)
        {
            tableResultats = exo.tblRes;

            //Actualisation de la progress bar
            actualiserBarre(exo.numeroExercice, exo.nombreExercice);

            //Actualisation des données de l'exercice en cours
            lblExoFiniNb.Text = exo.numeroExercice.ToString() + "/" + exo.nombreExercice.ToString();
            lblCoursActu.Text = exo.numeroCours;
            lblLeconActu.Text = exo.numeroLecon.ToString() + "/" + exo.nombreLecon.ToString();

            //Si l'exercice terminé est le dernier de la leçon
            if (exo.numeroExercice == exo.nombreExercice)
            {
                btnSuivant.Text = "Leçon suivante";
                btnRecommencer.Visible = true;

                //Affichage du menu de récap
                lblRecap.Show();
                pnlPros.Show();
                pnlCons.Show();

                //Image d'une barre séparant les réussites et les erreurs
                picBoxBook.Image = imgListMilieu.Images[1];

                //Ajout des informations du récap dans les panels correspondant
                ajouterInfos();
            }
            //Sinon
            else
            {
                //Image par défaut
                picBoxBook.Image = imgListMilieu.Images[0];
            }

            //Si c'est le tout dernier exercice
            if (exo.dernierExo())
                //Bouton "exercice suivant" retiré
                btnSuivant.Hide();
        }

        /*
         * Click sur le bouton "Terminer"
         * L'utilisateur veut arrêter sa session d'exercices
         */
        private void BtnTerminer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /*
         * Click sur le bouton "Exercice suivant" / "Leçon suivante"
         * L'utilisateur veut continuer sa session d'exercices
         */
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
         * Click sur le bouton "Reommcner"
         * L'utilisateur veut recommencer sa session d'exercices
         */
        private void BtnRecommencer_Click(object sender, EventArgs e)
        {
            exo.numeroExercice = 0;
            exo.clearTableRes();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure ajouterInfos qui ajoute les infos du récap de la leçon dans
         * les panels correspondants
         */
        private void ajouterInfos()
        {
            //Variables de positionnement
            int yPosition = 8;
            const int xPosition = 8;
            const int yEcartApresNum = 22;
            const int yTailleLigne = 15;

            //Pour toutes les lignes de la table de récap
            foreach (DataRow dr in tableResultats.Rows)
            {
                //Si l'exercice est réussit
                if ((bool)dr[1] == true)
                {
                    //Création du label du numéoro de l'exercice
                    Label lblNumExo = new Label();
                    lblNumExo.AutoSize = true;
                    lblNumExo.Text = "Exercice " + dr[0].ToString() + " :";
                    lblNumExo.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
                    lblNumExo.Top = yPosition;
                    lblNumExo.Left = xPosition;
                    lblNumExo.ForeColor = Color.PaleGreen;
                    //Ajout du label au panel correspondant
                    pnlTextPros.Controls.Add(lblNumExo);

                    //Mise à jour de la position suivante
                    yPosition += yEcartApresNum;

                    //Création du label des détails concernants l'exercice
                    Label lblDetails = new Label();
                    lblDetails.AutoSize = true;
                    lblDetails.Text = "Exercice réussit !";
                    lblDetails.Text += "\n";
                    lblDetails.Font = new Font("Arial", 9, FontStyle.Italic);
                    lblDetails.Top = yPosition;
                    lblDetails.Left = xPosition + 4;
                    lblDetails.ForeColor = Color.LawnGreen;
                    //Ajout du label au panel correspondant
                    pnlTextPros.Controls.Add(lblDetails);

                    //Mise à jour de la position suivante
                    yPosition += yTailleLigne * 2;

                    //Ajout d'un retour à la ligne pour plus de visibilité
                    lblDetails.Text += "\n";
                }
            }

            //Réinitialisation de la position de départ pour l'autre panel
            yPosition = 8;

            //Pour toutes les lignes de la table de récap
            foreach (DataRow dr in tableResultats.Rows)
            {
                //Si l'exercice est raté
                if ((bool)dr[1] == false)
                {
                    //Création du label du numéoro de l'exercice
                    Label lblNumExo = new Label();
                    lblNumExo.AutoSize = true;
                    lblNumExo.Text = "Exercice " + dr[0].ToString() + " :";
                    lblNumExo.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
                    lblNumExo.Top = yPosition;
                    lblNumExo.Left = xPosition;
                    lblNumExo.ForeColor = Color.LightCoral;
                    //Ajout du label au panel correspondant
                    pnlTextCons.Controls.Add(lblNumExo);

                    //Mise à jour de la position suivante
                    yPosition += yEcartApresNum;

                    //Création du label des détails concernants l'exercice
                    Label lblDetails = new Label();
                    lblDetails.AutoSize = true;
                    lblDetails.Font = new Font("Arial", 9, FontStyle.Italic);
                    lblDetails.Top = yPosition;
                    lblDetails.Left = xPosition + 4;
                    lblDetails.ForeColor = Color.IndianRed;

                    //Si la solution a été affichée
                    if ((bool)dr[2] == true)
                    {
                        lblDetails.Text = "Vous avez affiché la solution.";
                        lblDetails.Text += "\n";

                        //Mise à jour de la position suivante
                        yPosition += yTailleLigne * 2;
                    }
                    //Sinon
                    else
                    {
                        //Si c'est un exercice de phrase en désordre
                        if (Convert.ToInt32(dr[3]) != 0)
                        {
                            lblDetails.Text = dr[3].ToString() +" mots mal placés.";
                            lblDetails.Text += "\n";

                            //Mise à jour de la position suivante
                            yPosition += yTailleLigne * 2;
                        }
                        //Sinon, si c'est un exercice de phrase à trous
                        else if (((List<string>)dr[4]).Any())
                        {
                            lblDetails.Text = string.Empty;

                            //Pour tous les mots mal orthographiés
                            for (int i = 0; i < ((List<string>)dr[4]).Count; i++)
                            {
                                //Ajout du mot et de sa solution dans le label
                                lblDetails.Text += "Vous avez écrit : " + ((List<string>)dr[4])[i] + "\n";
                                lblDetails.Text += "Bonne réponse : " + ((List<string>)dr[5])[i] + "\n";

                                //Si ce n'est pas le dernier mot de la liste
                                if (i != ((List<string>)dr[4]).Count - 1)
                                    //Ajout d'un retour à la ligne pour plus de visibilité
                                    lblDetails.Text += "\n";

                                //Mise à jour de la position suivante
                                yPosition += yTailleLigne * 3;
                            }
                        }
                        //Sinon, c'est un exercice non validé
                        else
                        {
                            lblDetails.Text = "Exercice non validé";
                            lblDetails.Text += "\n";

                            //Mise à jour de la position suivante
                            yPosition += yTailleLigne * 2;
                        }
                    }

                    //Ajout d'un retour à la ligne pour plus de visibilité
                    lblDetails.Text += "\n";

                    //Ajout du label au panel correspondant
                    pnlTextCons.Controls.Add(lblDetails);
                }
            }
        }

        /*
         * Procédure actualiserBarre qui affiche dynamiquement la barre de progression
         * Paramètres :
         *   numExo: int: numéro de l'exercice
         *   nbExo: int: nombre d'exercice dans la leçon
         */
        private void actualiserBarre(int numExo, int nbExo)
        {
            //Déclaration et initialisation des variables
            int xEndPosition = 525;
            double ecart = (double)xEndPosition / (nbExo - 1);
            double i;

            //Affichage des exercices terminés
            for (i = 0; i < numExo; i++)
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
    }
}
