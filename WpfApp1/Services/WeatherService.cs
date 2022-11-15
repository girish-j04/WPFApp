using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using System.Diagnostics;

namespace WpfApp1.Services
{
    public class WeatherService
    {
        readonly string API_KEY = "8512bcca9b008f3ba2fd20c8d7c52263";

        public WeatherData GetWeatherData(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}&units=metric", API_KEY, city);
                var json = web.DownloadString(url);
                var output = JsonConvert.DeserializeObject<WeatherData>(json);
                return output;
            }
        }

        public WeatherForecast GetWeatherForecast(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?appid={0}&q={1}&units=metric&cnt=5", API_KEY, city);
                var json = web.DownloadString(url);
                var output = JsonConvert.DeserializeObject<WeatherForecast>(json);
                return output;
            }
        }
        
    }
}
