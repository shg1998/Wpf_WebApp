using MVVM_Tutorial_Practice.Model;
using MVVM_Tutorial_Practice.ViewModel.Commands;
using MVVM_Tutorial_Practice.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MVVM_Tutorial_Practice.ViewModel
{
    public class WheatherViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string query;

        public string Query
        {
            get { return query; }
            set 
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }

        private Wheather _wheather;

        public Wheather wheather
        {
            get { return _wheather; }
            set 
            {
                _wheather = value;
                OnPropertyChanged("wheather");
            }
        }

        public ObservableCollection<City> cities { get; set; }


        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set 
            {
                selectedCity = value;
                OnPropertyChanged("SelectedCity");
                GetCurrentconditions();
            }
        }

        public SearchCommand searchCommand { get; set; }


        public WheatherViewModel()
        {
            // very imp!
            if(DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                this.SelectedCity = new City()
                {
                    LocalizedName = "New York"
                };
                this.wheather = new Wheather()
                {
                    WeatherText = "Partly Cloudy",
                    Temperature = new Temperature()
                    {
                        Metric = new Units()
                        {
                            Value = "25"
                        }
                    }
                };
            }

            searchCommand = new SearchCommand(this);
            cities = new ObservableCollection<City>();
        }

        private async void GetCurrentconditions()
        {
            Query = string.Empty;
            cities.Clear();
            var currentCon = await AccuWheatherHelper.GetWheather(SelectedCity.Key);
            this.wheather = currentCon;
        }


        public async void makeQuery()
        {
            var citiess = await AccuWheatherHelper.GetCities(Query);

            cities.Clear();
            foreach (var item in citiess)
            {
                cities.Add(item);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
