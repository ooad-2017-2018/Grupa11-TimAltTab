using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class OpcijeProfilaPage : Page
    {
        KlijentViewModel klijentViewModel;
        public OpcijeProfilaPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            klijentViewModel = e.Parameter as KlijentViewModel;
        }

        // update email
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            klijentViewModel.Email = emailTextBox.Text;
            await StaticHelper.PromijeniEmail(klijentViewModel.Klijent, emailTextBox.Text);
            await (new Windows.UI.Popups.MessageDialog("Uspješno promijenjen e-mail")).ShowAsync();

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(StaticHelper.CreateMD5(stariPassword.Password) != klijentViewModel.Klijent.Password)
            {
                await (new Windows.UI.Popups.MessageDialog("Stari password netačan")).ShowAsync();
            }
            else if(passwordTextBox.Password == potvrdiPasswordTextBox.Password)
            {
                await StaticHelper.PromijeniPassword(klijentViewModel.Klijent, passwordTextBox.Password);
                await (new Windows.UI.Popups.MessageDialog("Uspješno promijenjen password")).ShowAsync();
            }
            else
            {
                await (new Windows.UI.Popups.MessageDialog("Passwordi se ne poklapaju")).ShowAsync();
            }
        }
    }
}
