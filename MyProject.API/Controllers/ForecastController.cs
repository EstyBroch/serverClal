using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Services.Interfaces;
using MyProject.Services.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController : ControllerBase
    {
        private readonly IForecastService _forecastService;

        public ForecastController(IForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet("Get3DaysWeather/{location}")]
        public async Task<WeatherModel> Get3DaysWeather(string location)
        {
            var response = await _forecastService.GetWeatherAsync(location, 3);
            return response;
        }
        [HttpGet("GetWeatherMsgByLocation/{location}")]
        public async Task<string> GetWeatherMsgByLocation(string location)
        {
            var response = await _forecastService.GetWeatherAsync(location, null);
            return _forecastService.GetWeatherMsg(response, location);
        }
    }
}
