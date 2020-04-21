using System;
using Konsole.Services;

namespace Konsole
{
    public class Application
    {
        private readonly IHelloWorldService _helloWorld;
        public Application(IHelloWorldService helloWorld)
        {
            _helloWorld = helloWorld;
        }

        public void Run()
        {
            _helloWorld.HelloWorld();
        }
    }
}