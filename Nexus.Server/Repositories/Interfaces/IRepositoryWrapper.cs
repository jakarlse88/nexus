using Nexus.Server.Model;

// ReSharper disable once CheckNamespace
namespace Nexus.Server.Repositories
{
    public interface IRepositoryWrapper
    {
        IPersonalDetailsRepository PersonalDetails { get; }
    }
}