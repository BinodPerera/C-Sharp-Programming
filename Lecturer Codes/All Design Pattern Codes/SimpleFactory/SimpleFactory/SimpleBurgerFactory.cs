using System;
namespace SimpleFactory
{
	public class SimpleBurgerFactory

	{
        public Burger CreateBurger(string type)
		{
			Burger burger = null;
			if (type == "Beef")
			{
				burger = new BeefBurger();
			}else if (type == "Veggie")
			{
				burger = new VeggieBurger();
			}

			return burger;
		}
	}
}

