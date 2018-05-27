using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitApp.Models
{
    public class Trener:Korisnik
    {
        
        public string Biografija { get; set; }
        public string Lokacija { get; set; }
        public string KontaktTelefon { get; set; }

        public ICollection<Program> Programi { get; set; }

        public void DodajProgram(Program program)
        {
            Programi.Add(program);
        }
    }
}
