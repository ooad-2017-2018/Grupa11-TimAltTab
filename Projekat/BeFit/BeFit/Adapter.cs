using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
	interface IKlijentStatistika
	{
		double ProsjecnaCijenaKupljenogPrograma();
		double UkupnoPotrosenoNovcaNaPrograme();
		int BrojKupljenihPrograma();

	}
	class AdapterKlijent:Klijent, IKlijentStatistika
	{
		public int BrojKupljenihPrograma()
		{
			return this.KupljeniProgrami.Count;
		}
		public double UkupnoPotrosenoNovcaNaPrograme()
		{
			double svota = 0;
			foreach(var i in this.KupljeniProgrami)
			{
				svota += i.Cijena;
			}
			return svota;
		}
		public double ProsjecnaCijenaKupljenogPrograma()
		{
			return UkupnoPotrosenoNovcaNaPrograme() / BrojKupljenihPrograma();
		}
	}
}
