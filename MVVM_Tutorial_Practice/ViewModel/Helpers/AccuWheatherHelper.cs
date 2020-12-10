using MVVM_Tutorial_Practice.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Tutorial_Practice.ViewModel.Helpers
{
    public class AccuWheatherHelper
    {
        public const string Base_Url = "http://dataservice.accuweather.com/";
        public const string AutoComplete_EndPoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string Current_Conditions_EndPoint = "currentconditions/v1/{0}?apikey={1}";
        public const string APIKey = "UMX7TdPKK6p5ehvTzLZJiqDuSYR4J1Bd";
        
        public static async Task<List<City>> GetCities(string query)
        {
            List<City> cities = new List<City>();
            string url = Base_Url +string.Format(AutoComplete_EndPoint,APIKey,query);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return cities;
        }

        public static async Task<Wheather> GetWheather(string cityKey)
        {
            Wheather wheather = new Wheather();
            string url = Base_Url + string.Format(Current_Conditions_EndPoint, cityKey, APIKey);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();
                wheather = (JsonConvert.DeserializeObject<List<Wheather>>(json)).FirstOrDefault();
            }
            return wheather;
        }

    }
}
