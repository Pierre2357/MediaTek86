using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe pour gérer les demandes par rapport au responsable
    /// </summary>
    public class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de connexion pour l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// constructeur de la classe pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Méthode pour vérifier si une personne est enregistrée dans la base de donnée en tant que responsable (dans la table responsable)
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns>"vrai" si la personne est enregistré en tant que responsable</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if(access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Login);
                parameters.Add("@pwd", responsable.Pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if(records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
    }
}
