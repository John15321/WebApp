using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
//using Newtonsoft.Json;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


namespace WeatherApp
{
    public class Cord
    {
        public float lon;
        public float lat;
    }
    public class Weather
    {
        public int id;
    }
    public class Maine
    {
        public float temp;
        public float feels_like;
    }
    public class DownloadWeather
    {
        public string timezone { get; set; }
        public string name { get; set; }
        public Cord coord { get; set; }
        public Weather[] weather { get; set; }
        // public string main { get; set; }
        // public string feels_like { get; set; }
        // public DataSet weather { get; set; }

        public Maine main { get; set; }

        public string getWeather(string City)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=b0789adf874bd65919c23b49a964d714&units=metric");
                var json = web.DownloadString(url);
                return json;
            }
        }
    }
}