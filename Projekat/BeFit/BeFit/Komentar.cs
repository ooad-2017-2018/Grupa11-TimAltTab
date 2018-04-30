using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class Komentar
    {
        string text;
        Korisnik korisnik;

        public string Text { get => text; set => text = value; }
        public Korisnik Korisnik { get => korisnik; set => korisnik = value; }
    }
}
