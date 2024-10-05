using System;

namespace FactoryMethod
{
    public class BeefBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new BeefBurger();
        }
    }
}

