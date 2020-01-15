using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogLog.API.Providers.TheDogAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DogLog.API.Controllers
{
    [Route("api/Dog")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly ILogger<DogController> _logger;
        private readonly ITheDogAPIClient _dogApiClient;

        public DogController(ILogger<DogController> logger, ITheDogAPIClient dogApiClient)
        {
            _logger = logger;
            _dogApiClient = dogApiClient;
        }

        [HttpGet]
        public async Task<IEnumerable<Breed>> GetAllBreeds()
        {
            var dogList = await _dogApiClient.GetAllBreeds();

            if (dogList == null) return new List<Breed>();

            return dogList.OrderByDescending(p => p.Name);
        }
    }
}