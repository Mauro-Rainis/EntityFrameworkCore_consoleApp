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

                Console.WriteLine("Elenco nomi studenti");
                var ListaNomiStudenti = context.Studenti.Select(e => e.Nome).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaNomiStudenti ));

                Console.WriteLine();

                // Mapping tramite api >> vedi le modifiche in ScuolaContext
                // https://www.entityframeworktutorial.net/code-first/fluent-api-in-code-first.aspx
                Console.WriteLine("Elenco studenti");
                var ListaStudenti = context.Studenti.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudenti));
            }
        }
    }
}
