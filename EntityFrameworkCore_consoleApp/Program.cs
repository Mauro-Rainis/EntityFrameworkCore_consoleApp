using EntityFrameworkCore_consoleApp.Models;
using Microsoft.EntityFrameworkCore;
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

                // Problema N+1 query
                // Vedi ad esempio https://weblogs.thinktecture.com/pawel/2018/04/entity-framework-core-performance-beware-of-n1-queries.html

                // Alternativa usando SQL, devo usare Microsoft.EntityFrameworkCore
                var ListaStudentiSql = context.Studenti.FromSql("select * from studenti").ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudentiSql));

                // Esercizio 3
                // Inserimento nuovi dati nel db

                // Inserire un nuovo sport

                // Modificare uno sport inserito

                // Cancellare uno sport

                // Inserire un nuovo studente che non pratica sport
                // Inserire un nuovo studente che pratica sport

                // Cancellare uno studente
            }
        }
    }
}
