using System;
namespace BuilderPattern2
{
    public class ElectricCarBuilder : CarBuilder
    {

        Car car;
        public ElectricCarBuilder()
        {
            car = new Car();
        }
        public void BuildBrand()
        {
            car.setBrand("Tesla");
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
            car.setModel("Model X");
        }

        public Car Build()
        {
            return car;
        }

    }
}

