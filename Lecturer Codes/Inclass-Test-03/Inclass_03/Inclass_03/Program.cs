namespace Inclass_03
{

  class Program
  {
    static void Main(string[] args)
    {
            IVehicleFactory gasolineCarManufacturer = new GasolineCarManufacturer();
            gasolineCarManufacturer.AssembleEngine();
            gasolineCarManufacturer.AssembleVehicle();

            IVehicleFactory electricCarManufacturer = new ElectricCatManufacturer();
            electricCarManufacturer.AssembleEngine();
            electricCarManufacturer.AssembleVehicle();
        }
  }
}

