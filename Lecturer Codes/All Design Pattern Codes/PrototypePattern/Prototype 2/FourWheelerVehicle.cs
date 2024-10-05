using System;
namespace Prototype
{
	public class FourWheelerVehicle:VehiclePrototype
	{
      


        public string transmission;
        public FourWheelerVehicle(string engine, string model, string price, string color, string transmission)
            : base(engine, model, price, color)
        {
            this.transmission = transmission;
        }

        public override VehiclePrototype Clone()
        {
            return new FourWheelerVehicle(this.engine, this.model, this.price, this.color, this.transmission);
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"TwoWheeler: {engine} {model} {price} {color} {transmission}");
        }
    }
}

