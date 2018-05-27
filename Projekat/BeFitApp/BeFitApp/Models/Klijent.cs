using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitApp.Models
{
    public class Klijent : Korisnik
    {
        
        public virtual ICollection<KlijentProgram> MojiProgrami { get; set; }
        public virtual ICollection<Program> KupljeniProgrami { get; set; }


        public void dodajMojProgram(KlijentProgram klijentProgram)
        {
            MojiProgrami.Add(klijentProgram);
        }

        public void dodajTrenerProgram(Program trenerProgram)
        {
            KupljeniProgrami.Add(trenerProgram);
        }
    }
}
