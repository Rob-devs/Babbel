using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace Mini_projet_Babbel
{
    /*
     * Classe Exercice qui comporte toutes les informations concernant un exercice en particulier
     */
    public class Exercice
    {
        /** Déclaration et initialisation des variables globales */

        //Informations sur l'exercice actuel
        public int numeroExercice;
        public int numeroLecon;

        public int nombreExercice;
        public int nombreLecon;

        public string numeroCours;

        //Bool qui indique s'il y a besoin de faire un rapport (fin de leçon)
        public bool rapport = false;

        //Liste des cours
        public List<string> cours = new List<string>();

        //Récupération des données de la base
        const string CONNECTION_STRING = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base\baseLangue.mdb";
        OleDbConnection con = new OleDbConnection();
        
        //Table locale
        readonly string[] tables = new string[] { "Cours", "Lecons", "Exercices", "Regles", "Mots", "ConcerneMots", "Phrases" };
        public DataSet ds = new DataSet();

        //Création d'une table des resultats
        public DataTable tblRes = new DataTable("tblRes");

        //Constructeur
        public Exercice()
        {
            //Chargement de la table locale
            chargerDataSet();

            //Création des colonnes de la table des résultats
            creerTableRes(tblRes);

            //Remplissage de la liste des cours
            remplirListeCours();
        }

        /******************************************************************************/
        /* FONCTIONS                                                                  */
        /******************************************************************************/
        /*
         * Fonction detTypeExercice qui détermine le type de l'exercice en renvoyant un int
         *   1: Phrase en désordre
         *   2: Phrase à trous
         *   3: Vocabulaire
         */
        public int detTypeExercice()
        {
            int type = 0;

            //Sélection de l'exercice
            DataRow[] data = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data.Length > 0)
            {
                //S'il y a une phrase assignée à l'exercice
                if (data[0]["codePhrase"].ToString() != string.Empty
                    && data[0]["codePhrase"].ToString() != "0")
                {
                    //Si c'est une phrase en désordre
                    if (data[0].Field<bool>(6) == true)
                    {
                        type = 1;
                    }
                    //Sinon, c'est une phrase à trous
                    else
                    {
                        type = 2;
                    }
                }
                //Sinon
                else
                {
                    //Si c'est un exercice de vocabulaire (pas de verbe)
                    if (data[0]["codeVerbe"].ToString() == string.Empty
                        || data[0]["codeVerbe"].ToString() == "0")
                    {
                        type = 3;
                    }
                    //Sinon, c'est un exercice de grammaire
                    else
                    {
                        type = 4;
                    }
                }
            }

            return type;
        }

        /*
         * Fontion dernierExo qui renvoie true si l'utilisateur est au tout dernier exercice de la dernière leçon du dernier cours
         */
        public bool dernierExo()
        {
            bool dernier = false;

            //Si c'est le tout dernier exercice
            if (numeroExercice == nombreExercice && numeroLecon == nombreLecon && numeroCours == cours[cours.Count - 1])
            {
                dernier = true;
            }

            return dernier;
        }

        /*
         * Fontion calculerNbExo qui renvoie le nombre d'exercices de la leçon et du cours actuels
         */
        public int calculerNbExo()
        {
            int res = 0;

            //Sélection des exercices de la leçon
            DataRow[] data = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon}");

            if (data.Length > 0)
            {
                //Renvoie du nombre de lignes trouvées
                res = data.Length;
            }

            return res;
        }

        /*
         * Fontion calculerNbExo qui renvoie le nombre de leçons du cours actuel
         */
        public int calculerNbLecon()
        {
            int res = 0;

            //Sélection des leçons du cours
            DataRow[] data = ds.Tables["Lecons"].Select($"numCours='{numeroCours}'");

            if (data.Length > 0)
            {
                //Renvoie du nombre de lignes trouvées
                res = data.Length;
            }

            return res;
        }

        /*
         * Fonction titreCours qui renvoie le titre du cours actuel
         */
        public string titreCours()
        {
            string titre = string.Empty;

            //Sélection du cours
            DataRow[] data = ds.Tables["Cours"].Select($"numCours='{numeroCours}'");

            if (data.Length > 0)
            {
                //Renvoie du titre
                titre = data[0]["titreCours"].ToString();
            }

            return titre;
        }

        /*
         * Fonction titreLecon qui renvoie le titre de la leçon actuelle
         */
        public string titreLecon()
        {
            string titre = string.Empty;

            //Sélection de la leçon
            DataRow[] data = ds.Tables["Lecons"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon}");

            if (data.Length > 0)
            {
                //Renvoie du titre
                titre = data[0]["titreLecon"].ToString();
            }

            return titre;
        }

        /*
         * Fonction detEnonce qui renvoie l'énoncé de l'exercice actuel
         */
        public string detEnonce()
        {
            string enonce = string.Empty;

            //Sélection de l'exercice
            DataRow[] data = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data.Length > 0)
            {
                //Renvoie de l'énoncé
                enonce = data[0]["enonceExo"].ToString();
            }

            return enonce;
        }

        /*
         * Fonction detRegle qui renvoie la règle d'un exercice
         */
        public string detRegle()
        {
            string numRegle = string.Empty;
            string regle = string.Empty;

            //Sélection de l'exercice
            DataRow[] data1 = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data1.Length > 0)
            {
                //Stockage du code de la règle
                numRegle = data1[0]["codeRegle"].ToString();
            }

            //Sélection de la règle correpondant au code stocké
            DataRow[] data2 = ds.Tables["Regles"].Select($"codeRegle='{numRegle}'");

            if (data2.Length > 0)
            {
                //Renvoie du texte de la règle
                regle = data2[0]["texteRegle"].ToString();
            }

            return regle;
        }

        /*
         * Fonction detVerbe qui renvoie la traduction du verbe concerné par l'exercice
         */
        public string detVerbe()
        {
            int codeVerbe = 0;
            string traducMot = string.Empty;

            //Sélection de l'exercice
            DataRow[] data1 = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data1.Length > 0)
            {
                //Stockage du code du verbe
                codeVerbe = Convert.ToInt32(data1[0]["codeVerbe"]);
            }

            
            //Sélection du mot correspondant au code du verbe stocké
            DataRow[] data2 = ds.Tables["Mots"].Select($"numMot={codeVerbe}");
            if (data2.Length > 0)
            {
                //Renvoie de la traduction du mot
                traducMot = data2[0]["traducMot"].ToString();
            }
            return traducMot;
        }

        /*
         * Fonction detPhrase qui renvoie la phrase concernée par l'exercice et sa traduction
         */
        public string[] detPhrases()
        {
            int codePhrase = 0;

            string phrase = string.Empty;
            string traducPhrase = string.Empty;

            string[] phrases = new string[2];

            //Sélection de l'exercice
            DataRow[] data1 = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data1.Length > 0)
            {
                //Si le code de la phrase est null
                if (data1[0]["codePhrase"].ToString() == string.Empty)
                {
                    codePhrase = 0;
                }
                //Sinon
                else
                {
                    //Stockage du code de la phrase
                    codePhrase = Convert.ToInt32(data1[0]["codePhrase"]);
                }
            }

            //Sélection de la phrase correspondant au code la phrase stocké
            DataRow[] data2 = ds.Tables["Phrases"].Select($"codePhrase='{codePhrase}'");

            if (data2.Length > 0)
            {
                //Renvoie de la phrase et de sa traduction
                phrase = data2[0]["textePhrase"].ToString();
                traducPhrase = data2[0]["traducPhrase"].ToString();
            }

            phrases[0] = phrase;
            phrases[1] = traducPhrase;

            return phrases;
        }

        /*
         * Fonction detNumMotsCaches qui renvoie une liste des numéros des mots à cacher
         */
        public List<int> detNumMotsCaches()
        {
            List<int> numeros = new List<int>();

            string listeMots = string.Empty;

            //Sélection de l'exercice
            DataRow[] data = ds.Tables["Exercices"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data.Length > 0)
            {
                //Stockage de la liste des mots à cacher sous forme de string
                listeMots = data[0]["listeMots"].ToString();
            }

            //Pour chaque numéro, séparés par un '/'
            foreach (string num in listeMots.Split('/'))
            {
                //Ajout du numéro à la liste des numéros
                numeros.Add(Convert.ToInt32(num));
            }

            return numeros;
        }

        /*
         * Fontion detNumMots qui renvoie une liste avec les numéros des mots
         * concernés par l'exercice
         */
        public List<int> detNumMots()
        {
            List<int> numMots = new List<int>();

            //Sélection des mots concernés par un exercice
            DataRow[] data = ds.Tables["ConcerneMots"].Select($"numCours='{numeroCours}' AND numLecon={numeroLecon} AND numExo={numeroExercice}");

            if (data.Length > 0)
            {
                //Pour chaque ligne trouvée
                foreach (DataRow dr in data)
                {
                    //Ajout du numéro du mot à la liste
                    numMots.Add(Convert.ToInt32(dr["numMot"]));
                }
            }

            return numMots;
        }

        /*
         * Fontion chercherInfosMots qui cherche les informations concernant un mot
         */
        public string[] chercherInfosMots(int numMot)
        {
            string[] infosMot = new string[4];

            //Sélection du mot correspondant au numéro passé en paramètre
            DataRow[] data = ds.Tables["Mots"].Select($"numMot={numMot}");

            if (data.Length > 0)
            {
                //Renvoie des informations du mots à l'aide d'un tableau
                infosMot[0] = data[0]["libMot"].ToString();
                infosMot[1] = data[0]["traducMot"].ToString();
                infosMot[2] = data[0]["cheminPhoto"].ToString();
                infosMot[3] = data[0]["origine"].ToString();
            }

            return infosMot;
        }

        /******************************************************************************/
        /* PROCÉDURES                                                                 */
        /******************************************************************************/
        /*
         * Procédure lancerExercice qui lance le formulaire correspondant au type de l'exercice
         */
        public void lancerExercice()
        {
            int type = detTypeExercice();
            
            //Phrase en désordre
            if (type == 1)
            {
                PhraseDesordre phrDes = new PhraseDesordre(this, tblRes);
                phrDes.ShowDialog();
                ajouterLignes(phrDes.drClose);
            }
            //Phrase à trous
            else if (type == 2)
            {
                PhraseTrous phrTrous = new PhraseTrous(this, tblRes);
                phrTrous.ShowDialog();
                ajouterLignes(phrTrous.drClose);
            }
            //Vocabulaire
            else if (type == 3)
            {
                new Voc(this).ShowDialog();
            }
            //Grammaire
            else if (type == 4)
            {
                new Grammaire(this).ShowDialog();
            }
        }

        /*
         * Procédure exerciceSuivant qui actualise les informations de l'exercice pour continuer avec le prochain
         */
        public void exerciceSuivant()
        {
            //Si ce n'est pas le dernier exercice
            if (numeroExercice < nombreExercice)
            {
                //Exercice suivante
                numeroExercice++;
                rapport = false;
            }
            //Si c'est le dernier exercice
            else
            {
                //Il y a un rapport
                rapport = true;

                //Si ce n'est pas la dernière leçon
                if (numeroLecon < nombreLecon)
                {
                    //Leçon suivante
                    numeroLecon++;
                    numeroExercice = 1;
                }
                //Si c'est la dernière leçon
                else
                {
                    //Si c'est le dernier cours
                    if (cours[cours.Count - 1] == numeroCours)
                    {
                        //Incrémentation finale
                        numeroExercice++;
                    }
                    //Si ce n'est pas le dernier cours
                    else
                    {
                        //Cours suivant
                        numeroCours = cours[cours.IndexOf(numeroCours) + 1];
                        numeroExercice = 1;
                        numeroLecon = 1;
                    }
                }
                actualiserNbMax();
            }
        }

        /*
         * Procédure actualiserNbMax qui actualise le nombre d'exercices et de leçon maximum
         */
        public void actualiserNbMax()
        {
            nombreExercice = calculerNbExo();
            nombreLecon = calculerNbLecon();
        }

        /*
         * Procédure remplirListeCours qui remplit la liste contenant tous les cours
         */
        private void remplirListeCours()
        {
            //Pour chaque ligne de la table triée
            foreach (DataRow dr in ds.Tables["Cours"].Select($"", "numCours"))
            {
                //Ajout du numéro du cours à la liste des cours
                cours.Add(dr.Field<string>(0));
            }
        }

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
                foreach (string table in tables)
                {
                    //Remplissage
                    cd.CommandText = "SELECT * FROM " + table;
                    da.Fill(ds, table);
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
         * Procédure creerTableRes qui crée les colonnes de la table des résultats passée en paramètre
         */
        public void creerTableRes(DataTable dt)
        {
            dt.Columns.Add("numExo", typeof(int)); //Numéro de l'exercice
            dt.Columns.Add("reussit", typeof(bool)); //Bool qui détermine si oui ou non l'exercice est réussit
            dt.Columns.Add("solution", typeof(bool)); //Bool qui détermine si oui ou non l'utilisateur a affiché la solution
            dt.Columns.Add("nbMotsMalPlaces", typeof(int)); //Nombre de mots mal placés pour les phrases en désordre (0 par défaut)
            dt.Columns.Add("repUtil", typeof(List<string>)); //Liste des mots mal orthographiés par l'utilisateur
            dt.Columns.Add("repSolut", typeof(List<string>)); //Liste des mots attendus par l'utilisateur
        }

        /*
         * Procédure ajouterLignes qui ajoute la DataRow passée en paramètre à la table des résultats
         */
        private void ajouterLignes(DataRow dr)
        {
            tblRes.Rows.Add(dr);
        }

        /*
         * Procédure clearTableRes qui supprime toutes les lignes de la table des résultats
         */
        public void clearTableRes()
        {
            //Tant qu'il reste une ligne
            while (tblRes.Rows.Count > 0)
            {
                //Suppression de la première ligne
                tblRes.Rows[0].Delete();
            }
        }
    }
}
