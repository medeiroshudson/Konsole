using System;
using Konsole.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Konsole
{
    public class Application
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<Application> _logger;
        private readonly IHelloWorldService _helloWorld;
        public Application(IConfiguration configuration, ILogger<Application> logger, IHelloWorldService helloWorld)
        {
            _configuration = configuration;
            _logger = logger;
            _helloWorld = helloWorld;
        }

        public void Run()
        {
            _helloWorld.Greet(_configuration["Name"]);

            _logger.LogInformation("example =)");
        }
    }
}