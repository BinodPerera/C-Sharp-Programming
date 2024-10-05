using System;
namespace BuilderPattern
{
    public class Car
    {
        private int id { get; set; }
        private string brand { get; set; }
        private string model { get; set; }
        private string color { get; set; }

        Car(CarBuilder carBuilder)
        {
            id=carBuilder.id;
            brand = carBuilder.brand;
            model = carBuilder.model;
            color = carBuilder.color;
        }

        public void Display()
        {
            Console.WriteLine($"{id} {brand} {model} {color}");
        }

        public class CarBuilder
        {
            public int id { get; set; }
            public string brand { get; set; }
            public string model { get; set; }
            public string color { get; set; }


            public CarBuilder Id(int id)
            {
                this.id = id;
                return this;
            }

            public CarBuilder Brand(string brand)
            {
                this.brand = brand;
                return this;
            }
            public CarBuilder Model(string model)
            {
                this.model = model;
                return this;
            }
            public CarBuilder Color(string color)
            {
                this.color = color;
                return this;
            }

            public Car Build()
            {
                return new Car(this);
            }

        }
    }
}

