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
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BeFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        private async void loginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var korisnik = (await StaticHelper.UcitajKorisnika(usernameTextBox.Text));
                if (korisnik is Admin)
                {
                    this.Frame.Navigate(typeof(AdminPage));
                }
                else if (korisnik is Klijent)
                {
                    this.Frame.Navigate(typeof(KlijentHomePage), new KlijentViewModel(korisnik as Klijent));
                }
                else if (korisnik is Trener)
                {
                    this.Frame.Navigate(typeof(TrenerHomePage));
                }

            }
            catch (Exception ex)
            {
                await (new MessageDialog(ex.Message)).ShowAsync();
            }
            
           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
             this.Frame.Navigate(typeof(RegistracijaPage));
        }
    }
}
