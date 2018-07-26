using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6
{
    /// <summary>
    /// classe des stagiaires
    /// </summary>
    public class MSstagiaire
    {
        /// <summary>
        /// nombre de stagiaires de la classe
        /// (donnée partagée par toutes les instances)
        /// </summary>
        public static Int32 Nstag;
        /// <summary>
        /// obtient le numéro du stagiaire
        /// </summary>
        private Int32 numOsia;
        /// <summary>
        /// numéro du stagiaire,
        /// l'appelant devra prendre garde à passer un entier valide
        /// </summary>
        public Int32 NumOsia
        {
            get { return numOsia; }
            set { numOsia = value; }
        }
        /// <summary>
        /// le nom du stagiaire
        /// </summary>
        private String nomStagiaire;
        /// <summary>
        /// obtient ou définit le nom du stagiaire (forcé en majuscules)
        /// </summary>
        public String Nom
        {
            // en lecture, retourne la var privée
            get { return this.nomStagiaire; }
            // cette portion de code sert à l’affectation d’une nouvelle valeur ;
            // c’est ici que l’on effectue des contrôles de saisie
            // ou des transformations (ici : mettre le nom en majuscules) 
            set { this.nomStagiaire = value.Trim().ToUpper(); } // mettre le nom en majuscules
        }
        /// <summary>
        /// le prénom de stagiaire
        /// </summary>
        private String prenomStagiaire;
        /// <summary>
        /// obtient ou définit le prénom de stagiaire (forcé en minuscules)
        /// </summary>
        public String Prenom
        {
            get { return prenomStagiaire; } // en lecture, retourne la var privée
            set { prenomStagiaire = value.Trim().ToLower(); } // mettre le prénom en minuscules
        }
        /// <summary>
        /// immeuble, rue et numéro, le format est libre
        /// </summary>
        private String rue;
        /// <summary>
        /// obtient ou définit immeuble, rue et numéro, le format est libre
        /// </summary>
        public String Rue
        {
            get { return rue; }
            set { rue = value; }
        }

        /// <summary>
        /// le nom de la ville
        /// </summary>
        private String villeStagiaire;
        /// <summary>
        /// obtient ou définit le nom de la ville (forcé en majuscules)
        /// </summary>
        public String Ville
        {
            get { return villeStagiaire; } // en lecture, retourne la var privée
            set { villeStagiaire = value.Trim().ToUpper(); } // mettre la ville en majuscules
        }
        /// <summary>
        /// le code postal, l'appelant devra prendre garde à passer
        /// un code postal valide à 5 chiffres
        /// </summary>
        private String codePostalStagiaire;
        /// <summary>
        /// obtient ou définit le code postal (contrôle : 5 car, tous chiffres)
        /// </summary>
        /// <exception cref="Exception">Si code postal non valide</exception>
        public String CodePostal
        {
            get { return codePostalStagiaire; } // en lecture, retourne la var privée
            set
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i; // variable de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 5) // 5 car. attendus : OK ==> contrôler un à un
                {
                    for (i = 0; i < value.Length; i++) // controle chiffres par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // charabia ??
                        { erreur = true; }

                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // première solution par simple messagebox
                        System.Windows.Forms.MessageBox.Show(value.ToString() + "\n"
                       + "n'est pas un code postal valide : uniquement des chiffres", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                    }
                    else
                    {
                        codePostalStagiaire = value; // tout est bon, on affecte la propriété
                    }
                }
                else // il n'y a pas 5 caractères
                {
                    // première solution par simple messagebox
                    System.Windows.Forms.MessageBox.Show(value.ToString() + "\n" +
                   "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins", "Erreur Classe MStagiaire", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        /// nombre de notes obtenues
        /// </summary>
        private Int32 nbreNotes;
        /// <summary>
        /// cumul des points obtenus
        /// </summary>
        private Double pointsNotes;
        /// <summary>
        /// alimente nbreNotes et pointsNotes
        /// </summary>
        /// <param name="laNote">la nouvelle note à prendre en compte</param>
        public void RecevoirNote(float laNote)
        {
            this.nbreNotes++;
            this.pointsNotes += laNote;
        }
        /// <summary>
        /// calcule et retourne la moyenne des notes
        /// </summary>
        /// <returns>nouvelle moyenne des notes</returns>
        public Double DonnerMoyenne()
        {
            return this.pointsNotes / this.nbreNotes;
        }
    }

}
