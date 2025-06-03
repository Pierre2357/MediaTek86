﻿using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe pour gérer les demandes par rapport aux services (pour les affectations)
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de connexion pour l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// constructeur de la classe pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns>la liste des services</returns>
        public List<Service> getLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if(access.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if(records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
