using System.IO;
using Konsole.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection and configure our services
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Run Application
            serviceProvider.GetService<Application>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            // load appsettings.json
            var config = LoadConfiguration();

            services.AddSingleton(config);

            // loading service
            services.AddTransient<IHelloWorldService, HelloWorldService>();

            // Register application entry point
            services.AddTransient<Application>();

            return services;
        }

        public static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
