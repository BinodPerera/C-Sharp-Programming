using System;
namespace ComponentFactory
{
    public class MsiManufacturer : Company
    {
        public override Component CreateComponent(string type)
        {
            if (type.Equals("Gpu"))
            {
                return new MsiGpu();
            }else
            {
                return new MsiMonitor();
            }
            
        }
    }
}

