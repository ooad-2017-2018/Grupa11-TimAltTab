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
			inicijalizujMisicneGrupeIVjezbe();
            inicijalizujTestnogKlijenta();
		}

		private static void inicijalizujMisicneGrupeIVjezbe()
		{
			foreach (string naziv in misicneGrupeImena)
			{
				MisicnaGrupa misicnaGrupa = new MisicnaGrupa(naziv);

				misicneGrupe.Add(misicnaGrupa);

				inicijalizujVjezbu(misicnaGrupa, 1);
				inicijalizujVjezbu(misicnaGrupa, 2);
			}

		}

		private static void inicijalizujVjezbu(MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
		{
			FileStream fs = new FileStream($"Assets/Vjezbe/{misicnaGrupa.Naziv}/Vjezba{redniBrojVjezbe}/info.txt", FileMode.Open);

			StreamReader sr = new StreamReader(fs);

			string naziv = sr.ReadLine();
			string opis = sr.ReadToEnd();

			vjezbe.Add(new Vjezba(naziv, opis, misicnaGrupa, redniBrojVjezbe));

			sr.Dispose();
			fs.Dispose();
		}





        private static void inicijalizujTestnogKlijenta()
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
