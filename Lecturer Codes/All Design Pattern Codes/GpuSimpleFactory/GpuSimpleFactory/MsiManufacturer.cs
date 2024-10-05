using System;
namespace GpuSimpleFactory
{
    public class MsiManufacturer : Company
    {
        public override Gpu CreateGpu()
        {
            return new MsiGpu();
        }
    }
}

