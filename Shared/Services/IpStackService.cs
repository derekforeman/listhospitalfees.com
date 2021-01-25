using System;
using System.Net.Http;
using System.Threading.Tasks;
using ListHospitalFees.Shared.Models;

namespace ListHospitalFees.Shared.Services
{
    public class IpStackService
    {
        private readonly HttpClient _httpClientFactory;

        public IpStackService(HttpClient _httpClientFactory)
        {
            _httpClientFactory = _httpClientFactory;
        }
        public async Task<UserGeoLocation> GetLocationAsync(string userIp)
        {
            string path = $"{userIp}?access_key=Your_Secured_Key";
            var client = _httpClientFactory.CreateClient("IpStack");
            return await client.GetFromJsonAsync<UserGeoLocation>(path);
        }
    }
}
