using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace BeFit
{
    public class StaticHelper
    {

        public static async Task<Korisnik> UcitajKorisnika(string username)
        {
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            var items = from x in tabela
                        where x.username == username
                        select x;
            var lista = await items.ToListAsync();
            if (lista.Count != 1)
                throw new Exception("Ne postoji korisnik sa tim usernameom");
            var k = lista[0];
            Korisnik korisnik = null;
            if (k.tipKorisnika == "Klijent")
            {
                korisnik = new Klijent
                {
                    Id = k.id,
                    Email = k.email,
                    Ime = k.ime,
                    Prezime = k.prezime,
                    Password = k.hashPassworda,
                    Username = k.username
                };
            }
            else if(k.tipKorisnika == "Trener")
            {
                IMobileServiceTable<treneri> treneriTabela = App.MobileService.GetTable<treneri>();
                var t =     from x in treneriTabela
                            where x.korisnik_id == k.id
                            select x;
                var listaT = await t.ToListAsync();
                var elem = listaT[0];
                korisnik = new Trener
                {
                    Id = k.id,
                    Email = k.email,
                    Ime = k.ime,
                    Prezime = k.prezime,
                    Password = k.hashPassworda,
                    Username = k.username,
                    Biografija = elem.biografija,
                    Lokacija = elem.lokacija,
                    KontaktTelefon = elem.kontaktTelefon
                };
            }
            else
            {
                korisnik = new Admin
                {
                    Id = k.id,
                    Email = k.email,
                    Ime = k.ime,
                    Prezime = k.prezime,
                    Password = k.hashPassworda,
                    Username = k.username
                };
            }
            return korisnik;
        }
        public static async void SpremiKorisnika(Korisnik korisnik)
        {
            korisnici k = new korisnici
            {
                ime = korisnik.Ime,
                prezime = korisnik.Prezime,
                hashPassworda = korisnik.Password,
                username = korisnik.Username,
                email = korisnik.Email
            };
            if (korisnik is Admin) k.tipKorisnika = "Admin";
            else if (korisnik is Trener)
            k.tipKorisnika = "Trener";
            else k.tipKorisnika = "Klijent";
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            var items = from x in tabela
                        where x.username == korisnik.Username
                        select x;
            if ((await items.ToListAsync()).Count != 0) throw new Exception("Već postoji korisnik sa tim usernameom");
            await tabela.InsertAsync(k);
            if(k.tipKorisnika == "Trener")
            {
                Trener trener = korisnik as Trener;
                IMobileServiceTable<treneri> treneriTabela = App.MobileService.GetTable<treneri>();
                items = from x in tabela
                        where x.username == k.username
                        select x;
                var elem = (await items.ToListAsync())[0];
                treneri t = new treneri
                {
                    korisnik_id = elem.id,
                    biografija = trener.Biografija,
                    kontaktTelefon = trener.KontaktTelefon,
                    lokacija = trener.Lokacija
                };
                await treneriTabela.InsertAsync(t);
            }
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
