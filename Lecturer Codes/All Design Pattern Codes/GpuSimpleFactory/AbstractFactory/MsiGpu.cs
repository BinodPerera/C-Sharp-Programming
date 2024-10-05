using System;
namespace AbstractFactory
{
    public class MsiGpu : Gpu
    {
        public void Assemble()
        {
            Console.WriteLine("i'm a MSI Gpu");
        }
    }
}

