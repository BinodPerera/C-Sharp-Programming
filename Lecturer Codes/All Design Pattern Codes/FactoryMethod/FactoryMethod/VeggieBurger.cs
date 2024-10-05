using System;
namespace FactoryMethod
{
    public class VeggieBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I'm prepearing Veggie Burger");
        }
    }
}

