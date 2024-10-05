using System;
namespace AbstractFactory
{
    public class MsiMonitor : Monitor
    {
        public void Assemble()
        {
            Console.WriteLine("I'm a Msi Monitor");
        }
    }
}

