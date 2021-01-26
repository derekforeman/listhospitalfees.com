using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Services
{
    public class IpStackService : IIpStackService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IpStackService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<UserGeoLocation> GetLocationAsync(string userIp)
        {
            string path = $"{userIp}?access_key=Key";
            var client = _httpClientFactory.CreateClient("IpStack");
            return await client.GetFromJsonAsync<UserGeoLocation>(path);
        }
    }
}
