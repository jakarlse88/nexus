using System.Threading.Tasks;
using Nexus.Server.Models;

// ReSharper disable once CheckNamespace
namespace Nexus.Server.Services
{
    public interface IMessageService
    {
        Task<bool> SendMessage(ContactFormDto dto);
    }
}