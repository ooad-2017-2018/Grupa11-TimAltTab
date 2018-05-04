using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    class KlijentViewModel
    {
        Klijent klijent;
        public KlijentViewModel(Klijent klijent)
        {
            this.klijent = klijent;
        }

        public string Ime { get { return klijent.Ime; } set { klijent.Ime = value; } } 
        public string Prezime { get { return klijent.Prezime; } set { klijent.Prezime = value; } }
        public string Username { get { return klijent.Username; } set { klijent.Username = value; } }
        public string Email { get { return klijent.Email; } set { klijent.Email = value; } }
        public List<KlijentProgram> MojiProgrami { get { return klijent.MojiProgrami; } }
        public Klijent Klijent { get { return klijent; } }
    }
}
