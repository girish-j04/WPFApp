using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for FeaturedView.xaml
    /// </summary>
    public partial class FeaturedView : UserControl
    {
        WeatherService weatherService;
        public FeaturedView()
        {
            InitializeComponent();
            weatherService = new WeatherService();
        }

        public void GetWeatherForecast(object sender, RoutedEventArgs e)
        {
            WeatherForecast weatherForecast = weatherService.GetWeatherForecast("Siliguri");
        }
    }
}
