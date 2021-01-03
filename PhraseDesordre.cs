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
     * Formulaire d'exercice de phrase en désordre
     */
    public partial class PhraseDesordre : Form
    {
        //Déclaration et initialisation des objets et variables globales
        string[] phrases = new string[2];

        int nbMotsBienPlace = 0;

        bool verification = false;

        List<string> motsOrdre = new List<string>();
        List<string> motsDesordre = new List<string>();
        List<string> motsAffiches = new List<string>();
        List<int> tagsAffiches = new List<int>();

        Exercice exo = new Exercice();

        //Création d'une DataRow contenant les résultats
        DataRow dr;

        //Création d'une DataRow contenant les valeurs par défaut
        public DataRow drClose;

        public PhraseDesordre(Exercice exo, DataTable tblRes)
        {
            InitializeComponent();
            this.exo = exo;

            //Initialisation de la DataRow concernant la réussite de l'exercice
            dr = tblRes.NewRow();

            dr[0] = this.exo.numeroExercice;
            dr[1] = false;
            dr[2] = false;
            dr[3] = 0;
            dr[4] = new List<string>();
            dr[5] = new List<string>();

            drClose = dr;
        }

        /******************************************************************************/
        /* CONTRÔLES                                                                  */
        /******************************************************************************/
        /*
         * Au lancement du formulaire
         */
        private void PhraseDesordre_Load(object sender, EventArgs e)
        {
            //Actualisation des titres et de l'énoncé
            lblTitreCours.Text = exo.titreCours();
            lblTitreLecon.Text = exo.titreLecon();
            lblEnonceActu.Text = exo.detEnonce();

            //Affichage de la règle si disponible
            lblRegleActu.Text = exo.detRegle();
            if (lblRegleActu.Text != string.Empty)
                lblRegle.Visible = true;

            lblPhrase.Text = string.Empty;

            //Obtention de la phrase et de sa traduction
            phrases = exo.detPhrases();

            //Affichage de la traduction de la phrase
            lblTraducPhrase.Text = "\"" + phrases[1] + "\"";

            //Détermination de la liste des mots et mélange
            remplirListeMots(motsOrdre);
            remplirListeMots(motsDesordre);
            melangerMots(motsDesordre);

            //Affichage de l'exercice
            afficherPhraseDesordre();
        }

        /*
         * Click sur le bouton "Valider"
         * L'utilisateur veut terminer l'exercice
         */
        private void BtnValider_Click(object sender, EventArgs e)
        {
            drClose = dr;
            this.Close();
        }

        /*
         * Click sur le bouton "Vérifier"
         * L'utilisateur veut vérifier ses réponses
         */
        private void BtnVerif_Click(object sender, EventArgs e)
        {
            bool solution = false;

            verification = true;

            //Pour chaque bouton généré
            foreach (Button btn in pnlBoutons.Controls.OfType<Button>())
            {
                //Si le mot est placé au bon endroit
                if (bienPlace(Convert.ToInt32(btn.Tag)))
                {
                    nbMotsBienPlace++;
                    btn.BackColor = Color.LightGreen;
                    btn.FlatAppearance.BorderColor = Color.LimeGreen;
                }
                //Sinon
                else
                {
                    btn.BackColor = Color.LightCoral;
                    btn.FlatAppearance.BorderColor = Color.IndianRed;
                    solution = true;
                }
            }

            //Affichage du nombre d'erreurs
            afficherNbErreurs();

            //Actualisation des boutons
            if (solution)
            {
                btnSolution.BackgroundImage = Properties.Resources.button2;

                btnValider.BackgroundImage = Properties.Resources.button1;
                btnValider.ForeColor = Color.Black;

                dr[3] = motsOrdre.Count - nbMotsBienPlace;
            }
            else
            {
                btnSolution.Enabled = false;
                btnSolution.BackgroundImage = Properties.Resources.button3;

                btnValider.BackgroundImage = Properties.Resources.button2;

                dr[1] = true;
            }
            btnSolution.ForeColor = Color.White;

            btnVerif.Enabled = false;
            btnVerif.BackgroundImage = Properties.Resources.button3;

            btnValider.Enabled = true;

            btnRecommencer.Enabled = false;
            btnRecommencer.BackgroundImage = Properties.Resources.button3;
            btnRecommencer.ForeColor = Color.White;
        }

        /*
         * Click sur le bouton "Solution"
         * L'utilisateur veut afficher la solution
         */
        private void BtnSolution_Click(object sender, EventArgs e)
        {
            //Affichage de la solution
            lblPhrase.Text = phrases[0];

            //Si l'utilisateur n'as pas encore vérifié
            if (!verification)
            {
                //Affichage du nombre d'erreurs
                afficherNbErreurs();

                //Changement de couleur des boutons
                foreach (Button btn in pnlBoutons.Controls.OfType<Button>())
                {
                    btn.BackColor = Color.Goldenrod;
                    btn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
                }

                dr[2] = true;
                verification = true;
            }
            //Sinon
            else
            {
                //Changement de couleur des boutons
                foreach (Button btn in pnlBoutons.Controls.OfType<Button>())
                {
                    if (btn.BackColor == Color.LightCoral)
                    {
                        btn.BackColor = Color.Goldenrod;
                        btn.FlatAppearance.BorderColor = Color.DarkGoldenrod;
                    }
                }
            }

            //Actualisation des boutons
            btnSolution.Enabled = false;
            btnSolution.BackgroundImage = Properties.Resources.button3;
            btnSolution.ForeColor = Color.White;

            btnRecommencer.Enabled = false;
            btnRecommencer.BackgroundImage = Properties.Resources.button3;
            btnRecommencer.ForeColor = Color.White;

            btnValider.Enabled = true;
            btnValider.BackgroundImage = Properties.Resources.button2;
            btnValider.ForeColor = Color.White;

            btnVerif.Enabled = false;
            btnVerif.BackgroundImage = Properties.Resources.button3;
        }

        /*
         * Click sur le bouton "Recommencer"
         * L'utilisateur veut recommencer l'exercice
         */
        private void BtnRecommencer_Click(object sender, EventArgs e)
        {
            //Pour chaque bouton généré
            foreach (Button btn in pnlBoutons.Controls.OfType<Button>())
            {
                //Réinitialisation
                btn.BackColor = Color.White;
                btn.FlatAppearance.BorderColor = Color.Silver;
            }

            //Clear de la phrase précédente
            lblPhrase.Text = string.Empty;
            motsAffiches.Clear();
            tagsAffiches.Clear();

            //Actualisation du bouton vérifier
            verifBtnVerifier();
        }

        /*
         * Click sur un bouton généré dynamiquement
         * L'utilisateur veut ajouter le mot dans sa réponse
         */
        private void button_Click(object sender, EventArgs e)
        {
            //Si le bouton est de couleur blanc
            if (((Button)sender).BackColor == Color.White && !tagsAffiches.Contains(Convert.ToInt32(((Button)sender).Tag)))
            {
                //Bouton de couleur gris
                ((Button)sender).BackColor = Color.DimGray;
                ((Button)sender).FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);

                //Le mot est ajouté
                motsAffiches.Add(((Button)sender).Text);
                tagsAffiches.Add(Convert.ToInt32(((Button)sender).Tag));
            }
            //Si le bouton est de couleur gris
            else if (((Button)sender).BackColor == Color.DimGray && tagsAffiches.Contains(Convert.ToInt32(((Button)sender).Tag)))
            {
                //Bouton de couleur blanc
                ((Button)sender).BackColor = Color.White;
                ((Button)sender).FlatAppearance.BorderColor = Color.Silver;

                //Le mot est retiré
                motsAffiches.RemoveAt(tagsAffiches.IndexOf(Convert.ToInt32(((Button)sender).Tag)));
                tagsAffiches.Remove(Convert.ToInt32(((Button)sender).Tag));
            }

            if (!verification)
            {
                verifBtnVerifier();
                actualiserPhrase();
            }
            
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure remplirListeMots qui remplit la liste envoyée en paramètre avec les mots de la phrase
         * Paramètres:
         *      mots: List<string>: liste à remplir
         */
        private void remplirListeMots(List<string> mots)
        {
            //Pour tous les mots dans la phrase, séparés par des espaces
            foreach (string mot in phrases[0].Split(' '))
            {
                //Ajout du mot à la liste des mots
                mots.Add(mot);
            }

            string[] copieMots = mots.ToArray();

            //Pour chaque mot dans la liste des mots
            foreach (string mot in copieMots)
            {
                //Si le mot est un ? / , / . / ! / :
                if (mot == "?" || mot == "," || mot == "." || mot == "!" || mot == ":"
                    && mots.IndexOf(mot) != 0)
                {
                    //Collage du mot au précédent
                    mots[mots.IndexOf(mot) - 1] += mot;
                    mots.RemoveAt(mots.IndexOf(mot));
                }
            }
        }

        /*
         * Procédure melangerMots qui mélange aléatoirement la liste envoyée en paramètre
         * Paramètres:
         *      mots: List<string>: liste à mélanger
         */
        private void melangerMots(List<string> mots)
        {
            Random rdm = new Random();

            //Pour autant de fois que la liste a de mots
            for (int i = 0; i < mots.Count; i++)
            {
                //Nouvelle valeur intermédiaire
                int valRandom = rdm.Next(i, mots.Count);

                //Échange de valeurs
                string nouvMot = mots[i];
                mots[i] = mots[valRandom];
                mots[valRandom] = nouvMot;
            }
        }

        /*
         * Fonction bienPlace qui renvoie true si le mot envoyé en paramètre est bien placé dans
         * la phrase crée par l'utilisateur
         * Paramères:
         *      mot: string: mot à tester
         */
        private bool bienPlace(int tagMot)
        {
            //Comparaison de la phrase en ordre et de la phrase crée par l'utilisateur
            return (motsAffiches[tagsAffiches.IndexOf(tagMot)] == motsOrdre[tagsAffiches.IndexOf(tagMot)]);
        }

        /*
         * Procédure afficherPhraseDesordre qui génère les boutons dynamiquement
         */
        private void afficherPhraseDesordre()
        {
            //Variables de positionnement
            int xStartPosition = 0;
            int yPosition = 10;
            int xPosition;
            const int xButtonSize = 80;
            const int yButtonSize = 30;
            const int xEcart = 10;
            const int yEcart = 5;

            int nbMots = motsOrdre.Count;

            //Si le nombre de mots dans la phrase dépasse 8
            if (nbMots > 8)
            {
                //Blocage du maximum de boutons sur une ligne à 8
                xStartPosition = (pnlControles.Width - (xEcart + xButtonSize) * 8) / 2;
                nbMots -= 8;
            }
            //Sinon
            else
            {
                xStartPosition = (pnlControles.Width - (xEcart + xButtonSize) * nbMots) / 2;
            }

            xPosition = xStartPosition;
            int i = 0;

            //Pour chaque mot dans la liste en désordre
            foreach (string mot in motsDesordre)
            {
                //Création d'un nouveau bouton
                Button btnMot = new Button();
                btnMot.Size = new Size(xButtonSize, yButtonSize);
                btnMot.Text = mot;
                btnMot.Tag = i;
                //Apparence
                btnMot.BackColor = Color.White;
                btnMot.ForeColor = Color.Black;
                btnMot.FlatStyle = FlatStyle.Flat;
                btnMot.FlatAppearance.BorderSize = 2;
                btnMot.FlatAppearance.BorderColor = Color.Silver;
                btnMot.TextAlign = ContentAlignment.MiddleCenter;
                //Position
                btnMot.Top = yPosition;
                btnMot.Left = xPosition;
                //Ajout d'un évènement click
                btnMot.Click += new EventHandler(button_Click);

                //Ajout du bouton au panel principal
                pnlBoutons.Controls.Add(btnMot);

                //Si la ligne est surchargée
                if (xPosition > 7 * (xEcart + xButtonSize))
                {
                    //Passage à la ligne suivante
                    yPosition += (yEcart + yButtonSize);

                    //Si le nombre de mots restants dans la phrase dépasse 8
                    if (nbMots > 8)
                    {
                        //Blocage du maximum de boutons sur une ligne à 8
                        xStartPosition = (pnlControles.Width - (xEcart + xButtonSize) * 8) / 2;
                        nbMots -= 8;
                    }
                    //Sinon
                    else
                    {
                        xStartPosition = (pnlControles.Width - (xEcart + xButtonSize) * nbMots) / 2;
                    }

                    xPosition = xStartPosition;
                } 
                //Sinon
                else
                {
                    //Mise à jour de la position suivante
                    xPosition += (xEcart + xButtonSize);
                }

                i++;
            }
        }

        /*
         * Procédure verifBtnVerifier qui actualise le bouton vérifier lorsque tous les boutons sont cliqués
         */
        private void verifBtnVerifier()
        {
            bool verifier = true;

            //Pour chaque bouton généré
            foreach (Button btn in pnlBoutons.Controls.OfType<Button>())
            {
                //S'il n'est pas cliqué
                if (btn.BackColor == Color.White)
                {
                    //La vérification n'est pas possible
                    verifier = false;
                }
            }

            //Si la vérification est possible
            if (verifier)
            {
                //Activation du bouton vérifier
                btnVerif.Enabled = true;
                btnVerif.BackgroundImage = btnVerif.BackgroundImage = Properties.Resources.button2;
            }
            //Sinon
            else
            {
                //Désactivation du bouton vérifier
                btnVerif.Enabled = false;
                btnVerif.BackgroundImage = btnVerif.BackgroundImage = Properties.Resources.button3;
            }
        }

        /*
         * Procédure actualiserPhrase qui constitue la phrase réponse crée par l'utilisateur en fonction
         * de l'ordre dans lequel il a cliqué sur les boutons
         */
        private void actualiserPhrase()
        {
            string phrase = string.Empty;

            //Pour chaque mot dans la liste des mots cliqués
            foreach (int tagMot in tagsAffiches)
            {
                //Ajout à la phrase
                phrase += motsAffiches[tagsAffiches.IndexOf(tagMot)];
                
                //Si ce n'est pas le dernier mot de la liste
                if (tagMot != tagsAffiches[tagsAffiches.Count - 1])
                {
                    //Ajout d'un espace de séparation
                    phrase += " ";
                }
            }

            lblPhrase.Text = phrase;
        }

        /*
         * Procédure afficherNbErreurs qui affiche le nombre de mots bien placés dans la phrase
         */
        private void afficherNbErreurs()
        {
            lblNbErreurs.Text = nbMotsBienPlace.ToString() + "/" + motsOrdre.Count.ToString() + " mots bien placés";
            lblNbErreurs.Visible = true;
        }
    }
}
