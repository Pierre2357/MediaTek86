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
        /// Propriétés de la classe (correspondant aux champs de la table service de la base de données)
        /// </summary>
        public int Idservice { get; }
        public string Nom { get; set; }

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
    }
}
