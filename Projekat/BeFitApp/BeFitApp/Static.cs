using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BeFitApp
{
    public class Static
    {
        public static int ProgramId { get; set; }
        public static int ProgramKomentarId { get; set; }
        public Static()
        {
            ProgramId = -1;
            ProgramKomentarId = -1;
        }
        private static async Task<int> GetID(string name)
        {
            int id = -1;
            var client = new HttpClient();
            var address = new Uri("http://befitapi.azurewebsites.net/api/korisniks");
            HttpResponseMessage response = await client.GetAsync(address);
            String stream = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(stream);
            foreach (dynamic d in dyn)
            {
                if (d.UserAjDi == name)
                    return d.Id;
            }
            return id;
        }
        public static int GetIDPrijavljenog(string name)
        {
            var task = GetID(name);
            task.Wait();
            return task.Result;
        }
        public static int GetPrijavljeni(string name)
        {
            var db = new BeFitApp.Models.OOADContext();
            var ids = db.Database.SqlQuery<int>("SELECT Id FROM dbo.Korisnik WHERE " +
               "UserAjDi = '" + name + "'").ToList();
            if (ids.Count == 0)
                return -1;
            return ids[0];
        }
        public static string GetImeIPrezime(int id)
        {
            var db = new BeFitApp.Models.OOADContext();
            var ids = db.Database.SqlQuery<string>("SELECT Ime FROM dbo.Korisnik WHERE " +
               "Id = " + id + "").ToList();
            if (ids.Count == 0)
                return "";
            return ids[0];
        }
    }
}