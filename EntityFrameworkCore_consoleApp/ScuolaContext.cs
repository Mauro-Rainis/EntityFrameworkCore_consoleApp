using EntityFrameworkCore_consoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_consoleApp
{
    class ScuolaContext : DbContext
    {
        public DbSet<Sport> Sport { get; set; }

        public DbSet<Studente> Studenti { get; set; }

        // Aggiungo i parametri di connessione al database (da spostare in file di configurazione)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Scuola;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studente>(entity =>
            {
                entity.ToTable("Studenti");
                entity.Property(e => e.Id);
                entity.Property(e => e.Nome);
                entity.OwnsOne(e => e.Sport);
            }
            );

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.ToTable("Sport");
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
