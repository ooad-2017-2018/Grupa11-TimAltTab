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
    public sealed partial class KlijentOsnovniPodaciPage : Page
    {
        public KlijentOsnovniPodaciPage()
        {
            InitializeComponent();
            ime.Naziv = "Ime:";
            prezime.Naziv = "Prezime:";
            username.Naziv = "Username:";
            email.Naziv = "E-Mail:";
            
        }
        public KlijentOsnovniPodaciPage(Klijent klijent)
        {
            this.InitializeComponent();

            ime.Naziv = "Ime:";
            ime.Podatak = klijent.Ime;
            prezime.Naziv = "Prezime:";
            prezime.Podatak = klijent.Prezime;
            username.Naziv = "Username:";
            username.Podatak = klijent.Username;
            email.Naziv = "E-Mail:";
            email.Podatak = klijent.Email;
        }
    }
}
