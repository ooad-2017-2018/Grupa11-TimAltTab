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
    public sealed partial class PretragaObjekataPage : Page
    {
        string stringURI = "bingmaps:&q=Gym,%20Sarajevo";
        public PretragaObjekataPage()
        {
            this.InitializeComponent();
            RadioButtonTeretane.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            stringURI = "bingmaps:&q=Gym,%20Sarajevo";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            stringURI = "bingmaps:&q=Protein%20shop,%20Sarajevo";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RadioButtonProteinShopovi.IsChecked = false;
            RadioButtonTeretane.IsChecked = false;
            stringURI = "bingmaps:&q=" + (sender as TextBox).Text + ",%20Sarajevo";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var pretragaURI = new Uri(stringURI);
            var launcherOptions = new Windows.System.LauncherOptions();
            launcherOptions.TargetApplicationPackageFamilyName = "Microsoft.WindowsMaps_8wekyb3d8bbwe";
            var success = await Windows.System.Launcher.LaunchUriAsync(pretragaURI, launcherOptions);
        }
    }
}
