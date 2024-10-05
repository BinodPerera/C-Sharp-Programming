using System;
namespace LazySingletonPattern
{
	public class Singleton
	{
		private static Singleton instance;

		private Singleton()
		{
			Console.WriteLine("Singleton is Instantiated");
		}

		public static Singleton GetInstance()
		{
			
			instance = new Singleton();
			
			return instance;
		}

		public void DisplayMsg()
		{
			Console.WriteLine("Hello World");
		}
	}
}

