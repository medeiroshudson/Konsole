using System;
using Konsole.Services;
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

            services.AddTransient<IHelloWorldService, HelloWorldService>();

            // Register application entry point
            services.AddTransient<Application>();

            return services;
        }
    }
}
