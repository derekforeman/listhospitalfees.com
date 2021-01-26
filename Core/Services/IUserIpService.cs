using System;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Services
{
    public interface IUserIpService
    {
        Task<IPAddress> GetUserIPAsync();
    }
}
