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
     * Formulaire d'exercice de grammaire
     */
    public partial class Grammaire : Form
    {
        //Déclaration et initialisation des objets et variables globales
        Exercice exo = new Exercice();

        public Grammaire(Exercice exo)
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
        private void Grammaire_Load(object sender, EventArgs e)
        {
            //Actualisation des titres et de l'énoncé
            lblTitreCours.Text = exo.titreCours();
            lblTitreLecon.Text = exo.titreLecon();
            lblEnonceActu.Text = exo.detEnonce();

            //Phrase avec le verbe
            lblVerbe.Text += exo.detVerbe();
        }

        /*
         * Click sur le bouton "Suivant"
         * L'utilisateur a terminé l'exercice
         */
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
