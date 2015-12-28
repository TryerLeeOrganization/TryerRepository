using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Text;
using Tools;

namespace WebApplication.Controllers
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

        public ActionResult ApiStore()
        {
            string url = "WeatherUrl".ValueOfAppSettings();
            string param = "city=beijing";

            string result = NetWorkService.Request(url, param);

            int startStrLength = "{\"HeWeather data service 3.0\":[".Length;
            int lastLocation = result.LastIndexOf("]}");
            result = result.Substring(startStrLength, lastLocation - startStrLength);
            ViewBag.Message = result;

            return View();
        }

        public string GetWeather(string cityName)
        {
            string url = "WeatherUrl".ValueOfAppSettings();
            string param = "city=" + cityName;

            string result = NetWorkService.Request(url, param);

            return result;
        }






    }
}