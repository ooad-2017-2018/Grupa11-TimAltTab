using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
	public static class KONTEJNERSKA
	{
		private static readonly string[] misicneGrupeImena = { "Neck", "Traps", "Shoulders", "Chest", "Lats", "Middle-back", "Lower-back", "Abs", "Biceps", "Triceps", "Forearm", "Glutes", "Quads", "Hamstrings", "Calves" };

		private static List<Korisnik> korisnici = new List<Korisnik>();
		private static List<ProgramWorkout> programi = new List<ProgramWorkout>();
		private static List<Vjezba> vjezbe = new List<Vjezba>();
		private static List<MisicnaGrupa> misicneGrupe = new List<MisicnaGrupa>();

		private static Admin admin;

		public static List<Korisnik> Korisnici { get => korisnici; }
		public static List<ProgramWorkout> Programi { get => programi; }
		public static List<Vjezba> Vjezbe { get => vjezbe; }
		public static List<MisicnaGrupa> MisicneGrupe { get => misicneGrupe; }

		static KONTEJNERSKA()
		{
			InicijalizujMisicneGrupeIVjezbe();
		}

		private static void InicijalizujMisicneGrupeIVjezbe()
		{
			foreach (string nazivGrupe in misicneGrupeImena)
			{
				MisicnaGrupa misicnaGrupa = new MisicnaGrupa(nazivGrupe);

				misicneGrupe.Add(misicnaGrupa);

				InicijalizujVjezbu(misicnaGrupa, 1);
				InicijalizujVjezbu(misicnaGrupa, 2);
			}

		}

		private static async void InicijalizujVjezbu(MisicnaGrupa misicnaGrupa, int redniBrojVjezbe)
		{
			var data = await UcitavanjeVjezbi.GetInstance().UcitajOpisVjezbe(misicnaGrupa, redniBrojVjezbe);

			string nazivVjezbe = data.Item1;
			string opis = data.Item2;

			vjezbe.Add(new Vjezba(nazivVjezbe, opis, misicnaGrupa, redniBrojVjezbe));
		}

        public static Vjezba DajVjezbu(string nazivMisicneGrupe, int redniBroj)
        {
            foreach (var i in vjezbe)
            {
                if (i.MisicnaGrupa.Naziv == nazivMisicneGrupe && i.RedniBrojVjezbe == redniBroj)
                {
                    return i;
                }
            }
            throw new Exception("Ne postoji vjezba.");
        }

        public static Klijent DajTestnog()
        {
            var testni = new Klijent();
            testni.Ime = "Fako";
            testni.Prezime = "Fakoni";
            testni.Email = "fako@gg.com";
            testni.Id = "gg";
            testni.Username = "fash";
            var tp = new KlijentProgram();
            tp.Klijent = testni;
            tp.Naziv = "najjaciworkout";
            tp.DodajVjezbu(new VjezbaUProgramu(DajVjezbu("Neck", 1), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.DodajVjezbu(new VjezbaUProgramu(DajVjezbu("Neck", 1), 3, 4, new TimeSpan(0, 0, 30), "Srijeda"));
            tp.DodajVjezbu(new VjezbaUProgramu(DajVjezbu("Chest", 1), 3, 4, new TimeSpan(0, 0, 30), "Ponedjeljak"));
            tp.DodajVjezbu(new VjezbaUProgramu(DajVjezbu("Triceps", 1), 3, 4, new TimeSpan(0, 0, 30), "Petak"));
            testni.MojiProgrami.Add(tp);
            return testni;
        }
    }
}
