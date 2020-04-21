using System;

namespace Konsole.Services
{
    public interface IHelloWorldService
    {
        void Greet(string name);
    }
    public class HelloWorldService : IHelloWorldService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hey, {name}!");
        }
    }
}