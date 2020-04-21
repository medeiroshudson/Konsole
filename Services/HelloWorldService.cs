using System;

namespace Konsole.Services
{
    public interface IHelloWorldService
    {
        void HelloWorld();
    }
    public class HelloWorldService : IHelloWorldService
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}