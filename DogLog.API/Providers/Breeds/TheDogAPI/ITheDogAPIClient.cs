using System.Collections.Generic;
using System.Threading.Tasks;

namespace DogLog.API.Providers.TheDogAPI
{
    public interface ITheDogAPIClient
    {
        Task<IEnumerable<Breed>> GetAllBreeds();
    }
}
