
using DogLog.API.Providers.Weather.Weatherbit.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogLog.API.Providers.Weather.Weatherbit
{
    public class WeatherbitClient : IWeatherbitClient
    {
        private readonly string BaseUrl = "https://api.weatherbit.io/v2.0";
        private readonly string ApiKey = "bfdca3dd839646a089bb8b8f867a2f26";

        //16-day forecast
        public async Task<DailyForecast> GetDailyForecast(double lat, double lon)
        {
            var dailyForecast = new DailyForecast();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{BaseUrl}/forecast/daily?{lat}&{lon}&key={ApiKey}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dailyForecast = JsonConvert.DeserializeObject<DailyForecast>(apiResponse);
                }
            }

            return dailyForecast;
        }
    }
}
