using System;
namespace BuilderPattern2
{
	public class Car
	{
        private int id;
        private string? brand;
        private string? model;
        private string? color;


        public void setId(int id)
        {
            this.id = id;
          
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
           
        }
        public void setModel(string model)
        {
            this.model = model;
          
        }
        public void setColor(string color)
        {
            this.color = color;
          
        }
        public void Display()
        {
            Console.WriteLine(id + " " + brand + " " + model + " " + color);
        }


    }
}

