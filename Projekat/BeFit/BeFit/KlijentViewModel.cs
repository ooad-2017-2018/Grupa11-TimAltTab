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

        public string Ime{ get { return klijent.Ime; } }
        public string Prezime { get { return klijent.Prezime; } }
        public string Username { get { return klijent.Username; } }
        public string Email { get { return klijent.Email; } }
    }
}
