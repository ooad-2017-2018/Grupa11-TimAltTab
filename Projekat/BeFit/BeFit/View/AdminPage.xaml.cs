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
using Microsoft.WindowsAzure.MobileServices;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BeFit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        List<string> commentTexts = new List<string>();
        public AdminPage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
            List<string> S = new List<string> { "Ime: AA\r\nVrijeme: BB", "Ime: CC\r\nVrijeme: DD",
            "Ime: CC\r\nVrijeme: DD", "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD",
            "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" ,
            "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" , "Ime: CC\r\nVrijeme: DD" ,
            "Ime: CC\r\nVrijeme: DD" };
            listViewProfili.ItemsSource = S;
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

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
                comboBox1.ItemsSource = await (from x in tabela select x.ime + " " + x.prezime + ", " + x.username).ToListAsync();
                comboBox1.SelectedIndex = 0;
                var comm = App.MobileService.GetTable<komentari>();
                var items = await (from x in comm select x).ToListAsync();
                List<string> komentari = new List<string>();
                foreach (var item in items)
                {
                    var korisnik = await StaticHelper.UcitajKorisnikaID(item.korisnik_id);
                    komentari.Add("Korisnik: " + korisnik.Username + "\r\n" + 
                                  "Vrijeme: " + item.createdAt.ToString());
                    ListViewItem listViewItem = new ListViewItem();
                    commentTexts.Add(item.text);
                    listViewItem.Content = komentari.Last<string>();
                    listViewKomentari.Items.Add(listViewItem);
                }
                listViewKomentari.SelectedIndex = 0;   
            }
            catch(Exception ex)
            {
                await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
            }
        }

        private async void listViewKomentari_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                await (new Windows.UI.Popups.MessageDialog(commentTexts[listViewKomentari.SelectedIndex]).ShowAsync());
            }
            catch (Exception ex)
            {
                await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
            }
        }

        private void listViewKomentari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
