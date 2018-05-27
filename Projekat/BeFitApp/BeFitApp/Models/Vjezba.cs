using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BeFitApp.Models
{
    public class Vjezba
    {
		public int Id { get; set; }
        [DisplayName("Misicna Grupa")]
        public int MisicnaGrupaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        [DisplayName("Redni broj vježbe")]
        public int RedniBrojVjezbe { get; set; }


        [System.ComponentModel.DisplayName("Misicna Grupa")]
        public virtual MisicnaGrupa MisicnaGrupa { get; set; }
		
	
	}
}
