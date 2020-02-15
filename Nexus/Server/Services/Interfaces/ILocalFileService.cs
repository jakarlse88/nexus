// ReSharper disable once CheckNamespace

using System.IO;
using System.Threading.Tasks;

namespace Nexus.Server.Services
{
    public interface ILocalFileService
    {
        Task<FileStream> RetrieveLocalFileStream(string fileName);
    }
}