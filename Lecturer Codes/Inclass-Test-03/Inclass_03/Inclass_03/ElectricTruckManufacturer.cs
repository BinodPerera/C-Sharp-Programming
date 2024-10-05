using System;
namespace Inclass_03
{
    public class ElectricTruckManufacturer : IVehicleFactory
    {
        IEngine IVehicleFactory.CreateEngine()
        {
            return new ElectricEngine();
        }

        IVehicle IVehicleFactory.CreateVehicle()
        {
            return new ElectricTruck();
        }
    }
}

