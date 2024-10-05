using System;
namespace AbstractFactory
{
    public class MsiManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }

        public override Monitor CreateMonitor()
        {
            return new MsiMonitor();
        }
    }
}

