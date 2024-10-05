using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace Prototype
{
	public class TwoWheelerVehicle:VehiclePrototype
	{

        public string fuel;
        public TwoWheelerVehicle(string engine, string model, string price, string color, string fuel)
            : base(engine, model, price, color)
        {
            this.fuel = fuel;
        }

        public override VehiclePrototype Clone()
        {
            return new TwoWheelerVehicle(this.engine, this.model, this.price, this.color, this.fuel);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"TwoWheeler: {engine} {model} {price} {color} {fuel}");
        }
    }
}

