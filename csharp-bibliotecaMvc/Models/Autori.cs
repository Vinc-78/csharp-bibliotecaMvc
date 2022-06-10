using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    [Table("Autore")]
    public class Autori
    {
        [Key]
        public int AutoreId { get; set; }

       
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public ICollection<Libro>? Libro { get; set; }

        //public List<Autori>? ElencoAutori { get; set; } // elenco creato per lista autori
    }
}
