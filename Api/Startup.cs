using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(BlazorApp.Api.Startup))]
namespace BlazorApp.Api
{
    public class Startup : FunctionsStartup
    {

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient("IP", (options) => {
                options.BaseAddress = new Uri("https://jsonip.com");
            });

            builder.Services.AddHttpClient("IpStack", options => {
                options.BaseAddress = new Uri("http://api.ipstack.com");
            });

            // Registering Serilog provider
            //var logger = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            //    .CreateLogger();
            //builder.Services.AddLogging(lb => lb.AddSerilog(logger));
            //builder.Services.AddHttpClient();
            //builder.Services.AddSingleton<IRepository, Repository>();
            //builder.Services.AddDbContext<BooksContext>(config =>
            //{
            //    config.UseSqlServer(Environment.GetEnvironmentVariable("BooksConnection"));
            //});
            //builder.Services.AddLogging();
            //// Startup.cs - Registering a third party logging provider
            //var logger = new LoggerConfiguration()
            //                .WriteTo.Console()
            //                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            //                .CreateLogger();
            //builder.Services.AddLogging(lb => lb.AddSerilog(logger));
        }
    }
}
