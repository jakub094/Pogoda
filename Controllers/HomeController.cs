using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pogoda.Models;


namespace Pogoda.Controllers
{
    public class Globalne
    {
        public static String city = "Rzeszow";
        public static String countryCode = "pl";
        //public static Dictionary<String, String> imgResolver = new Dictionary<String, String>();
    }
    public class City {
        public string place { get; set; }
        public string countryCode { get; set; }
        }
    public class HomeController : Controller
    {
        List<PogodaData> lista = new List<PogodaData>();
       public ViewResult Index() {
            
            int hour = DateTime.Now.Hour;
            //https://openweathermap.org/current

            return View("pogoda");
        }
        [HttpGet]
        public ViewResult pogoda() {
            return View("pogoda");
        }
        [HttpPost]
        public ViewResult pogoda(City city) {


            Globalne.city = city.place.Trim();
            Globalne.countryCode = "pl";
            if (city.countryCode != null && city.countryCode.Trim().Length > 0)
                Globalne.countryCode = city.countryCode.Trim();
            
            ViewBag.City = city.place;
            PogodaData pd = getPogoda();
            lista.Add(pd);
            getPrognoza();

            return View("pogoda", lista);
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

      PogodaData getPogoda() {
            PogodaData ret = new PogodaData();
            String baseurl = "http://api.openweathermap.org/data/2.5/weather?q="
                            + Globalne.city 
                            + "," + Globalne.countryCode 
                            + "&mode=xml&appid=1f7cff01e11e11b2533f9497da9ee055";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            Console.WriteLine(baseurl);
            request.Method = "POST";
            request.Accept = "application/json";
            request.UserAgent = "curl/7.37.0";
            request.ContentType = "application/x-www-form-urlencoded";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string data = "browser=Win7x64-C1|Chrome32|1024x768&url=http://www.google.com";

                streamWriter.Write(data);
            }
            
            var response = request.GetResponse();
            string text;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
                //values.Add(text);
                //Console.WriteLine(text);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
                XmlNode node = doc.DocumentElement.SelectSingleNode("/current/city/sun");
                string ssunRise = node.Attributes["rise"].InnerText;
                string ssunSet = node.Attributes["set"].InnerText;
                ssunRise.Replace("T", " ");
                ssunSet.Replace("T", " ");
                Console.WriteLine("sunRise: " + ssunRise);
                Console.WriteLine("sunSet: " + ssunRise);

                ret.sunRise = DateTime.Parse(ssunRise).AddHours(1);
                ret.sunSet = DateTime.Parse(ssunSet).AddHours(1);
                node = doc.DocumentElement.SelectSingleNode("/current/city/coord");
/*
                ret.lon =   Double.Parse(node.Attributes["lon"].InnerText, 
                            System.Globalization.NumberStyles.AllowDecimalPoint,
                            System.Globalization.NumberFormatInfo.InvariantInfo).ToString("#0.00");
                ret.lat =   Double.Parse(node.Attributes["lat"].InnerText, 
                            System.Globalization.NumberStyles.AllowDecimalPoint,
                            System.Globalization.NumberFormatInfo.InvariantInfo).ToString("#0.00");
*/
                string timeFrom = doc.DocumentElement.SelectSingleNode("/current/lastupdate").Attributes["value"].InnerText;
                timeFrom.Replace("T", " ");
                ret.czas = DateTime.Parse(timeFrom).AddHours(1);
                ret.mainWeather = doc.DocumentElement.SelectSingleNode("/current/weather").Attributes["value"].InnerText;
                ret.img = "http://openweathermap.org/img/w/" + doc.DocumentElement.SelectSingleNode("/current/weather").Attributes["icon"].InnerText +".png";
                ret.cloudCover = doc.DocumentElement.SelectSingleNode("/current/clouds").Attributes["value"].InnerText;
                ret.description = doc.DocumentElement.SelectSingleNode("/current/clouds").Attributes["name"].InnerText;
                ret.pressure = doc.DocumentElement.SelectSingleNode("/current/pressure").Attributes["value"].InnerText;
                ret.humidity = doc.DocumentElement.SelectSingleNode("/current/humidity").Attributes["value"].InnerText;
                ret.temp_max = doc.DocumentElement.SelectSingleNode("/current/temperature").Attributes["value"].InnerText; 
                double temp = Double.Parse(ret.temp_max, 
                            System.Globalization.NumberStyles.AllowDecimalPoint, 
                            System.Globalization.NumberFormatInfo.InvariantInfo);
                if ("kelvin".CompareTo(doc.DocumentElement.SelectSingleNode("/current/temperature").Attributes["unit"].InnerText) == 0)
                    ret.temp_max = (temp - 273.15).ToString("#0.#");
            }            

            return ret;
        }
        void getPrognoza()
        {
            String baseurl = "http://api.openweathermap.org/data/2.5/forecast?q=" 
                + Globalne.city + "," 
                + Globalne.countryCode 
                + "&mode=xml&appid=1f7cff01e11e11b2533f9497da9ee055";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseurl);
            Console.WriteLine(baseurl);
            request.Method = "POST";
            request.Accept = "application/json";
            //request.Credentials = new NetworkCredential(username, password);
            request.UserAgent = "curl/7.37.0";
            request.ContentType = "application/x-www-form-urlencoded";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string data = "browser=Win7x64-C1|Chrome32|1024x768&url=http://www.google.com";

                streamWriter.Write(data);
            }

            var response = request.GetResponse();
            string text;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
                //values.Add(text);
                //Console.WriteLine(text);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
                XmlNode node = doc.DocumentElement.SelectSingleNode("/weatherdata/sun");
                string ssunRise = node.Attributes["rise"].InnerText;
                string ssunSet = node.Attributes["set"].InnerText;
                ssunRise.Replace("T", " ");
                ssunSet.Replace("T", " ");
                node = doc.DocumentElement.SelectSingleNode("/weatherdata/forecast");
                Console.WriteLine("sunRise: "+ssunRise);
                Console.WriteLine("sunSet: " + ssunRise);

                DateTime sunRise = DateTime.Parse(ssunRise);
                DateTime sunSet = DateTime.Parse(ssunSet); ;
                //DateTime dt = null;
                int i = 0;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    //if(++i > 8) break;
                    string txt = node1.InnerText; //or loop through its children as well
                    string timeFrom = node1.Attributes["from"].InnerText;
                    PogodaData pd = new PogodaData();
                    timeFrom.Replace("T", " ");
                    pd.czas = DateTime.Parse(timeFrom);
                    foreach (XmlNode node2 in node1.ChildNodes) 
                    {
                        XmlNode nodeTemp =  node1.SelectSingleNode("temperature");

                        
                        string tempMin = nodeTemp.Attributes["min"].InnerText;
                        string tempMax = nodeTemp.Attributes["max"].InnerText;
                        try
                        {
                            double tmpMax = Double.Parse(tempMax, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                            pd.temp_max = tmpMax.ToString("##");
                            double tmpMin = Double.Parse(tempMin, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                            pd.temp_min = tmpMin.ToString("##");

                            if ("kelvin".CompareTo(nodeTemp.Attributes["unit"].InnerText) == 0)
                            {
                                pd.temp_min = (tmpMin - 273.15).ToString("#0.#");
                                pd.temp_max = (tmpMax - 273.15).ToString("#0.#");
                            }

                            pd.mainWeather = node1.SelectSingleNode("symbol").Attributes["name"].InnerText;
                            pd.img ="http://openweathermap.org/img/w/" + node1.SelectSingleNode("symbol").Attributes["var"].InnerText +".png";
                            pd.precipitation = node1.SelectSingleNode("precipitation").Attributes["value"].InnerText + "mm";
                            pd.description = node1.SelectSingleNode("precipitation").Attributes["type"].InnerText;
                            pd.pressure = node1.SelectSingleNode("pressure").Attributes["value"].InnerText + " hPa";
                            
                            pd.humidity = node1.SelectSingleNode("humidity").Attributes["value"].InnerText + "%";
                            pd.cloudCover = node1.SelectSingleNode("clouds").Attributes["all"].InnerText + "%";


                            //Console.WriteLine("tMax: " + tMax);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    
                    if(i == 8)
                        return;
                    i++;
                    lista.Add(pd);
                }
                i = 0;
            }
        }                    
    }
}
