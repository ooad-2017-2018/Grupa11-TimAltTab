using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class TrenerProgram : ProgramWorkout
    {
        double cijena;
        double ocjena;
        List<Komentar> komentari;
        int brojOcjena;

        public double Cijena { get => cijena; set => cijena = value; }
        public double Ocjena { get => ocjena; set => ocjena = value; }
        public List<Komentar> Komentari { get => komentari; set => komentari = value; }

    }
}
