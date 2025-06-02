using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe correspondant à la table responsable de la base de données
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Propriétés de la classe (correspondant aux champs de la table responsable de la base de données)
        /// </summary>
        public string Login{ get; }
        public string Pwd { get; }

        /// <summary>
        /// Constructeur de la classe pour valoriser les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
