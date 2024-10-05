using System;
namespace ComponentFactory
{
	public abstract class Company
	{
		public Component AssmbleComponent(string type)

		{
			Component component = CreateComponent(type);
			component.Assemble();
			return component;

		}

		public abstract Component CreateComponent(string type);
	}
}

