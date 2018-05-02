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
	public static class BeFit
	{
		private static string[] misicneGrupeImena = { "Neck", "Traps", "Shoulders", "Chest", "Lats", "Middle back", "Lower back", "Abs", "Biceps", "Triceps", "Forearm", "Glutes", "Quads", "Hamstrings", "Calves" };

		private static List<Korisnik> korisnici = new List<Korisnik>();
		private static List<ProgramWorkout> programi = new List<ProgramWorkout>();
		private static List<Vjezba> vjezbe = new List<Vjezba>();
		private static List<MisicnaGrupa> misicneGrupe = new List<MisicnaGrupa>();

		private static Admin admin;

		static BeFit()
		{
			inicijalizujMisicneGrupe();
			inicijalizujVjezbe();
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
	}
}
