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
    public sealed partial class PregledProfilaTreneraPage : Page
    {
        Button buttonPlus = new Button();
        public PregledProfilaTreneraPage()
        {
            this.InitializeComponent();
            buttonPlus.Content = "+";
            buttonPlus.FontSize = 30;
            buttonPlus.HorizontalAlignment = HorizontalAlignment.Stretch;
            buttonPlus.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            buttonPlus.Background = new SolidColorBrush(Windows.UI.Colors.White);
            buttonPlus.Click += ButtonPlus_Click;
            programiStackPanel.Children.Add(buttonPlus);
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            programiStackPanel.Children.Remove(buttonPlus);
            programiStackPanel.Children.Add(buttonPlus);
        }
    }
}
