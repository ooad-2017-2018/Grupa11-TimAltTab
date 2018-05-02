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
		
		public BitmapImage Slika1
		{
			get => new BitmapImage(new Uri($"ms-appx://BeFit/Assets/Vjezbe/{misicnaGrupa.Naziv}/Vjezba{redniBrojVjezbe}/Slika1.jpg"));		
		}

		public BitmapImage Slika2
		{
			get => new BitmapImage(new Uri($"ms-appx://BeFit/Assets/Vjezbe/{misicnaGrupa.Naziv}/Vjezba{redniBrojVjezbe}/Slika2.jpg"));		
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

	}
}
