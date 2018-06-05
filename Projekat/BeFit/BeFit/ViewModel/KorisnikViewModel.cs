using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace BeFit
{
    public class KorisnikViewModel : INotifyPropertyChanged
    {
        string ime;
        public string Ime { get { return ime; } set { ime = value; OnPropertyChanged("Ime"); } }
        string prezime;
        public string Prezime { get { return prezime; } set { prezime = value; OnPropertyChanged("Prezime"); } }
        string biografija;
        public string Biografija { get { return biografija; } set { biografija = value; OnPropertyChanged("Biografija"); } }
        string lokacija;
        public string Lokacija { get { return lokacija; } set { lokacija = value; OnPropertyChanged("Lokacija"); } }
        string kontaktTelefon;
        public string KontaktTelefon { get { return kontaktTelefon; } set { kontaktTelefon = value; OnPropertyChanged("KontaktTelefon"); } }
        string username;
        public string Username { get { return username; } set { username = value; OnPropertyChanged("Username"); } }
        string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged("Password"); } }
        string email;
        public string Email { get { return email; } set { email = value; OnPropertyChanged("Email"); } }
        bool tipKorisnika;
        public bool TipKorisnika { get { return tipKorisnika; } set { tipKorisnika = value; OnPropertyChanged("TipKorisnika"); } }
        string ponovljeniPass;
        public string PonovljeniPass { get { return ponovljeniPass; } set { ponovljeniPass = value; OnPropertyChanged("PonovljeniPass"); } }
        public ICommand SpremiKorisnika { get; set; }

        public KorisnikViewModel()
        {
            SpremiKorisnika = new RelayCommand(new Action(async () => await this.spremanjeKorisnika(null)));
           
        }

        public async Task spremanjeKorisnika(object parameter)
        {
            if (this.Password != this.PonovljeniPass)
            {
                await(new Windows.UI.Popups.MessageDialog("Passwordi se ne poklapaju")).ShowAsync();
            }
            else
            {
                try
                {
                    if (TipKorisnika == false)
                    {
                        if (Ime == null || Prezime == null ||
                            Password == null || Username == null ||Email == null)
                            throw new Exception("Sva polja moraju biti popunjena");
                        Klijent k = new Klijent
                        {
                            Ime = this.Ime,
                            Prezime = this.Prezime,
                            Password = StaticHelper.CreateMD5(this.Password),
                            Username = this.Username,
                            Email = this.Email
                        };
                        await StaticHelper.SpremiKorisnika(k);
                    }
                    else
                    {
                        if (Ime == null || Prezime == null ||
    Password == null || Username == null || Email == null || 
    Biografija == null || KontaktTelefon == null || Lokacija == null)
                            throw new Exception("Sva polja moraju biti popunjena");

                        Trener k = new Trener
                        {
                            Ime = this.Ime,
                            Prezime = this.Prezime,
                            Password = StaticHelper.CreateMD5(this.Password),
                            Username = this.Username,
                            Email = this.Email,
                            Biografija = this.Biografija,
                            KontaktTelefon = this.KontaktTelefon,
                            Lokacija = this.Lokacija
                        };
                        await StaticHelper.SpremiKorisnika(k);
                    }
                    await(new Windows.UI.Popups.MessageDialog("Uspješna registracija")).ShowAsync();
                }
                catch (Exception ex)
                {
                    await(new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
