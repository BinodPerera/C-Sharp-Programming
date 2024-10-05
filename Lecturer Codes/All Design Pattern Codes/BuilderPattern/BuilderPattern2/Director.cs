using System;
namespace BuilderPattern2
{
    public class Director

    {
        CarBuilder carBuilder;
        public Director(CarBuilder carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public Car Construct()
        {
            carBuilder.BuildBrand();
            carBuilder.BuildColor();
            carBuilder.BuildId();
            carBuilder.BuildModel();

            return carBuilder.Build();

        }
    }
}

