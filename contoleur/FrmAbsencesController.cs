using MediaTek86.dal;
using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.contoleur
{
    /// <summary>
    /// Controlleur de la frame Absences
    /// </summary>
    public class FrmAbsencesController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// Objet d'accès aux opérations possibles sur motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmAbsencesController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences d'un membre du personnel
        /// </summary>
        /// <param name="personnel">membre du personnel dont on veut obtenir les absences</param>
        /// <returns>liste des absences du membre du personnel</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        /// <summary>
        /// Récupère et retourne la liste des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Méthode pour ajouter une absence à la base de données
        /// </summary>
        /// <param name="absence">absence à ajouter</param>
        public void AjoutAbsence(Absence absence)
        {
            absenceAccess.AjoutAbsence(absence);
        }

        /// <summary>
        /// Méthode pour supprimer une absence de la base de données
        /// </summary>
        /// <param name="absence">absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Méthode pour modifier une absence dans la base de données
        /// </summary>
        /// <param name="oldAbsence">ancienne absence (à modifier)</param>
        /// <param name="newAbsence">nouvelle absence (modifiée)</param>
        public void UpdateAbsence(Absence oldAbsence, Absence newAbsence)
        {
            absenceAccess.UpdateAbsence(oldAbsence, newAbsence);
        }
    }
}
