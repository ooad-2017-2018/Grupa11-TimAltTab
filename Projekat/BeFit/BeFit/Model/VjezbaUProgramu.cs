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
		private DateTime vrijeme;

		public VjezbaUProgramu(Vjezba vjezba, int brojSetova, int brojRepova, DateTime vrijeme)
		{
			this.vjezba = vjezba;
			this.brojSetova = brojSetova;
			this.brojRepova = brojRepova;
			this.vrijeme = vrijeme;
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

		public DateTime Vrijeme
		{
			get => vrijeme;
			set => vrijeme = value;
		}
	}
}
