using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogLog.API.Providers.TheDogAPI
{
    public interface ITheDogAPIClient
    {
        Task<IEnumerable<Breed>> GetAllDogs();
    }
}
