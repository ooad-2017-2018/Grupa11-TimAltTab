using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace BeFit
{
    public class StaticHelperBaza
    {

        public static async Task<Korisnik> UcitajKorisnika(string username, string password = "")
        {
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            List<korisnici> lista = await VratiKorisnikaUsername(username, tabela);
            if (lista.Count != 1)
                throw new Exception("Ne postoji korisnik sa tim usernameom");
            var k = lista[0];
            if (k.hashPassworda != StaticHelperPassword.CreateMD5(password) && password != "")
                throw new Exception("Netačan password");
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
            else if (k.tipKorisnika == "Trener")
            {
                IMobileServiceTable<treneri> treneriTabela = App.MobileService.GetTable<treneri>();
                List<treneri> listaT = await NewMethod(k, treneriTabela);
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

        private static async Task<List<treneri>> NewMethod(korisnici k, IMobileServiceTable<treneri> treneriTabela)
        {
            var t = from x in treneriTabela
                    where x.korisnik_id == k.id
                    select x;
            var listaT = await t.ToListAsync();
            return listaT;
        }

        private static async Task<List<korisnici>> VratiKorisnikaUsername(string username, IMobileServiceTable<korisnici> tabela)
        {
            var items = from x in tabela
                        where x.username == username
                        select x;
            var lista = await items.ToListAsync();
            return lista;
        }

        public static async Task<Korisnik> UcitajKorisnikaID(string id)
        {
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            var items = from x in tabela
                        where x.id == id
                        select x;
            var lista = await items.ToListAsync();
            if (lista.Count != 1)
                throw new Exception("Ne postoji korisnik sa tim id-em");
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
            else if (k.tipKorisnika == "Trener")
            {
                IMobileServiceTable<treneri> treneriTabela = App.MobileService.GetTable<treneri>();
                var t = from x in treneriTabela
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

        public static async Task SpremiKorisnika(Korisnik korisnik)
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
            var L = await items.ToListAsync();
            if (L.Count != 0) throw new Exception("Već postoji korisnik sa tim usernameom");
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
        public static async Task SpremiKomentar(Komentar komentar)
        {
            komentari k = new komentari
            {
                text = komentar.Text,
                korisnik_id = komentar.Korisnik.Id
            };
            await App.MobileService.GetTable<komentari>().InsertAsync(k);
        }
        

        
        public static async Task PromijeniEmail(Korisnik korisnik, string email)
        {
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            var item = (await (from x in tabela
                               where x.id == korisnik.Id
                               select x).ToListAsync())[0];
            item.email = email;
            await tabela.UpdateAsync(item);
        }
        public static async Task PromijeniPassword(Korisnik korisnik, string noviPassword)
        {
            IMobileServiceTable<korisnici> tabela = App.MobileService.GetTable<korisnici>();
            var item = (await (from x in tabela
                               where x.id == korisnik.Id
                               select x).ToListAsync())[0];
            item.hashPassworda = StaticHelperPassword.CreateMD5(noviPassword);
            await tabela.UpdateAsync(item);
        }

        public static Klijent KlijentIzTabele(korisnici k)
        {
            var korisnik = new Klijent
            {
                Id = k.id,
                Email = k.email,
                Ime = k.ime,
                Prezime = k.prezime,
                Password = k.hashPassworda,
                Username = k.username
            };
            return korisnik;
        }
    }
}
