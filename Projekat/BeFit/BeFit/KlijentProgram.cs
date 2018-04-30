using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class KlijentProgram : ProgramWorkout
    {
        Klijent klijent;
        public Klijent Klijent { get => klijent; set => klijent = value; }
    }
}
