using System;
using Konsole.Services;
using Microsoft.Extensions.Configuration;

namespace Konsole
{
    public class Application
    {
        private readonly IConfiguration _configuration;
        private readonly IHelloWorldService _helloWorld;
        public Application(IConfiguration configuration, IHelloWorldService helloWorld)
        {
            _configuration = configuration;
            _helloWorld = helloWorld;
        }

        public void Run()
        {
            _helloWorld.Greet(_configuration["Name"]);
        }
    }
}