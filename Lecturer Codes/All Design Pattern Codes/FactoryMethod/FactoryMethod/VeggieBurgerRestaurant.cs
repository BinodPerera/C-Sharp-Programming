using System;
namespace FactoryMethod
{
    public class VeggieBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}

