using System;
namespace Prototype
{ 

	public abstract class VehiclePrototype
	{
	    public string engine;
        public string model;
        public string price;
        public string color;

        public VehiclePrototype(string engine,string model,string price,string color)
		{
			this.engine = engine;
			this.model = model;
			this.price = price;
			this.color = color;
		}

        public abstract VehiclePrototype Clone();
		public abstract void DisplayDetails();
	}
}

