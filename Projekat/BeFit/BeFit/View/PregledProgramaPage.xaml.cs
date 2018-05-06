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
    public sealed partial class PregledProgramaPage : Page
    {
        ProgramWorkout program;
        Button buttonPlus = new Button();
        public PregledProgramaPage()
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
            program = e.Parameter as ProgramWorkout;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            List<string> dani = new List<string> { "Ponedjeljak", "Utorak",
                        "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja"};
            danComboBox.ItemsSource = dani;
            buttonPlus.Content = "+";
            buttonPlus.FontSize = 30;
            buttonPlus.HorizontalAlignment = HorizontalAlignment.Stretch;
            buttonPlus.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            buttonPlus.Background = new SolidColorBrush(Windows.UI.Colors.White);
            buttonPlus.Click += ButtonPlus_Click;
            // vjezbeStackPanel.Children.Add(buttonPlus);
            danComboBox.SelectedIndex = 0;
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // vjezbeStackPanel.Children.Remove(buttonPlus);
            // vjezbeStackPanel.Children.Add(buttonPlus);
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
        }

        private void danComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vjezbeStackPanel.Children.Clear();
            foreach (var i in program.Vjezbe)
            {
                if (i.Dan == danComboBox.SelectedValue as string)
                {
                    vjezbeStackPanel.Children.Add(new VjezbaControl(i));
                }
            }
        }
    }
}
