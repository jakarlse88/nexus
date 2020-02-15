using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Nexus.Server.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
    }
}