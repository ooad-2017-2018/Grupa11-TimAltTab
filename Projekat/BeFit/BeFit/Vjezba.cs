using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BeFit
{
    public class Vjezba
    {
		private string naziv;
		private string opis;
		private MisicnaGrupa misicnaGrupa;
		private List<Image> slike;

		public Vjezba(string naziv, string opis, MisicnaGrupa misicnaGrupa)
		{
			this.naziv = naziv;
			this.opis = opis;
			this.misicnaGrupa = misicnaGrupa;

			slike = new List<Image>();
		}

		public string Naziv
		{
			get => naziv;
		}

		public string Opis
		{
			get => opis;
			set => opis = value;
		}

		public List<Image> Slike
		{
			get => slike;
			set => slike = value;
		}

		public MisicnaGrupa MisicnaGrupa
		{
			get => misicnaGrupa;
		}

	}
}
