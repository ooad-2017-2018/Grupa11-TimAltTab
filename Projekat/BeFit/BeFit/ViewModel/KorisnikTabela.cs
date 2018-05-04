using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class korisnici
    {
        public string id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string hashPassworda { get; set; }
        public string email { get; set; }
        public string tipKorisnika { get; set; }
    }
}
