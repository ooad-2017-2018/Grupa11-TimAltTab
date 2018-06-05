using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace BeFit
{
    public class Vjezba
    {
		private string naziv;
		private string opis;
		private MisicnaGrupa misicnaGrupa;
		private int redniBrojVjezbe;

		public Vjezba(string naziv, string opis, MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
		{
			this.naziv = naziv;
			this.opis = opis;
			this.misicnaGrupa = misicnaGrupa;
			this.redniBrojVjezbe = redniBrojVjezbe;
		}
		
		public async Task<List<BitmapImage>> DajSlikeVjezbe()
		{
			return await UcitavanjeVjezbi.GetInstance().UcitajSlikeVjezbe(this);	
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

		public MisicnaGrupa MisicnaGrupa
		{
			get => misicnaGrupa;
		}

		public int RedniBrojVjezbe
		{
			get => redniBrojVjezbe;
		}

	}
}
