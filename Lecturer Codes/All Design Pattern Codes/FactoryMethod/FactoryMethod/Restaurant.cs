using System;
namespace FactoryMethod
{
	public abstract class Restaurant
	{
		public Burger OrderBurger()
		{
			{
				Burger burger = CreateBurger();
				burger.Prepare();
				return burger;
			}
		}

		public abstract Burger CreateBurger();

	}
}

