using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DogLog.API.Providers.TheDogAPI
{
    public class TheDogAPIClient : ITheDogAPIClient
    {
        private const string BaseUrl = "https://api.thedogapi.com/v1";
        private const string ApiKey = "c1adc797-933b-4ff0-a67f-2627b369cfdc";

        public async Task<IEnumerable<Breed>> GetAllBreeds()
        {
            var dogList = new List<Breed>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{BaseUrl}/breeds?api_key={ApiKey}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    dogList = JsonConvert.DeserializeObject<List<Breed>>(apiResponse);
                }
            }

            return dogList;
        }
    }
}
