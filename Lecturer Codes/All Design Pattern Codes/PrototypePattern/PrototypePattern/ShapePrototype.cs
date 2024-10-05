using System;
namespace PrototypePattern
{
	public interface ShapePrototype
	{
		ShapePrototype Clone();
		void Draw();
	}
}

