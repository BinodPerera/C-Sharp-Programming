using System;
namespace SimpleFactory
{
	public class Restaurant
	{
		public Burger OrderBurger(string type)
		{
			{
				SimpleBurgerFactory factory = new SimpleBurgerFactory();
				Burger burger = factory.CreateBurger(type);
				burger.Prepare();
				return burger;
			}
		}
	}
}

