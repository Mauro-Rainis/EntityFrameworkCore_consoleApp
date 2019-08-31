using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore_consoleApp.Models
{
    class Studente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Sport Sport { get; set; }
    }
}
