using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pogoda.Models;


namespace Pogoda.Models
{

       public class PogodaData
        {
            public DateTime czas;
            public String mainWeather = String.Empty;
            public String lon = String.Empty;
            public String lat = String.Empty;                

            public String precipitation = String.Empty;
            public String description = String.Empty;   //charakter opadu
            public String temp_min = String.Empty;
            public String temp_max = String.Empty;
            public String humidity = String.Empty;
            public String pressure = String.Empty;
            public String cloudCover = String.Empty;
            public String img = String.Empty;

            public DateTime sunRise;
            public DateTime sunSet;
        }
}