using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe correspondant à la table service de la base de données
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Propriété de la classe service de la base de données
        /// </summary>
        public int Idservice { get; }
        /// <summary>
        /// Propriété de la classe service de la base de données
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Défini l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
