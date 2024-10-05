using System;
namespace ComponentFactory
{
    public class AsusManufacturer : Company
    {
        public override Component CreateComponent(string type)
        {
            if (type.Equals("Gpu"))
            {
                return new AsusGpu();
            }
            else
            {
                return new AsusMonitor();
            }
        }
    }
}

