using csharp_bibliotecaMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_bibliotecaMvc.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }

        public DbSet<Utente> Utentes { get; set; }
        public DbSet<Prestito> Prestitis { get; set; }
        public DbSet<Libro> Libros { get; set; }

        public DbSet<Autori> Autoris { get; set; }

        //public DbSet<AutoreLibro> AutoriLibroDB { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utente>().ToTable("Utente");
            modelBuilder.Entity<Prestito>().ToTable("Prestito");
            modelBuilder.Entity<Libro>().ToTable("Libro");
            modelBuilder.Entity<Autori>().ToTable("Autore");
        }
    }
}