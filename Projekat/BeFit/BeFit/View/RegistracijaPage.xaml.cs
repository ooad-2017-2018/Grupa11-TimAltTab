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
            klijent.IsChecked = true;
            trener.IsChecked = false;
        }

        // SignUp Button
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (klijent.IsChecked == true)
                {
                    Klijent k = new Klijent
                    {
                        Ime = "",
                        Prezime = "",
                        Password = StaticHelper.CreateMD5(textBox_Password.Text),
                        Username = textBox_Username.Text,
                        Email = textBox_Username.Text
                    };
                    await StaticHelper.SpremiKorisnika(k);
                }
                else
                {
                    Trener k = new Trener
                    {
                        Ime = "",
                        Prezime = "",
                        Password = StaticHelper.CreateMD5(textBox_Password.Text),
                        Username = textBox_Username.Text,
                        Email = textBox_Username.Text,
                        Biografija = textbox_OVama.Text,
                        KontaktTelefon = textbox_KontaktInfo.Text,
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
}
