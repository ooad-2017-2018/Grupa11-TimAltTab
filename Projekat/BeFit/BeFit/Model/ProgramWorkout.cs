using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class ProgramWorkout
    {
        string naziv;
        List<VjezbaUProgramu> vjezbe = new List<VjezbaUProgramu>();
        string program_id;

        public string Naziv { get => naziv; set => naziv = value; }
        public List<VjezbaUProgramu> Vjezbe { get => vjezbe; set => vjezbe = value; }
        public string Program_id { get => program_id; set => program_id = value; }

        public void DodajVjezbu(VjezbaUProgramu vjezba)
        {
            vjezbe.Add(vjezba);
        }
        public string DajTezinu()
        {
            return "Level " + (vjezbe.Count / 15 + 1).ToString();
        }
        public ProgramWorkout()
        {

        }
    }
}
