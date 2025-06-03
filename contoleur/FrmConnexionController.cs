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
    /// Controlleur de la frame de connexion
    /// </summary>
    public class FrmConnexionController
    {
        /// <summary>
        /// Objet pour accéder aux opérations possibles sur responsable
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Valorisation de responsableAccess
        /// </summary>
        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Méthode pour vérifier si une personne est enregistrée dans la base de donnée en tant que responsable (dans la table responsable)
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns>"vrai" si la personne est enregistré en tant que responsable</returns>
        public Boolean ContoroleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }
    }
}
