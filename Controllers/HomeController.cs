using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pogoda.Models;


namespace Pogoda.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index() {
            
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Cześć" : "Czołem";
            //https://openweathermap.org/current

            return View("pogoda");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
