using System;
using System.Drawing;
using System.Reflection;

namespace BuilderPattern2
{
	public interface CarBuilder
	{
		void BuildId();
		void BuildBrand();
		void BuildModel();
		void BuildColor();
		public Car Build();
        
    }
}

