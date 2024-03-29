﻿using EntityFrameworkCore_consoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_consoleApp
{
    class ScuolaContext : DbContext
    {
        // Per utilizzare DbContext bisogna aggiungere il pacchetto NuGet Microsoft.EntityFrameworkCore

        // Aggiungo una proprietà per ogni classe che voglio mappare
        // Questo mappa la classe Sport verso la tabella Sport (mapping tramite convenzione)
        public DbSet<Sport> Sport { get; set; }

        // Questo mappa la classe Studente verso la tabella Studenti (mapping tramite convenzione)
        public DbSet<Studente> Studenti { get; set; }

        // Aggiungo i parametri di connessione al database (da spostare in file di configurazione)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // A seconda del db che voglio utilizzare devo aggiungere prima il pacchetto NuGet per EFCore per quel Db
            // Nel caso di Sql Server uso Microsoft.EntityFrameworkCore.SqlServer
            // Per PostgreSQL uso Npgsql.EntityFrameworkCore.PostgreSQL
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Scuola;Trusted_Connection=True;");
        }

    }
}
