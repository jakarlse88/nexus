using System.Threading.Tasks;
using Nexus.Server.Model;
using Nexus.Server.Repositories;

namespace Nexus.Server.Services
{
    public class PersonalDetailsService : IPersonalDetailsService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public PersonalDetailsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<PersonalDetails> GetByIdAsync(int id)
        {
            var result =
                await _repositoryWrapper
                    .PersonalDetails
                    .GetByIdAsync(id);

            return result;
        }
    }
}