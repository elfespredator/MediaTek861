using System.Collections.Generic;
using MediaTek86.bddmanager;
using MediaTek86.model;

namespace MediaTek86.dal
{

    public class PersonnelDal
    {
        private static readonly string stringConnexion =
            "server=localhost;database=mediatek86;uid=userMediatek;pwd=Mediatek86!;";

        private readonly BddManager bdd;

        public PersonnelDal()
        {
            bdd = BddManager.GetInstance(stringConnexion);
        }

        
        public bool VerifConnexion(string login, string pwd)
        {
            string req = "SELECT * FROM responsable WHERE login=@login AND pwd=SHA2(@pwd, 256)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd", pwd }
            };
            List<Dictionary<string, object>> records = bdd.ReqSelect(req, parameters);
            return records.Count > 0;
        }

      
        public List<Service> GetAllServices()
        {
            List<Service> services = new List<Service>();
            string req = "SELECT id, nom FROM service ORDER BY nom";
            List<Dictionary<string, object>> records = bdd.ReqSelect(req);
            foreach (Dictionary<string, object> record in records)
            {
                services.Add(new Service(
                    int.Parse(record["id"].ToString()),
                    record["nom"].ToString()
                ));
            }
            return services;
        }

        public List<Motif> GetAllMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            string req = "SELECT id, libelle FROM motif ORDER BY libelle";
            List<Dictionary<string, object>> records = bdd.ReqSelect(req);
            foreach (Dictionary<string, object> record in records)
            {
                motifs.Add(new Motif(
                    int.Parse(record["id"].ToString()),
                    record["libelle"].ToString()
                ));
            }
            return motifs;
        }

     
        public List<Personnel> GetAllPersonnel()
        {
            List<Personnel> listePersonnel = new List<Personnel>();
            string req = "SELECT p.id, p.nom, p.prenom, p.tel, p.mail, " +
                         "s.id AS idService, s.nom AS nomService " +
                         "FROM personnel p " +
                         "JOIN service s ON p.idService = s.id " +
                         "ORDER BY p.nom, p.prenom";
            List<Dictionary<string, object>> records = bdd.ReqSelect(req);
            foreach (Dictionary<string, object> record in records)
            {
                Service service = new Service(
                    int.Parse(record["idService"].ToString()),
                    record["nomService"].ToString()
                );
                listePersonnel.Add(new Personnel(
                    int.Parse(record["id"].ToString()),
                    record["nom"].ToString(),
                    record["prenom"].ToString(),
                    record["tel"] != null ? record["tel"].ToString() : "",
                    record["mail"] != null ? record["mail"].ToString() : "",
                    service
                ));
            }
            return listePersonnel;
        }

        
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idService)
        {
            string req = "INSERT INTO personnel (nom, prenom, tel, mail, idService) " +
                         "VALUES (@nom, @prenom, @tel, @mail, @idService)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom", nom },
                { "@prenom", prenom },
                { "@tel", tel },
                { "@mail", mail },
                { "@idService", idService }
            };
            bdd.ReqUpdate(req, parameters);
        }

        
        public void ModifierPersonnel(int id, string nom, string prenom, string tel, string mail, int idService)
        {
            string req = "UPDATE personnel SET nom=@nom, prenom=@prenom, tel=@tel, " +
                         "mail=@mail, idService=@idService WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id },
                { "@nom", nom },
                { "@prenom", prenom },
                { "@tel", tel },
                { "@mail", mail },
                { "@idService", idService }
            };
            bdd.ReqUpdate(req, parameters);
        }

        public void SupprimerPersonnel(int id)
        {
            string req = "DELETE FROM personnel WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            bdd.ReqUpdate(req, parameters);
        }

        public List<Absence> GetAbsencesPersonnel(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();
            string req = "SELECT a.id, a.dateDebut, a.dateFin, " +
                         "m.id AS idMotif, m.libelle " +
                         "FROM absence a " +
                         "JOIN motif m ON a.idMotif = m.id " +
                         "WHERE a.idPersonnel = @idPersonnel " +
                         "ORDER BY a.dateDebut DESC";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idPersonnel", idPersonnel }
            };
            List<Dictionary<string, object>> records = bdd.ReqSelect(req, parameters);
            foreach (Dictionary<string, object> record in records)
            {
                Motif motif = new Motif(
                    int.Parse(record["idMotif"].ToString()),
                    record["libelle"].ToString()
                );
                absences.Add(new Absence(
                    int.Parse(record["id"].ToString()),
                    null,
                    System.DateTime.Parse(record["dateDebut"].ToString()),
                    System.DateTime.Parse(record["dateFin"].ToString()),
                    motif
                ));
            }
            return absences;
        }

        
        public bool ExisteChevauchement(int idPersonnel, System.DateTime dateDebut, System.DateTime dateFin, int idAbsenceExclure = -1)
        {
            string req = "SELECT id FROM absence WHERE idPersonnel=@idPersonnel " +
                         "AND NOT (dateFin < @dateDebut OR dateDebut > @dateFin) " +
                         "AND id != @idExclure";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idPersonnel", idPersonnel },
                { "@dateDebut", dateDebut },
                { "@dateFin", dateFin },
                { "@idExclure", idAbsenceExclure }
            };
            List<Dictionary<string, object>> records = bdd.ReqSelect(req, parameters);
            return records.Count > 0;
        }

        
        public void AjouterAbsence(int idPersonnel, System.DateTime dateDebut, System.DateTime dateFin, int idMotif)
        {
            string req = "INSERT INTO absence (idPersonnel, dateDebut, dateFin, idMotif) " +
                         "VALUES (@idPersonnel, @dateDebut, @dateFin, @idMotif)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idPersonnel", idPersonnel },
                { "@dateDebut", dateDebut.ToString("yyyy-MM-dd") },
                { "@dateFin", dateFin.ToString("yyyy-MM-dd") },
                { "@idMotif", idMotif }
            };
            bdd.ReqUpdate(req, parameters);
        }

      
        public void ModifierAbsence(int id, System.DateTime dateDebut, System.DateTime dateFin, int idMotif)
        {
            string req = "UPDATE absence SET dateDebut=@dateDebut, dateFin=@dateFin, " +
                         "idMotif=@idMotif WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id },
                { "@dateDebut", dateDebut.ToString("yyyy-MM-dd") },
                { "@dateFin", dateFin.ToString("yyyy-MM-dd") },
                { "@idMotif", idMotif }
            };
            bdd.ReqUpdate(req, parameters);
        }

       
        public void SupprimerAbsence(int id)
        {
            string req = "DELETE FROM absence WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };
            bdd.ReqUpdate(req, parameters);
        }
    }
}