using System;
namespace Inclass_03
{
    public class ElectricCatManufacturer : IVehicleFactory
    {
        IEngine IVehicleFactory.CreateEngine()
        {
            return new ElectricEngine();
        }

        IVehicle IVehicleFactory.CreateVehicle()
        {
            return new ElectricCar();
        }
    }
}

