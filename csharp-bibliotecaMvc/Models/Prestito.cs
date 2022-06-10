using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    
    public class Prestito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrestitoID { get; set; }

        public int UtenteID { get; set; }

        public int LibroID { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }


        public Utente Utente { get; set; }
        
        public virtual Libro Libro { get; set; }
    }
}
