using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace BeFit
{
    public class MisicnaGrupa
    {
		private string naziv;

		public MisicnaGrupa(string naziv) => this.naziv = naziv;

		public string Naziv
		{
			get => naziv;
		}

		public async Task<BitmapImage> DajSlikuGrupe()
		{
			return await UcitavanjeVjezbi.GetInstance().UcitajSlikuGrupe(this);
		}
	}
}
