using System;
namespace AbstractFactory
{
	public abstract class Company
	{
		public Gpu AssmbleGpu()
		{
			Gpu gpu = CreateGpu();
			gpu.Assemble();
			return gpu;
		}

        public Monitor AssmbleMonitor()
        {
            Monitor monitor = CreateMonitor();
            monitor.Assemble();
            return monitor;
        }

        public abstract Gpu CreateGpu();
        public abstract Monitor CreateMonitor();
    }
}

