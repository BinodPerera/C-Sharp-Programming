using System;
namespace BuilderPattern2
{
	public class GasolineCarBuilder:CarBuilder
	{
        Car car;
        public GasolineCarBuilder()
        {
            car = new Car();
        }
        public void BuildBrand()
        {
            car.setBrand("Lambo");
        }

        public void BuildColor()
        {
            car.setColor("Blue");
        }

        public void BuildId()
        {
            car.setId(123);
        }

        public void BuildModel()
        {
            car.setModel("Aventador");
        }

        public Car Build()
        {
            return car;
        }
    }
}

