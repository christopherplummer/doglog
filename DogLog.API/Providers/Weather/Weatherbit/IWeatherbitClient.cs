using DogLog.API.Providers.Weather.Weatherbit.Models;
using System.Threading.Tasks;

namespace DogLog.API.Providers.Weather.Weatherbit
{
    public interface IWeatherbitClient
    {
        //16-day forecast
        public Task<DailyForecast> GetDailyForecast(double lat, double lon);
    }
}
