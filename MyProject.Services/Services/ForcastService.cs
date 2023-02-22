using MyProject.Services.Interfaces;
using MyProject.Services.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ForcastService : IForecastService
    {
        private readonly HttpClient _httpClient;
        public ForcastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<WeatherModel> GetWeatherAsync(string location, int? days)
        {
            string uri = "https://api.weatherapi.com/v1/forecast.json?key=39f8ecaf506c4f76b3f55139222906&q=" + location;
            if (days != null)
            {
                uri = uri + "&days=" + days;
            }
            var responseString = await _httpClient.GetStringAsync(uri);
            var weatherResponse = JsonConvert.DeserializeObject<WeatherModel>(responseString);
            return weatherResponse;
        }

        public string GetWeatherMsg(WeatherModel weatherModel, string location)
        {
            return "the waether in " + location + " is: " + weatherModel.Current.temp_c +
                " condition " + weatherModel.Current.Condition.text;

        }
    }


}
