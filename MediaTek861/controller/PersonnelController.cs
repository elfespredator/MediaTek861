using System.Collections.Generic;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    
     public class PersonnelController
    {
        
        private readonly PersonnelDal dal;

        
        public PersonnelController()
        {
            dal = new PersonnelDal();
        }

        
        public bool VerifConnexion(string login, string pwd)
        {
            return dal.VerifConnexion(login, pwd);
        }

        public List<Service> GetAllServices()
        {
            return dal.GetAllServices();
        }

       
        public List<Motif> GetAllMotifs()
        {
            return dal.GetAllMotifs();
        }

        
        public List<Personnel> GetAllPersonnel()
        {
            return dal.GetAllPersonnel();
        }

       
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idService)
        {
            dal.AjouterPersonnel(nom, prenom, tel, mail, idService);
        }

       
        public void ModifierPersonnel(int id, string nom, string prenom, string tel, string mail, int idService)
        {
            dal.ModifierPersonnel(id, nom, prenom, tel, mail, idService);
        }

        public void SupprimerPersonnel(int id)
        {
            dal.SupprimerPersonnel(id);
        }

        
        public List<Absence> GetAbsencesPersonnel(int idPersonnel)
        {
            return dal.GetAbsencesPersonnel(idPersonnel);
        }

        
        public bool ExisteChevauchement(int idPersonnel, System.DateTime dateDebut, System.DateTime dateFin, int idAbsenceExclure = -1)
        {
            return dal.ExisteChevauchement(idPersonnel, dateDebut, dateFin, idAbsenceExclure);
        }

       
        public void AjouterAbsence(int idPersonnel, System.DateTime dateDebut, System.DateTime dateFin, int idMotif)
        {
            dal.AjouterAbsence(idPersonnel, dateDebut, dateFin, idMotif);
        }

        public void ModifierAbsence(int id, System.DateTime dateDebut, System.DateTime dateFin, int idMotif)
        {
            dal.ModifierAbsence(id, dateDebut, dateFin, idMotif);
        }

        
        public void SupprimerAbsence(int id)
        {
            dal.SupprimerAbsence(id);
        }
    }
}