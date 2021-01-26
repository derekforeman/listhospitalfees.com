using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Services
{
    public class UserIpService : IUserIpService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserIpService(IHttpClientFactory httpClientfactory)
        {
            _httpClientFactory = httpClientfactory;
        }

        public async Task<IPAddress> GetUserIPAsync()
        {
            var client = _httpClientFactory.CreateClient("IP");
            return await client.GetFromJsonAsync<IPAddress>("/");
        }
    }
}
