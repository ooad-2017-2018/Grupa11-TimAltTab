using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace BeFit
{
    class PromjenaKlijentaViewModel : INotifyPropertyChanged
    {
        Klijent klijent;
        string email;
        public string Email { get { return email; } set { email = value; OnPropertyChanged("Email"); } }
        string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged("Password"); } }
        string stariPassword;
        public string StariPassword { get { return stariPassword; } set { stariPassword = value; OnPropertyChanged("StariPassword"); } }

        string ponovljeniPass;
        public string PonovljeniPass { get { return ponovljeniPass; } set { ponovljeniPass = value; OnPropertyChanged("PonovljeniPass"); } }
        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; OnPropertyChanged("Klijent"); }
        }
       
        public ICommand PromjenaEmaila { get; set; }
        public ICommand PromjenaPassworda { get; set; }
        
        public PromjenaKlijentaViewModel(Klijent k)
        {
            Klijent = k;
            PromjenaEmaila = new RelayCommand(new Action(async () => await UpdateEmaila()));
            PromjenaPassworda = new RelayCommand(new Action(async () => await UpdatePassworda()));
        }



        public async Task UpdatePassworda()
        {
            try
            {
                if (StaticHelper.CreateMD5(StariPassword) != Klijent.Password)
                {
                    await (new Windows.UI.Popups.MessageDialog("Stari password netačan")).ShowAsync();
                }
                else if (Password == PonovljeniPass)
                {
                    await StaticHelper.PromijeniPassword(Klijent, Password);
                    await (new Windows.UI.Popups.MessageDialog("Uspješno promijenjen password")).ShowAsync();
                }
                else
                {
                    await (new Windows.UI.Popups.MessageDialog("Passwordi se ne poklapaju")).ShowAsync();
                }
            }
            catch(Exception ex)
            {
                await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
            }
        }
        public async Task UpdateEmaila()
        {
            try
            {
                Klijent.Email = Email;
                await StaticHelper.PromijeniEmail(Klijent, Email);
                await (new Windows.UI.Popups.MessageDialog("Uspješno promijenjen e-mail")).ShowAsync();
            }
            catch (Exception ex)
            {
                await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
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
