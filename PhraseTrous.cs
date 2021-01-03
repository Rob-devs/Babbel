using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Mini_projet_Babbel
{
    /*
     * Formulaire d'exercice de phrase à trous
     */
    public partial class PhraseTrous : Form
    {
        //Déclaration et initialisation des objets et variables globales
        string[] phrases = new string[2];

        bool validation = false;

        List<string> mots = new List<string>();
        List<string> motsCaches = new List<string>();
        List<int> posTrous = new List<int>();

        Exercice exo = new Exercice();

        //Création d'une DataRow contenant les résultats
        DataRow dr;

        //Création d'une DataRow contenant les valeurs par défaut
        public DataRow drClose;

        public PhraseTrous(Exercice exo, DataTable tblRes)
        {
            InitializeComponent();
            this.exo = exo;

            //Initialisation de la DataRow concernant la réussite de l'exercice
            dr = tblRes.NewRow();

            dr[0] = exo.numeroExercice;
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
        private void PhraseTrous_Load(object sender, EventArgs e)
        {
            //Actualisation des titres et de l'énoncé
            lblTitreCours.Text = exo.titreCours();
            lblTitreLecon.Text = exo.titreLecon();
            lblEnonceActu.Text = exo.detEnonce();

            //Affichage de la règle si disponible
            lblRegleActu.Text = exo.detRegle();
            if (lblRegleActu.Text != string.Empty)
                lblRegle.Visible = true;

            //Obtention de la phrase et de sa traduction
            phrases = exo.detPhrases();

            //Affichage de la traduction de la phrase
            lblTraducPhrase.Text = "\"" + phrases[1] + "\"";

            //Détermination de la liste des mots et des positions des trous
            remplirListeMots();
            posTrous = exo.detNumMotsCaches();

            //Affichage de l'exercice
            afficherPhraseTrous();

            //Règlages des mots attendus de l'utilisateur
            ajusterMotsCaches();
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
            //Variables locales à la procédure
            validation = true;

            bool activerSolution = false;

            //Désactivation du bouton vérifier
            btnVerif.Enabled = false;
            btnVerif.BackgroundImage = Properties.Resources.button3;

            //Activation du bouton valider
            btnValider.Enabled = true;

            //Pour tous les textBox à remplir
            foreach (TextBox txtB in pnlPhrase.Controls.OfType<TextBox>())
            {
                //Si le mot inscrit par l'utilisateur est celui attendu
                if (string.Compare(txtB.Text.ToLower(), motsCaches[Convert.ToInt32(txtB.Tag)].ToLower(), CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) == 0)
                {
                    txtB.BackColor = Color.LimeGreen;
                    txtB.Text = motsCaches[Convert.ToInt32(txtB.Tag)];
                }
                //Sinon
                else
                {
                    activerSolution = true;
                    txtB.BackColor = Color.IndianRed;

                    List<string> listRepUtil = (List<string>)dr[4];
                    listRepUtil.Add(txtB.Text);
                    dr[4] = listRepUtil;

                    List<string> listRepSolut = (List<string>)dr[5];
                    listRepSolut.Add(motsCaches[Convert.ToInt32(txtB.Tag)]);
                    dr[5] = listRepSolut;
                }
                txtB.ReadOnly = true;
            }

            //Si au moins une textBox n'est pas juste
            if (activerSolution)
            {
                //Activation du bouton solution
                btnSolution.BackgroundImage = Properties.Resources.button2;
                btnSolution.ForeColor = Color.White;

                btnValider.ForeColor = Color.Black;
                btnValider.BackgroundImage = Properties.Resources.button1;
            }
            //Sinon
            else
            {
                //Désactivation du bouton solution
                btnSolution.Enabled = false;
                btnSolution.BackgroundImage = Properties.Resources.button3;

                btnValider.ForeColor = Color.White;
                btnValider.BackgroundImage = Properties.Resources.button2;

                dr[1] = true;
            }
        }

        /*
         * Click sur le bouton "Solution"
         * L'utilisateur veut afficher la solution
         */
        private void BtnSolution_Click(object sender, EventArgs e)
        { 
            if (!validation)
            {
                dr[1] = false;
                dr[2] = true;
            }

            //Variable locale à la procédure
            validation = true;

            //Désactivation du bouton solution
            btnSolution.Enabled = false;
            btnSolution.BackgroundImage = Properties.Resources.button3;
            btnSolution.ForeColor = Color.White;

            //Désactivation du bouton vérifier
            btnVerif.Enabled = false;
            btnVerif.BackgroundImage = Properties.Resources.button3;

            //Activation du bouton valider
            btnValider.Enabled = true;
            btnValider.BackgroundImage = Properties.Resources.button2;
            btnValider.ForeColor = Color.White;

            //Pour toutes les textBox à remplir
            foreach (TextBox txtB in pnlPhrase.Controls.OfType<TextBox>())
            {
                //Si incorrects ou non vérifiée
                if (txtB.BackColor != Color.LimeGreen)
                {
                    //Affichage de la correction
                    txtB.BackColor = Color.Goldenrod;
                    txtB.Text = motsCaches[Convert.ToInt32(txtB.Tag)];
                }
                txtB.ReadOnly = true;
            }
        }

        /*
         * Lorsque qu'un caractère est tapé par l'utilisateur
         */
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Autorisation des lettres, du retour et de la tabulation ; réfutation des autres touches
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }

        /*
         * Lorsque le contenu d'une textBox est changé
         */
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //Si l'utilisateur n'a pas encore vérifié ses réponses
            if (!validation)
            {
                bool activer = true;

                foreach (TextBox txtB in pnlPhrase.Controls.OfType<TextBox>())
                {
                    if (txtB.Text == string.Empty)
                    {
                        activer = false;
                    }
                }

                //Si au moins une textBox est vide
                if (activer)
                {
                    //Désactivation du bouton vérifier
                    btnVerif.Enabled = true;
                    btnVerif.BackgroundImage = Properties.Resources.button2;
                }
                //Sinon
                else
                {
                    //Activation du bouton vérifier
                    btnVerif.Enabled = false;
                    btnVerif.BackgroundImage = Properties.Resources.button3;
                }
            }
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure ajusterMotsCaches qui enlève les caractères parasites dans
         * les mots que l'utilisateur doit trouver
         */
        private void ajusterMotsCaches()
        {
            //Variables locales à la procédure
            List<string> motsAjustes = new List<string>();
            string motAjsute;

            //Pour tous les mots cachés
            foreach (string mot in motsCaches)
            {
                motAjsute = mot;

                //Si le mot commencer par ¿
                if (mot[0] == '¿')
                {
                    //Suppression du premier caractère
                    motAjsute = mot.Substring(1);
                }
                //Si le mot se termine par un caractère différent d'une lettre
                if (!char.IsLetter(mot[mot.Length - 1]))
                {
                    //Suppression du dernier caractère
                    motAjsute = mot.Substring(0, mot.Length - 1);
                }

                //Ajout du mot modifié
                motsAjustes.Add(motAjsute);
            }

            //Actualisation de la liste avec les mots modifiés
            motsCaches = motsAjustes;
        }

        /*
         * Procédure remplirListeMots qui remplit la liste avec les mots composants la phrase
         * et enlève les mots parasites
         */
        private void remplirListeMots()
        {
            //Pour tous les mots dans la phrase, séparés par des espaces
            foreach (string mot in phrases[0].Split(' '))
            {
                //Ajout du mot à la liste des mots
                mots.Add(mot);
            }

            //Pour chaque mot dans la liste des mots
            foreach (string mot in mots)
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
         * Procédure afficherPhraseTrous qui affiche dynamiquement les composants
         * constituants la phrase à trous
         */
        private void afficherPhraseTrous()
        {
            //Variables de positionnement
            int xPosition = 10;
            int yPosition = 10;

            const int ecart = 2;
            const int xMaxPosition = 422;

            int tag = 0;

            //Pour chaque mot de la phrase
            foreach (string mot in mots)
            {
                //Si c'est un mot à cacher
                if (posTrous.Contains(mots.IndexOf(mot)+1))
                {
                    string charAvant = string.Empty;
                    string charApres = string.Empty;

                    //Si le premier caractère n'est pas une lettre
                    if (!Char.IsLetter(mot[0]))
                    {
                        charAvant = mot[0].ToString();
                        mot.Substring(1);
                    }

                    //Si le dernier caractère n'est pas une lettre
                    if (!Char.IsLetter(mot[mot.Length - 1]))
                    {
                        charApres = mot[mot.Length - 1].ToString();
                        mot.Substring(0, mot.Length - 1);
                    }

                    //Cration d'un label pour le caractère précédent la textBox
                    Label lblCharAvant = new Label();
                    lblCharAvant.AutoSize = true;
                    lblCharAvant.Font = new Font("Arial", 11, FontStyle.Regular);
                    lblCharAvant.ForeColor = Color.White;
                    lblCharAvant.Text = charAvant;

                    //Cration d'un label pour le caractère suivant la textBox
                    Label lblCharApres = new Label();
                    lblCharApres.AutoSize = true;
                    lblCharApres.Font = new Font("Arial", 11, FontStyle.Regular);
                    lblCharApres.ForeColor = Color.White;
                    lblCharApres.Text = charApres;

                    //Création d'une textBox
                    TextBox txtBox = new TextBox();
                    txtBox.Size = new Size(120, 22);
                    txtBox.Font = new Font("Arial", 10, FontStyle.Regular);
                    txtBox.ForeColor = Color.Black;
                    txtBox.MaxLength = 15;
                    txtBox.TextAlign = HorizontalAlignment.Center;
                    txtBox.Tag = tag;
                    tag++;
                    txtBox.KeyPress += new KeyPressEventHandler(this.textBox_KeyPress);
                    txtBox.TextChanged += new EventHandler(this.textBox_TextChanged);

                    //Ajout des nouveux contrôles au panel de la phrase
                    pnlPhrase.Controls.Add(lblCharAvant);
                    pnlPhrase.Controls.Add(txtBox);
                    pnlPhrase.Controls.Add(lblCharApres);

                    //S'il n'y a pas la place pour ajouter la textBox à la ligne
                    if (xPosition + txtBox.Width + lblCharAvant.Width + lblCharApres.Width + 10 >= xMaxPosition)
                    {
                        //Passage à la ligne suivante
                        yPosition += 30;
                        xPosition = 10;
                    }

                    //Définition des positions des contrôles
                    lblCharAvant.Top = yPosition;
                    lblCharAvant.Left = xPosition;

                    txtBox.Top = yPosition;
                    txtBox.Left = xPosition + lblCharAvant.Width;

                    lblCharApres.Top = yPosition;
                    lblCharApres.Left = xPosition + lblCharAvant.Width + txtBox.Width;

                    //Actualisation de la position horizontale
                    xPosition += ecart + txtBox.Width + lblCharAvant.Width + lblCharApres.Width;


                    //Ajout du mot à la liste des mots que l'utilisateur doit trouver
                    motsCaches.Add(mot);

                }
                //Sinon, si c'est un mot à afficher
                else
                {
                    //Création d'un label pour le mot
                    Label lblMot = new Label();
                    lblMot.AutoSize = true;
                    lblMot.Font = new Font("Arial", 11, FontStyle.Regular);
                    lblMot.ForeColor = Color.White;
                    lblMot.Text = mot.ToString();
                    //Ajout du label au panel de la phrase
                    pnlPhrase.Controls.Add(lblMot);

                    //S'il n'y a pas la place pour ajouter le label à la ligne
                    if (xPosition + lblMot.Width + 10 >= xMaxPosition)
                    {
                        //Passage à la ligne suivante
                        yPosition += 30;
                        xPosition = 10;
                    }

                    //Définition des positions du contrôle
                    lblMot.Top = yPosition;
                    lblMot.Left = xPosition;

                    //Actualisation de la position horizontale
                    xPosition += ecart + lblMot.Width;
                }
            }
        }

    }
}
