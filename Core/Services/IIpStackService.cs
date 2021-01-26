using System;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Services
{
    public interface IIpStackService
    {
        Task<UserGeoLocation> GetLocationAsync(string userIp);
    }
}
