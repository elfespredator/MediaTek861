namespace MediaTek86.model
{
  
    public class Personnel
    {
       
        public int Id { get; set; }

        
        public string Nom { get; set; }

        
        public string Prenom { get; set; }

       
        public string Tel { get; set; }

       
        public string Mail { get; set; }

        public Service Service { get; set; }

       
        public Personnel(int id, string nom, string prenom, string tel, string mail, Service service)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Service = service;
        }

        
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}