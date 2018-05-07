using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{
    public class Korisnik
    {
        string id;
        string ime;
        string prezime;
        string username;
        string password;
        string email;

        public string Id { get => id; set => id = value; }
        public string Ime {
            get => ime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Ime ne smije biti prazno");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Ime ne smije sadržavati ništa osim slova");
                if (value.Substring(1,value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo imena može biti veliko");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo imena mora biti veliko");
                ime = value;
            }
        }
        public string Prezime
        {
            get => prezime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Prezime ne smije biti prazno");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Prezime ne smije sadržavati ništa osim slova");
                if (value.Substring(1, value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo prezimena može biti veliko");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo prezimena mora biti veliko");
                prezime = value;
            }
        }
        public string Username
        {
            get => username;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Username ne smije biti prazno");
                username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Password ne smije biti prazan");
                password = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
               if(string.IsNullOrWhiteSpace(value) || !System.Text.RegularExpressions.Regex.IsMatch(value, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    throw new Exception("Email nevalidan");
                email = value;
            }
        }
    }
}
