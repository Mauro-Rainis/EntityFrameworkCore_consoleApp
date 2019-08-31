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

                // Mapping tramite API >> Vedi data annotation aggiunti alla classe Studente
                // https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
                Console.WriteLine("Elenco studenti");
                var ListaStudenti = context.Studenti.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudenti));


            }
        }
    }
}
