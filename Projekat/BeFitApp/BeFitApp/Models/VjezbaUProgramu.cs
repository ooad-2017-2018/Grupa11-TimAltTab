using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BeFitApp.Models
{
    public class VjezbaUProgramu
    {
		private int brojSetova;
		private int brojRepova;
		private TimeSpan vrijeme;
        private string dan;

      

        public int Id { get; set; }
        [DisplayName("Vjezba")]
        public int VjezbaId { get; set; }
        [DisplayName("Broj setova")]
		public int BrojSetova
		{
			get => brojSetova;
			set => brojSetova = value;
		}
        [DisplayName("Broj ponavljanja")]
		public int BrojRepova
		{
			get => brojRepova;
			set => brojRepova = value;
		}

		public TimeSpan Vrijeme
		{
			get => vrijeme;
			set => vrijeme = value;
		}
        public string Dan
        {
            get => dan;
            set => dan = value;
        }
        public int ProgramId { get; set; }
        public virtual Vjezba Vjezba { get; set; }
    }
}
