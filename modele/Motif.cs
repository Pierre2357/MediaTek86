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
        /// Propriété de la classe motif de la base de données
        /// </summary>
        public int Idmotif { get; }
        /// <summary>
        /// Propriété de la classe motif de la base de données
        /// </summary>
        public string Libelle { get; }

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

        /// <summary>
        /// Défini l'information à afficher (juste le libellé)
        /// </summary>
        /// <returns>libellé du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
