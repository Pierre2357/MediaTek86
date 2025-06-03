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
    /// Controlleur de la frame personnel
    /// </summary>
    public class FrmPersonnelController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// Objet d'accès aux opérations possibles sur service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste du personnel
        /// </summary>
        /// <returns>la liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns>la liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.getLesServices();
        }

        /// <summary>
        /// Méthode pour ajouter un membre du personnel à la base de données
        /// </summary>
        /// <param name="personnel">personnel à ajouter</param>
        public void AjoutPersonnel(Personnel personnel)
        {
            personnelAccess.AjoutPersonnel(personnel);
        }

        /// <summary>
        /// Méthode pour supprimer un membre du personnel de la base de données
        /// </summary>
        /// <param name="personnel">personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Méthode pour modifier un membre du personnel de la base de données
        /// </summary>
        /// <param name="personnel">personnel avec les modification à apporter</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }
    }
}
