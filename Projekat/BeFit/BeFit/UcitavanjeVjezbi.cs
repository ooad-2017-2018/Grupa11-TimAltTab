using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace BeFit
{
	public static class UcitavanjeVjezbi
	{
		public static async Task<Tuple<string, string>> UcitajOpisVjezbe(MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
		{
			string fajl = $"Assets\\Vjezbe\\{misicnaGrupa.Naziv}\\Vjezba{redniBrojVjezbe}\\info.txt";

			StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
			StorageFile file = await folder.GetFileAsync(fajl);
			Stream str = await file.OpenStreamForReadAsync();
			StreamReader sr = new StreamReader(str);

			string naziv = sr.ReadLine();
			string opis = sr.ReadToEnd();

			return new Tuple<string, string>(naziv, opis);
		}

		public static async Task<List<BitmapImage>> UcitajSlikeVjezbe(Vjezba vjezba)
		{
			//BitmapImage slika1 = new BitmapImage(new Uri($"ms-appx://BeFit/Assets/Vjezbe/{vjezba.MisicnaGrupa.Naziv}/Vjezba{vjezba.RedniBrojVjezbe}/Slika1.jpg"));
			//BitmapImage slika2 = new BitmapImage(new Uri($"ms-appx://BeFit/Assets/Vjezbe/{vjezba.MisicnaGrupa.Naziv}/Vjezba{vjezba.RedniBrojVjezbe}/Slika2.jpg"));			

			var slika1 = await UcitajSlikuVjezbe(vjezba, 1);
			var slika2 = await UcitajSlikuVjezbe(vjezba, 2);

			return new List<BitmapImage>(new BitmapImage[]
			{
					slika1,
					slika2
			});
		}

		private static async Task<BitmapImage> UcitajSlikuVjezbe(Vjezba vjezba, int redniBrojSlike)
		{
			string fajl = $"Assets\\Vjezbe\\{vjezba.MisicnaGrupa.Naziv}\\Vjezba{vjezba.RedniBrojVjezbe}\\Slika{redniBrojSlike}.jpg";

			StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
			StorageFile file = await folder.GetFileAsync(fajl);
			Windows.Storage.Streams.IRandomAccessStream str = (await file.OpenStreamForReadAsync()).AsRandomAccessStream();

			BitmapImage slika = new BitmapImage();

			await slika.SetSourceAsync(str);

			return slika;
		}
	}
}
