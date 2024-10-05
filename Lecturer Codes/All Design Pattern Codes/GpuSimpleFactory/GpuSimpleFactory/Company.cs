using System;
namespace GpuSimpleFactory
{
	public abstract class Company
	{
		public Gpu assmbleGpu()

		{
			Gpu gpu = CreateGpu();
			gpu.Assemble();
			return gpu;

		}

		public abstract Gpu CreateGpu();
	}
}

