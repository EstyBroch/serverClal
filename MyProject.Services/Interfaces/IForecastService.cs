using MyProject.Services.Model;
using MyProject.Services.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IForecastService
    {
        Task<WeatherModel> GetWeatherAsync(string location,int? days);
        string GetWeatherMsg(WeatherModel weatherModel, string location);
    }
}
