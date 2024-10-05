using System;
namespace FactoryMethod
{
	public class Program
	{
        public static void Main(string[] args)
		{
            BeefBurgerRestaurant beefBurgerRestaurant = new BeefBurgerRestaurant();
            beefBurgerRestaurant.OrderBurger();

            VeggieBurgerRestaurant veggieBurgerRestaurant = new VeggieBurgerRestaurant();
            veggieBurgerRestaurant.OrderBurger();

        }
    }
}

