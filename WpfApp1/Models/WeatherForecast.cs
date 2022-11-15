using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class WeatherForecast
    {
        public string cod { get; set; }
        public List<WeatherData> list { get; set; }
    }
}
