using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitApp.Models
{
    public class Komentar
    {
        
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public string Text { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public int ProgramAjDi { get; set; }
    }
}
