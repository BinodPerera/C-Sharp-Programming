using System;
namespace FactoryMethod
{
    public class BeefBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I'm Prepearing a BeefBurger");
        }
    }
}

