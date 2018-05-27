using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitApp.Models
{
    public class TrenerProgram : Program
    {
        int brojOcjena = 0;

        public double Cijena { get; set; }
        public double Ocjena { get; set; }
        public virtual ICollection<Komentar> Komentari { get; set; }
    }
}
