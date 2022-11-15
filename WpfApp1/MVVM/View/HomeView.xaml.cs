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
using WpfApp1.Services;

namespace WpfApp1.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        WeatherService weatherService;
        public HomeView()
        {
            InitializeComponent();
            weatherService = new WeatherService();
        }

        private void GetWeather(object sender, MouseButtonEventArgs e)
        {
            Border ele = (Border)sender;
            string city = ele.Name;

            WeatherData weatherData = weatherService.GetWeatherData(city);
            Temperature.Text = $"Expected\n {weatherData.main.temp}\u00B0C";
            return;
        }

        private void SearchWeather(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                TextBox ele = (TextBox)sender;
                string city = ele.Text;

                WeatherData weatherData = weatherService.GetWeatherData(city);
                Temperature.Text = $"Expected\n {weatherData.main.temp}\u00B0C";
                return;
            }
        }
    }
}
