using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_bibliotecaMvc.Models
{
    [Table("Utente")]
    public class Utente
    {
        [Key]
        public int UtenteID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Prestito> Prestito { get; set; }
    }


}

