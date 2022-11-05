using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;

namespace WpfApp1.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand FeaturedViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            FeaturedVM = new FeaturedViewModel();
            CurrentView = HomeVM;


            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            }, o => true);

            FeaturedViewCommand = new RelayCommand(o =>
            {
                CurrentView = FeaturedVM;
            }, o => true);
        }
    }
}