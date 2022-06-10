using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    public enum Stato { Disponibile, Prestito }

    [Table("Libro")]
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }

       
        public string Titolo { get; set; }
        public string Settore { get; set; }

        public string Scaffale { get; set; }
        public Stato Stato { get; set; }

        public virtual Prestito? Prestito { get; set; }

        public ICollection<Autori>? Autori { get; set; }

    }
}
