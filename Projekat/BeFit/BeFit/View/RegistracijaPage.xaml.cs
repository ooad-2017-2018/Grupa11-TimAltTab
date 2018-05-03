using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BeFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaPage : Page
    {
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
        public RegistracijaPage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;

			sakrijTrenerUnos();
        }

        // SignUp Button
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Password.Password != textBox_PonovljeniPass.Password)
            {
                await (new Windows.UI.Popups.MessageDialog("Passwordi se ne poklapaju")).ShowAsync();
            }
            else
            {
                try
                {
                    if (klijent.IsChecked == true)
                    {
                        Klijent k = new Klijent
                        {
                            Ime = textBox_Ime.Text,
                            Prezime = textBox_Prezime.Text,
                            Password = StaticHelper.CreateMD5(textBox_Password.Password),
                            Username = textBox_Username.Text,
                            Email = textBox_Username.Text
                        };
                        await StaticHelper.SpremiKorisnika(k);
                    }
                    else
                    {
                        Trener k = new Trener
                        {
                            Ime = textBox_Ime.Text,
                            Prezime = textBox_Prezime.Text,
                            Password = StaticHelper.CreateMD5(textBox_Password.Password),
                            Username = textBox_Username.Text,
                            Email = textBox_Username.Text,
                            Biografija = textBox_OVama.Text,
                            KontaktTelefon = textBox_KontaktInfo.Text,
                            Lokacija = textBox_Grad.Text
                        };
                        await StaticHelper.SpremiKorisnika(k);
                    }
                    await (new Windows.UI.Popups.MessageDialog("Uspješna registracija")).ShowAsync();
                }
                catch (Exception ex)
                {
                    await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
                }
            }
        }

		private void klijent_Checked(object sender, RoutedEventArgs e)
		{
			sakrijTrenerUnos();
		}

		private void trener_Checked(object sender, RoutedEventArgs e)
		{
			prikaziTrenerUnos();
		}

		private void sakrijTrenerUnos()
		{
			if (textBlockGrad != null) textBlockGrad.Visibility = Visibility.Collapsed;
			if (textBox_Grad != null) textBox_Grad.Visibility = Visibility.Collapsed;
			if (textBlockOVama != null) textBlockOVama.Visibility = Visibility.Collapsed;
			if (textBox_OVama != null) textBox_OVama.Visibility = Visibility.Collapsed;
			if (textBlockKontaktInfo != null) textBlockKontaktInfo.Visibility = Visibility.Collapsed;
			if (textBox_KontaktInfo != null) textBox_KontaktInfo.Visibility = Visibility.Collapsed;
		}

		private void prikaziTrenerUnos()
		{
			if (textBlockGrad != null) textBlockGrad.Visibility = Visibility.Visible;
			if (textBox_Grad != null) textBox_Grad.Visibility = Visibility.Visible;
			if (textBlockOVama != null) textBlockOVama.Visibility = Visibility.Visible;
			if (textBox_OVama != null) textBox_OVama.Visibility = Visibility.Visible;
			if (textBlockKontaktInfo != null) textBlockKontaktInfo.Visibility = Visibility.Visible;
			if (textBox_KontaktInfo != null) textBox_KontaktInfo.Visibility = Visibility.Visible;
		}
	}
}
