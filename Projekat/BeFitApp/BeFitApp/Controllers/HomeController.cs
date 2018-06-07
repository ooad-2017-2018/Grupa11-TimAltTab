using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeFitApp.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BeFitApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        string str = "";
        public async Task<ActionResult> ViewAPI()
        {
            var client = new HttpClient();
            var address = new Uri("http://befitapi.azurewebsites.net/api/korisniks");
            HttpResponseMessage response = await client.GetAsync(address);
            String stream = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(stream);
            foreach (dynamic d in dyn)
            {
                if (d.UserAjDi == User.Identity.Name)
                    str = d.Ime + " " + d.Prezime;
            }
            ViewBag.Message = str;
            return View();
        }
        
        public ActionResult Mapa()
        {
            return View();
        }

            public ActionResult GetLocations(double x, double y)
            {
                var task = Task.Run(async () => await AsyncGetLocations(x, y));
                task.Wait();
                var asyncFunctionResult = task.Result;
                return asyncFunctionResult;
            }
            public async Task<ActionResult> AsyncGetLocations(double x, double y)
            {
            
            var client = new HttpClient();
            var address = new Uri($"https://api.foursquare.com/v2/venues/search?ll={x},{y}&categoryId=4bf58dd8d48988d175941735&client_id=KHAWRYD4PJ0LKVSZQF4CEXTX5GK3BDPTWS3XLCTVAYQPK515&client_secret=BSTBTSNVENYHWGGNYGGQ00X33NJNNFTPZVIPOB3LGC1UVXBI&v=20160202");
            HttpResponseMessage response = await client.GetAsync(address);
            String stream = await response.Content.ReadAsStringAsync();
            dynamic dyn = JsonConvert.DeserializeObject(stream);
            var sp = stream.Split('"');
            double lat = 0;
            var locations = new List<Locations>();
            string loc = "n";
            for (int i = 0; i < sp.Length; i++)
            {
                if (sp[i] == "lat")
                    lat = Convert.ToDouble(sp[i + 1].Substring(1, sp[i + 1].Length - 2));
                if (sp[i] == "lng")
                {
                    for(int j = i; j >= 0; j-- )
                        if(sp[j] == "name")
                        {
                            loc = sp[j + 2];
                            break;
                        }
                    locations.Add(new Locations(lat, Convert.ToDouble(sp[i + 1].Substring(1, sp[i + 1].Length - 4)), loc));
                }
            }
           
            return Json(locations, JsonRequestBehavior.AllowGet);
            }

            

    }

}
namespace BeFitApp.Controllers
{
    class Locations
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string naziv { get; set; }
        public Locations(double latitude, double longitude, string naziv)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.naziv = naziv;
        }
    };
}