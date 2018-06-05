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
	public class UcitavanjeVjezbi
	{
		private static UcitavanjeVjezbi uniqueInstance = null;

		private UcitavanjeVjezbi()
		{

		}

		public static UcitavanjeVjezbi GetInstance()
		{
			if(uniqueInstance == null)
			{
				uniqueInstance = new UcitavanjeVjezbi();
			}
			return uniqueInstance;
		}

		public async Task<Tuple<string, string>> UcitajOpisVjezbe(MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
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

		public async Task<List<BitmapImage>> UcitajSlikeVjezbe(Vjezba vjezba)
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

		private Task<BitmapImage> UcitajSlikuVjezbe(Vjezba vjezba, int redniBrojSlike) 
		{
			string fajl = $"Assets\\Vjezbe\\{vjezba.MisicnaGrupa.Naziv}\\Vjezba{vjezba.RedniBrojVjezbe}\\Slika{redniBrojSlike}.jpg";

			return UcitajSliku(fajl);
		}

		public Task<BitmapImage> UcitajSlikuGrupe(MisicnaGrupa misicnaGrupa) 
		{
			string fajl = $"Assets\\SlikeMisicnihGrupa\\{misicnaGrupa.Naziv}.jpg";

			return UcitajSliku(fajl);
		}

		private async Task<BitmapImage> UcitajSliku(string path) 
		{
			StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
			StorageFile file = await folder.GetFileAsync(path);
			Windows.Storage.Streams.IRandomAccessStream str = (await file.OpenStreamForReadAsync()).AsRandomAccessStream();

			BitmapImage slika = new BitmapImage();

			await slika.SetSourceAsync(str);

			return slika;
		}
	}
}
