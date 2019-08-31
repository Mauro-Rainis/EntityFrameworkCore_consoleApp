using EntityFrameworkCore_consoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_consoleApp
{
    class ScuolaContext : DbContext
    {
        // Per utilizzare DbContext bisogna aggiungere il pacchetto NuGet Microsoft.EntityFrameworkCore

        // Aggiungo una proprietà per ogni classe che voglio mappare
        public DbSet<Sport> Sport { get; set; }

        public DbSet<Studente> Studente { get; set; }

        // Aggiungo i parametri di connessione al database (da spostare in file di configurazione)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // A seconda del db che voglio utilizzare devo aggiungere prima il pacchetto NuGet per EFCore per quel Db
            // Nel caso di Sql Server uso Microsoft.EntityFrameworkCore.SqlServer
            // Per PostgreSQL uso Npgsql.EntityFrameworkCore.PostgreSQL
            optionsBuilder.UseSqlServer("");


        }
    }
}
