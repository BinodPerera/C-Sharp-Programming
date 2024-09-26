using System;
namespace Singleton_Design_Pattern
{
	public class LibraryManager
	{
		public static LibraryManager instance;  // creating instance variable
		private static readonly object _lock = new object();	

		private List<string> books = new List<string>();
        private List<string> users = new List<string>();

        private LibraryManager()	// This is constructor when creating an object for this class this body will auto run
		{
			Console.WriteLine("instance created!");	// This will print after creating an object from this class
		}

		public static LibraryManager getInstance()	// This getInstance() method is use for creating object for this class 
		{
			lock(_lock)
			{
                if (instance == null)   // checking this instance variable is null or not
                {
                    //	If this instance variable is null it will assign new value to this instance variable
                    instance = new LibraryManager();
                }
            }
			
			return instance;	// returning instance variable value
		}

		public void CreateUser(string user)	// method for creating user account
		{
			users.Add(user);
			Console.WriteLine("User Account Created!");
		}

		public void AddBook(string book)	// method for add book into library	
		{
			books.Add(book);
			Console.WriteLine("Book added!");
		}
	}

}

