using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe correspondant à la table motif de la base de données
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Propriétés de la classe (correspondant aux champs de la table motif de la base de données)
        /// </summary>
        public int Idmotif { get; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }
    }
}
