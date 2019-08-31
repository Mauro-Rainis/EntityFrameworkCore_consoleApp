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


                // Perchè la seguente non funziona? Mi aspetterei la lista di tutti gli studenti seguita dal nome dello sport praticato
                // Non funzionava perchè non avevamo configurato nessun mapping, quindi EFCore tentava di usare il mapping tramite convenzioni
                // me le tabelle del nostro db non rispettano la convenzione predefinita per il mapping.
                // Bisogna mappare le classi verso il db usando una delle seguenti:
                // - mapping tramite API
                // - mapping tramite data annotation
                /*
                Console.WriteLine("Elenco studenti");
                var ListaStudenti = context.Studenti.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudenti));
                */

            }
        }
    }
}
