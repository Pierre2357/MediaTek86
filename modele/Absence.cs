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
        /// Propriétés de la classe (correspondant aux champs de la table absence de la base de données)
        /// </summary>
        public int Idpersonnel { get; }
        public DateTime Datedebut { get; }
        public DateTime Datefin { get; set; }
        public int Idmotif { get; set; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Idmotif = idmotif;
        }
    }
}
