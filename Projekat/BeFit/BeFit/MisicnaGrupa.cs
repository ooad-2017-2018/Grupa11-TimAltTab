using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace BeFit
{
    public class MisicnaGrupa
    {
		private string naziv;
		private Image slika;

		public MisicnaGrupa(string naziv) => this.naziv = naziv;

		public string Naziv
		{
			get => naziv;
		}

		public Image Slika
		{
			get => slika;
			set => slika = value;
		}
    }
}
