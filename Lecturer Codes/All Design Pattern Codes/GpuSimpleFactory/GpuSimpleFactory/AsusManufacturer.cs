using System;
namespace GpuSimpleFactory
{
    public class AsusManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new AsusGpu();
        }
    }
}

