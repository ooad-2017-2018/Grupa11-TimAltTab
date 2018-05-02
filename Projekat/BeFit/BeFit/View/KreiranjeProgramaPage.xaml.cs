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
    public sealed partial class KreiranjeProgramaPage : Page
    {
        Button buttonPlus = new Button();
        KlijentViewModel klijentViewModel;
        public KreiranjeProgramaPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            klijentViewModel = e.Parameter as KlijentViewModel;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> dani = new List<string> { "Ponedjeljak", "Utorak",
                        "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja"};
            danComboBox.ItemsSource = dani;
            buttonPlus.Content = "+";
            buttonPlus.FontSize = 30;
            buttonPlus.HorizontalAlignment = HorizontalAlignment.Stretch;
            buttonPlus.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            buttonPlus.Background = new SolidColorBrush(Windows.UI.Colors.White);
            buttonPlus.Click += ButtonPlus_Click;
            vjezbeStackPanel.Children.Add(buttonPlus);
            danComboBox.SelectedIndex = 0;
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vjezbeStackPanel.Children.Remove(buttonPlus);
            vjezbeStackPanel.Children.Add(buttonPlus);
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
            this.Frame.Navigate(typeof(PretragaVjezbiPage));
        }
    }
}
