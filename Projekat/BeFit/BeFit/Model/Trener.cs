using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class Trener:Korisnik
    {
        string biografija;
        string lokacija;
        string kontaktTelefon;
        List<TrenerProgram> programi;

        public string Biografija { get => biografija; set => biografija = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }
        public string KontaktTelefon { get => kontaktTelefon; set => kontaktTelefon = value; }
        public List<TrenerProgram> Programi { get => programi; }

        public void DodajTrenerProgram(TrenerProgram program)
        {
            programi.Add(program);
        }
    }
}
