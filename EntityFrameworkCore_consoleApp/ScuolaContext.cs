using EntityFrameworkCore_consoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EntityFrameworkCore_consoleApp
{
    class ScuolaContext : DbContext
    {
        private static string _connectionString;

        public DbSet<Sport> Sport { get; set; }

        public DbSet<Studente> Studenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            optionsBuilder.UseSqlServer(_connectionString);
        }

        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                ;

            var configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("DefaultConnection");
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
