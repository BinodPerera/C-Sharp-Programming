using System;
namespace PrototypePattern
{
	public class Circle:ShapePrototype

	{
        private string color;
		public Circle(string color)
		{
            this.color = color;
		}

        public ShapePrototype Clone()
        {
            return new Circle(this.color);
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a " + color + " circle.");
        }
    }
}

