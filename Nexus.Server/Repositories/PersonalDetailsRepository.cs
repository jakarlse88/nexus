using Nexus.Server.Model;

namespace Nexus.Server.Repositories
{
    /// <summary>
    /// Type wrapper that exposes repository functionality for the
    /// PersonalDetails entity.
    /// </summary>
    public class PersonalDetailsRepository : RepositoryBase<PersonalDetails>, IPersonalDetailsRepository
    {
        public PersonalDetailsRepository(NexusContext context) : base(context)
        {
        }
    }
}