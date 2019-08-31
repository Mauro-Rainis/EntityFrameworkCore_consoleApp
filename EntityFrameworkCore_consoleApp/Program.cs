using EntityFrameworkCore_consoleApp.Models;
using System;
using System.Linq;

namespace EntityFrameworkCore_consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ScuolaContext())
            {

                Console.WriteLine("Elenco sport");
                var ListaSport = context.Sport.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaSport));

                Console.WriteLine();

                Console.WriteLine("Elenco studenti");
                var ListaStudenti = context.Studenti.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudenti));

                // Spostiamo la configurazione della connessione al db in un file di configurazione
            }
        }
    }
}
