using System.Threading.Tasks;
using DogLog.API.Providers.Weather.Weatherbit;
using DogLog.API.Providers.Weather.Weatherbit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DogLog.API.Controllers
{
    [Route("api/Weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherbitClient _weatherbitClient;

        public WeatherController(ILogger<WeatherController> logger, IWeatherbitClient weatherbitClient)
        {
            _logger = logger;
            _weatherbitClient = weatherbitClient;
        }

        //16-day forecast
        [HttpGet]
        public async Task<DailyForecast> GetDailyForecast(double lat, double lon)
        {
            var sixteenDayForecast = await _weatherbitClient.GetDailyForecast(lat, lon);

            if (sixteenDayForecast == null) return new DailyForecast();

            return sixteenDayForecast;
        }
    }
}