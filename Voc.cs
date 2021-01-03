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
     * Formulaire d'exercice de vocabulaire
     */
    public partial class Voc : Form
    {
        //Déclaration et initialisation des objets et variables globales
        string motFr;
        string motEsp;
        string cheminPhoto;
        string origine;

        Exercice exo = new Exercice();

        List<int> numMots = new List<int>();

        public Voc(Exercice exo)
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
        private void Voc_Load(object sender, EventArgs e)
        {
            //Actualisation des titres et de l'énoncé
            lblTitreCours.Text = exo.titreCours();
            lblTitreLecon.Text = exo.titreLecon();
            lblEnonceActu.Text = exo.detEnonce();

            //Remplissage de la liste des mots concernants l'exercice
            numMots = exo.detNumMots();

            //Génération des panels
            genererMots();
        }

        /*
         * Click sur le bouton "Suivant"
         * L'utilisateur a terminé l'exercice
         */
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Lorsque la souris entre dans le panel du mot espagnol
         * Traduction du mot
         */
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            //Peu importe l'activateur de l'évènement, placement sur le panel parent
            Panel pnl = new Panel();
            if (sender is PictureBox)
            {
                pnl = (Panel)((PictureBox)sender).Parent;
            }
            else if (sender is Label)
            {
                pnl = (Panel)(((Label)sender).Parent).Parent;
            }
            //Détermination du mot à traduire à l'aide du tag
            int tag = Convert.ToInt32(pnl.Tag);

            actualiserInfosMots(numMots[tag]);

            //Parcour des contrôles du panel parent
            foreach (Control c in pnl.Controls)
            {
                if (c is Panel)
                {
                    foreach (Label lbl in c.Controls)
                    {
                        if (lbl.Tag != null && (int)lbl.Tag == 1)
                        {
                            //Mot devient français
                            lbl.Text = motFr;
                            lbl.ForeColor = Color.Red;
                        }
                    }
                }
                else if (c is PictureBox)
                {
                    if (cheminPhoto == string.Empty)
                    {
                        //Drapeau devient français
                        ((PictureBox)c).Image = imgListDrapeau.Images[1];
                    }
                }
            }
        }

        /*
         * Lorsque la souris sort du panel du mot traduit
         * Remise du mot espagnol
         */
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            //Peu importe l'activateur de l'évènement, placement sur le panel parent
            Panel pnl = new Panel();
            if (sender is PictureBox)
            {
                pnl = (Panel)((PictureBox)sender).Parent;
            }
            else if (sender is Label)
            {
                pnl = (Panel)(((Label)sender).Parent).Parent;
            }
            //Détermination du mot à traduire à l'aide du tag
            int tag = Convert.ToInt32(pnl.Tag);

            actualiserInfosMots(numMots[tag]);

            //Parcour des contrôles du panel parent
            foreach (Control c in pnl.Controls)
            {
                if (c is Panel)
                {
                    foreach (Label lbl in c.Controls)
                    {
                        if (lbl.Tag != null && (int)lbl.Tag == 1)
                        {
                            //Mot devient espagnol
                            lbl.Text = motEsp;
                            lbl.ForeColor = Color.LightCoral;
                        }
                    }
                }
                else if (c is PictureBox)
                {
                    if (cheminPhoto == string.Empty)
                    {
                        //Drapeau devient espagnol
                        ((PictureBox)c).Image = imgListDrapeau.Images[0];
                    }
                }
            }
        }

        /******************************************************************************/
        /* FONCTIONS ET PROCÉDURES                                                    */
        /******************************************************************************/
        /*
         * Procédure genererMots qui génère dynamiquement les composants visuels nécessaires
         * au bon fonctionnement de l'exercice de vocabulaire
         */
        private void genererMots()
        {
            //Variables de positionnement
            const int xEcart = 40;
            int xPosition = 0;

            //S'il y a plus de 4 mots
            if (numMots.Count()  < 4)
            {
                //Affichage pour 4 mots en même temps
                xPosition = (400 - (numMots.Count() * 170 + xEcart * (numMots.Count() - 1)) / 2);
            }

            //Pour tous les mots de la liste
            for (int i = 0; i < numMots.Count(); i++)
            {
                //Actualisation des informations du mots
                actualiserInfosMots(numMots[i]);

                //Création d'un panel
                Panel pnlCadre = new Panel();
                pnlCadre.Size = new Size(170, 250);
                pnlCadre.BorderStyle = BorderStyle.FixedSingle;
                pnlCadre.BackgroundImage = Properties.Resources.fondBlanc;
                pnlCadre.Left = xPosition;
                pnlCadre.Tag = i;
                //Ajout du panel au panel principal
                pnlMots.Controls.Add(pnlCadre);

                xPosition += 170 + xEcart;

                //Création d'une pictureBox
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(170, 170);
                picBox.BackColor = Color.Transparent;

                //Si le mot n'a pas de photo associée
                if (cheminPhoto == string.Empty)
                {
                    //Image par défaut : drapeau espagnol
                    picBox.Image = imgListDrapeau.Images[0];
                }
                //Sinon
                else
                {
                    //Image correspondant au mot
                    picBox.Image = imgListBase.Images[cheminPhoto];
                }
                
                picBox.MouseEnter += new EventHandler(Panel_MouseEnter);
                picBox.MouseLeave += new EventHandler(Panel_MouseLeave);
                //Ajout de la pictureBox au premier panel crée
                pnlCadre.Controls.Add(picBox);

                //Création d'un panel
                Panel pnlMot = new Panel();
                pnlMot.Size = new Size(170, 80);
                pnlMot.Top = 170;
                //Ajout de la pictureBox au premier panel crée
                pnlCadre.Controls.Add(pnlMot);

                //Création du label contenant le mot
                Label lblMot = new Label();
                lblMot.AutoSize = false;
                lblMot.ForeColor = Color.LightCoral;
                lblMot.Size = new Size(170, 40);
                lblMot.Dock = DockStyle.Top;
                lblMot.TextAlign = ContentAlignment.MiddleCenter;
                lblMot.Font = new Font("Arial", 11, FontStyle.Bold);
                lblMot.Text = motEsp;
                lblMot.Tag = 1;
                lblMot.MouseEnter += new EventHandler(Panel_MouseEnter);
                lblMot.MouseLeave += new EventHandler(Panel_MouseLeave);
                //Ajout du label au deuxième panel crée
                pnlMot.Controls.Add(lblMot);

                //Création du label contenant l'origine du mot
                Label lblOrigine = new Label();
                lblOrigine.AutoSize = false;
                lblOrigine.ForeColor = Color.White;
                lblOrigine.Size = new Size(170, 40);
                lblOrigine.Dock = DockStyle.Bottom;
                lblOrigine.TextAlign = ContentAlignment.MiddleCenter;
                lblOrigine.Font = new Font("Arial", 11, FontStyle.Regular);
                lblOrigine.Text = origine;
                lblOrigine.MouseEnter += new EventHandler(Panel_MouseEnter);
                lblOrigine.MouseLeave += new EventHandler(Panel_MouseLeave);
                //Ajout du label au deuxième panel crée
                pnlMot.Controls.Add(lblOrigine);
            }
        }

        /*
         * Procédure actualiserInfosMots qui actualise les informations concernant
         * chaque mot individuellement
         */
        private void actualiserInfosMots(int numMot)
        {
            string[] infosMot = exo.chercherInfosMots(numMot);

            motEsp = infosMot[0];
            motFr = infosMot[1];
            cheminPhoto = infosMot[2];
            origine = infosMot[3];
        }

    }
}
