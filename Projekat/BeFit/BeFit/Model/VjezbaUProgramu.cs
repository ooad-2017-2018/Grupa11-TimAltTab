using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class VjezbaUProgramu
    {
		private Vjezba vjezba;
		private int brojSetova;
		private int brojRepova;
		private TimeSpan vrijeme;
        private string dan;

        public VjezbaUProgramu(Vjezba vjezba, int brojSetova, int brojRepova, TimeSpan vrijeme, string dan)
        {
            this.vjezba = vjezba;
            this.brojSetova = brojSetova;
            this.brojRepova = brojRepova;
            this.vrijeme = vrijeme;
            this.dan = dan;
        }

        public Vjezba Vjezba
		{
			get => vjezba;
		}

		public int BrojSetova
		{
			get => brojSetova;
			set => brojSetova = value;
		}

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
    }
}
