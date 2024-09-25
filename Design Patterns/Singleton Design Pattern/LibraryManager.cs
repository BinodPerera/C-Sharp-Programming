using System;
namespace Singleton_Design_Pattern
{
	public class LibraryManager
	{
		public static LibraryManager instance;	// creating instance variable

		private LibraryManager()	// This is constructor when creating an object for this class this body will auto run
		{
			Console.WriteLine("instance created!");	// This will print after creating an object from this class
		}

		public static LibraryManager getInstance()	// This getInstance() method is use for creating object for this class 
		{
			if(instance == null)	// checking this instance variable is null or not
			{
				//	If this instance variable is null it will assign new value to this instance variable
				instance = new LibraryManager();
			}
			return instance;	// returning instance variable value
		}

		public void CreateUser()	// method for creating user account
		{
			Console.WriteLine("User Account Created!");
		}

		public void AddBook()	// method for add book into library	
		{
			Console.WriteLine("Book added!");
		}
	}

}

