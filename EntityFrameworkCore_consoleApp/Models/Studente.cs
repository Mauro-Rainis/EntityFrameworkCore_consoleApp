using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCore_consoleApp.Models
{
    class Studente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Id")]
        public Sport Sport { get; set; }

        public override string ToString()
        {
            // C# 6 Monadic null checking >> https://damieng.com/blog/2013/12/09/probable-c-6-0-features-illustrated
            return Id + " " + Nome + " pratica " + Sport?.Nome ?? " nessuno sport";
        }
    }
}
