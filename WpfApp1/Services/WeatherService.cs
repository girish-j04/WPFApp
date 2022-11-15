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
using System.IO;

namespace WpfApp1.Services
{
    public class WeatherService
    {
        readonly string API_KEY = "8512bcca9b008f3ba2fd20c8d7c52263";

        public WeatherData GetWeatherData(string city)
        {
            return GetWeatherDataByMock(city);
            
        }

        private WeatherData GetWeatherDataByAPI(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}&units=metric", API_KEY, city);
                var json = web.DownloadString(url);
                var output = JsonConvert.DeserializeObject<WeatherData>(json);
                return output;
            }
        }

        private WeatherData GetWeatherDataByMock(string city)
        {
            using (StreamReader r = new StreamReader($"../../Data/Weather/{city}.json"))
            {
                string json = r.ReadToEnd();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                return weatherData;
            }
        }

        public WeatherForecast GetWeatherForecast(string city)
        {
            return GetWeatherForecastByMock(city);
        }

        public WeatherForecast GetWeatherForecastByAPI(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?appid={0}&q={1}&units=metric&cnt=5", API_KEY, city);
                var json = web.DownloadString(url);
                var output = JsonConvert.DeserializeObject<WeatherForecast>(json);
                return output;
            }
        }

        public WeatherForecast GetWeatherForecastByMock(string city)
        {
            using (StreamReader r = new StreamReader($"../../Data/Forecast/{city}.json"))
            {
                string json = r.ReadToEnd();
                WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(json);
                return weatherForecast;
            }
        }

    }
}
