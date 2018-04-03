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

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        public AdminPage()
        {
            this.InitializeComponent();
            List<string> L =  new List<string>{ "Šobe", "Fako", "Stompa"};
            comboBox1.ItemsSource = L;
            List<string> S = new List<string> { "Ime: AA\r\nVrijeme: BB", "Ime: CC\r\nVrijeme: DD",
            "Ime: CC\r\nVrijeme: DD", "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD",
            "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" ,
            "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" ,
            "Ime: CC\r\nVrijeme: DD" };
            listViewProfili.ItemsSource = S;
            listViewKomentari.ItemsSource = S;
        }
    }
}
