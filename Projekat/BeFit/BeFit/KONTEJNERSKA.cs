using System;
using System.Collections.Generic;
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
		private static string[] misicneGrupeImena = { "Neck", "Traps", "Shoulders", "Chest", "Lats", "Middle back", "Lower back", "Abs", "Biceps", "Triceps", "Forearm", "Glutes", "Quads", "Hamstrings", "Calves" };

		private static List<Korisnik> korisnici = new List<Korisnik>();
		private static List<ProgramWorkout> programi = new List<ProgramWorkout>();
		private static List<Vjezba> vjezbe = new List<Vjezba>();
		private static List<MisicnaGrupa> misicneGrupe = new List<MisicnaGrupa>();

		private static Admin admin;

        public static Klijent testni;

		static KONTEJNERSKA()
		{
			inicijalizujMisicneGrupe();
			inicijalizujVjezbe();
            inicijalizujTestnogKlijenta();
		}

		private static void inicijalizujMisicneGrupe()
		{
			foreach (string naziv in misicneGrupeImena)
			{
				misicneGrupe.Add(new MisicnaGrupa(naziv));
			}
		}

		private static async void inicijalizujVjezbe()
		{
			//
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
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba1", "ez", misicneGrupe[0]), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba2", "ez", misicneGrupe[0]), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba3", "ez", misicneGrupe[0]), 3, 4, new TimeSpan(0, 0, 30), "Ponedjeljak"));
            tp.dodajVjezbu(new VjezbaUProgramu(new Vjezba("vjezba4", "ez", misicneGrupe[0]), 3, 4, new TimeSpan(0, 0, 30), "Petak"));
            testni.MojiProgrami.Add(tp);
        }
	}
}
