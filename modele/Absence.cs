using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe correspondant à la table absence de la base de données
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Propriété de la classe absence de la base de données
        /// </summary>
        public Personnel Personnel { get; }
        /// <summary>
        /// Propriété de la classe absence de la base de données
        /// </summary>
        public DateTime Datedebut { get; }
        /// <summary>
        /// Propriété de la classe absence de la base de données
        /// </summary>
        public DateTime Datefin { get; set; }
        /// <summary>
        /// Propriété de la classe absence de la base de données
        /// </summary>
        public Motif Motif { get; set; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }
    }
}
