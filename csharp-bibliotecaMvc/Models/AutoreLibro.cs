namespace csharp_bibliotecaMvc.Models
{
    public class AutoreLibro
    {
        public int IdLibro { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public List<Autori>? listaAu { get; set; }

    }
}
