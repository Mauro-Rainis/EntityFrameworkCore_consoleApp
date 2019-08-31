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
                //foreach (var s in ListaSport)
                //{
                //    Console.WriteLine(s.ToString());
                //}
                // al posto del foreach posso usare Join
                Console.WriteLine(string.Join(Environment.NewLine, ListaSport));

                Console.WriteLine();

                Console.WriteLine("Elenco nomi studenti");
                var ListaNomiStudenti = context.Studenti.Select(e => e.Nome).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaNomiStudenti ));


                // Perchè la seguente non funziona? Mi aspetterei la lista di tutti gli studenti seguita dal nome dello sport praticato
                /*
                Console.WriteLine("Elenco studenti");
                var ListaStudenti = context.Studenti.ToList();
                Console.WriteLine(string.Join(Environment.NewLine, ListaStudenti));
                */
            }
        }
    }
}
