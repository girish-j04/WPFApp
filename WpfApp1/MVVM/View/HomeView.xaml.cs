using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        readonly string API_KEY = "8512bcca9b008f3ba2fd20c8d7c52263";

        private void GetWeather(object sender, MouseButtonEventArgs e)
        {
            Border ele = (Border)sender;
            string city = ele.Name;

            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?appid={0}&q={1}&units=metric", API_KEY, city);
                var json = web.DownloadString(url);
                var output = JsonConvert.DeserializeObject<WeatherData>(json);

                Temperature.Text = $"Expected\n {output.main.temp}\u00B0C";
                return;

            }
        }
    }
}
