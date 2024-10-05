using System;
namespace SingletonPattern
{
	public class Singleton
	{
		private static Singleton instance = new Singleton();

		private Singleton()
		{
			Console.WriteLine("Singleton is Instantiated");
		}

		public static Singleton GetInstance()
		{
			return instance;
		}

		public void DisplayMsg()
		{
			Console.WriteLine("Hello World");
		}
	}
}

