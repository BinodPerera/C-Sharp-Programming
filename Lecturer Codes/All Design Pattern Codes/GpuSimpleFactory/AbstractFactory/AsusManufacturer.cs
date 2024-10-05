using System;
namespace AbstractFactory
{
    public class AsusManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }

        public override Monitor CreateMonitor()
        {
            return new AsusMonitor();
        }
    }
}

