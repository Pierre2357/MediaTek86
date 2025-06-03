using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe correspondant à la table personnel de la base de données
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public int Idpersonnel { get; }
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Propriété de la classe personnel de la base de données
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }
    }
}
