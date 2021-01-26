using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Core.Services;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress;
            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(baseAddress) });

            builder.Services.AddHttpClient("IP", (options) => {
                options.BaseAddress = new Uri("https://jsonip.com");
            });
            builder.Services.AddHttpClient("IpStack", options => {
                options.BaseAddress = new Uri("http://api.ipstack.com");
            });

            builder.Services.AddTransient<IUserIpService, UserIpService>();
            builder.Services.AddTransient<IIpStackService, IpStackService>();
            await builder.Build().RunAsync();
        }
    }
}