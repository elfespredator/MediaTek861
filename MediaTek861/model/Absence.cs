using System;

namespace MediaTek86.model
{

    public class Absence
    {
    
        public int Id { get; set; }

        
        public Personnel Personnel { get; set; }

       
        public DateTime DateDebut { get; set; }

       
        public DateTime DateFin { get; set; }

       
        public Motif Motif { get; set; }

        public Absence(int id, Personnel personnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            Id = id;
            Personnel = personnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }
    }
}