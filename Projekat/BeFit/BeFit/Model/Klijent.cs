﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class Klijent : Korisnik
    {
        List<KlijentProgram> mojiProgrami=new List<KlijentProgram>();
        List<TrenerProgram> kupljeniProgrami=new List<TrenerProgram>();

        public List<KlijentProgram> MojiProgrami { get => mojiProgrami; }
        public List<TrenerProgram> KupljeniProgrami { get => kupljeniProgrami; }

        public void dodajMojProgram(KlijentProgram klijentProgram)
        {
            mojiProgrami.Add(klijentProgram);
        }

        public void dodajTrenerProgram(TrenerProgram trenerProgram)
        {
            kupljeniProgrami.Add(trenerProgram);
        }
    }
}
