using MediaTek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe pour gérer les demandes par rapport aux absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de connexion pour l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// constructeur de la classe pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences d'un membre du personnel
        /// </summary>
        /// <param name="personnel">membre du personnel dont on veut obtenir les absences</param>
        /// <returns>liste des absences du membre du personnel</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if(access.Manager != null)
            {
                string req = "select a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.libelle as libelle ";
                req += "from absence a ";
                req += "join motif m on (a.idmotif = m.idmotif) ";
                req += "join personnel p on (a.idpersonnel = p.idpersonnel) ";
                req += "where p.idpersonnel = @idpersonnel ";
                req += "order by a.datedebut desc;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if(records != null)
                    {
                        foreach (object[]record in records)
                        {
                            Motif motif = new Motif((int)record[2], (string)record[3]);
                            Absence absence = new Absence(personnel, (DateTime)record[0], 
                                (DateTime)record[1], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Méthode pour ajouter une absence à la base de données
        /// </summary>
        /// <param name="absence">absence à ajouter</param>
        public void AjoutAbsence(Absence absence)
        {
            if(access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif)";
                req += "values(@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.Personnel.Idpersonnel);
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                parameters.Add("@idmotif", absence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Méthode pour supprimer une absence de la base de données
        /// </summary>
        /// <param name="absence">absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if(access.Manager != null)
            {
                string req = "delete from absence where datedebut = @datedebut and datefin = @datefin;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@datedebut", absence.Datedebut);
                parameters.Add("@datefin", absence.Datefin);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Méthode pour modifier une absence dans la base de données
        /// </summary>
        /// <param name="oldAbsence">ancienne absence (à modifier)</param>
        /// <param name="newAbsence">nouvelle absence (modifiée)</param>
        public void UpdateAbsence(Absence oldAbsence, Absence newAbsence)
        {
            if(access.Manager != null)
            {
                string req = "update absence set datedebut = @newdatedebut, datefin = @newdatefin, idmotif = @newidmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @olddatedebut and datefin = @olddatefin and idmotif = @oldidmotif;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@newdatedebut", newAbsence.Datedebut);
                parameters.Add("@newdatefin", newAbsence.Datefin);
                parameters.Add("@newidmotif", newAbsence.Motif.Idmotif);
                parameters.Add("@idpersonnel", oldAbsence.Personnel.Idpersonnel);
                parameters.Add("@olddatedebut", oldAbsence.Datedebut);
                parameters.Add("@olddatefin", oldAbsence.Datefin);
                parameters.Add("@oldidmotif", oldAbsence.Motif.Idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
