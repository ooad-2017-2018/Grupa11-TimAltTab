using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BeFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PregledVjezbePage : Page
    {
        VjezbaUProgramu vjezba;
        public PregledVjezbePage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
        }
        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                e.Handled = true;
                this.Frame.GoBack();
                this.Frame.BackStack.Clear();
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            vjezba = e.Parameter as VjezbaUProgramu;
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            textNazivVjezbe.Text = vjezba.Vjezba.Naziv;
            textOpisVjezbe.Text = vjezba.Vjezba.Opis;
            textboxBrojSetova.Text = vjezba.BrojSetova.ToString();
            textboxBrojPonavljanja.Text = vjezba.BrojRepova.ToString();
            textboxVrijemeVjezbe.Text = vjezba.Vrijeme.ToString();
            ucitajSlike();
        }
        private async void ucitajSlike()
        {
            BitmapImage slika1 = new BitmapImage();
            BitmapImage slika2 = new BitmapImage();
            BitmapImage slika3 = new BitmapImage();

            slika1 = (await vjezba.Vjezba.DajSlikeVjezbe())[0];
            imageVjezbaDio1.Source = slika1;
            slika2 = (await vjezba.Vjezba.DajSlikeVjezbe())[1];
            imageVjezbaDio2.Source = slika2;
            slika3 = await vjezba.Vjezba.MisicnaGrupa.DajSlikuGrupe();
            imageMisicnaGrupa.Source = slika3;
        }
    }
}
