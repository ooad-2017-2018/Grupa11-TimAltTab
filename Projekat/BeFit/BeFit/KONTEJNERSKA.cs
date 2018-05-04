using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace BeFit
{
	public static class KONTEJNERSKA
	{
		private static string[] misicneGrupeImena = { "Neck", "Traps", "Shoulders", "Chest", "Lats", "Middle-back", "Lower-back", "Abs", "Biceps", "Triceps", "Forearm", "Glutes", "Quads", "Hamstrings", "Calves" };

		private static List<Korisnik> korisnici = new List<Korisnik>();
		private static List<ProgramWorkout> programi = new List<ProgramWorkout>();
		private static List<Vjezba> vjezbe = new List<Vjezba>();
		private static List<MisicnaGrupa> misicneGrupe = new List<MisicnaGrupa>();

		private static Admin admin;

		public static List<Korisnik> Korisnici { get => korisnici; }
		public static List<ProgramWorkout> Programi { get => programi; }
		public static List<Vjezba> Vjezbe { get => vjezbe; }
		public static List<MisicnaGrupa> MisicneGrupe { get => misicneGrupe; }

		public static Klijent testni;

		static KONTEJNERSKA()
		{
			InicijalizujMisicneGrupeIVjezbe();
            InicijalizujTestnogKlijenta();
		}

		private static async void InicijalizujMisicneGrupeIVjezbe()
		{
			foreach (string naziv in misicneGrupeImena)
			{
				MisicnaGrupa misicnaGrupa = new MisicnaGrupa(naziv);

				misicneGrupe.Add(misicnaGrupa);

				await Task.Run(new Action(() => { InicijalizujVjezbu(misicnaGrupa, 1); }));
				await Task.Run(new Action(() => { InicijalizujVjezbu(misicnaGrupa, 2); }));
			}

		}

		private static async void InicijalizujVjezbu(MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
		{
			string fajl = $"Assets\\Vjezbe\\{misicnaGrupa.Naziv}\\Vjezba{redniBrojVjezbe}\\info.txt";
			StorageFolder folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
			StorageFile file = await folder.GetFileAsync(fajl);
			Stream str = await file.OpenStreamForReadAsync();
			StreamReader sr = new StreamReader(str);

			string naziv = sr.ReadLine();
			string opis = sr.ReadToEnd();

			vjezbe.Add(new Vjezba(naziv, opis, misicnaGrupa, redniBrojVjezbe));

		}


        private static void InicijalizujTestnogKlijenta()
        {
            testni = new Klijent();
            testni.Ime = "fako";
            testni.Prezime = "fakoni";
            testni.Email = "fako@gg.com";
            testni.Id = "gg";
            testni.Username = "fash";
            var tp = new KlijentProgram();
            tp.Klijent = testni;
            tp.Naziv = "najjaciworkout";
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba1", "ez", misicneGrupe[0], 1), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba2", "ez", misicneGrupe[0], 2), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba3", "ez", misicneGrupe[0], 1), 3, 4, new TimeSpan(0, 0, 30), "Ponedjeljak"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba4", "ez", misicneGrupe[0], 2), 3, 4, new TimeSpan(0, 0, 30), "Petak"));
            testni.MojiProgrami.Add(tp);
        }
	}
}
