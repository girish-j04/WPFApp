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
    /// Interaction logic for WeekView.xaml
    /// </summary>
    public partial class WeekView : UserControl
    {
        WeatherService weatherService;
        public WeekView()
        {
            InitializeComponent();
            weatherService = new WeatherService();
        }

        private void GetForecast(object sender, RoutedEventArgs e)
        {
            WeatherForecast weatherForecast = weatherService.GetWeatherForecast("Hyderabad");

            temp1.Text = weatherForecast.list[0].main.temp.ToString();
            temp2.Text = weatherForecast.list[1].main.temp.ToString();
            temp3.Text = weatherForecast.list[2].main.temp.ToString();
            temp4.Text = weatherForecast.list[3].main.temp.ToString();
            temp5.Text = weatherForecast.list[4].main.temp.ToString();

            time1.Text = weatherForecast.list[0].dt_txt.Substring(11, 2);
            time2.Text = weatherForecast.list[1].dt_txt.Substring(11, 2);
            time3.Text = weatherForecast.list[2].dt_txt.Substring(11, 2);
            time4.Text = weatherForecast.list[3].dt_txt.Substring(11, 2);
            time5.Text = weatherForecast.list[4].dt_txt.Substring(11, 2);

        }
    }
}
