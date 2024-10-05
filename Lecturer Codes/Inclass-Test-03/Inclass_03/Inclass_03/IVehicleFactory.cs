using System;
namespace Inclass_03
{
    interface IVehicleFactory
    {

        public IVehicle AssembleVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.ShowDetails();
            return vehicle;
        }

        public IEngine AssembleEngine()
        {
            IEngine engine = CreateEngine();
            engine.Start();
            return engine;
        }
        public IVehicle CreateVehicle();
        public IEngine CreateEngine();
    }

}

