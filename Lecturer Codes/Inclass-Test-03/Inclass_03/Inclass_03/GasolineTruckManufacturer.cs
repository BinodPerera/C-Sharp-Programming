using System;
namespace Inclass_03
{
    public class GasolineTruckManufacturer : IVehicleFactory
    {
       

        

        IEngine IVehicleFactory.CreateEngine()
        {
            return new GasolineEngine();
        }

        IVehicle IVehicleFactory.CreateVehicle()
        {
            return new GasolineTruck();
        }
    }
}

