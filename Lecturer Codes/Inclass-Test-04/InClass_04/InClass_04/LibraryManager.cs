using System;
namespace InClass_04
{
	public class LibraryManager
{
    private static LibraryManager instance;
    private static readonly object _lock = new object();

    private List<string> books = new List<string>();
    private List<string> users = new List<string>();

    private LibraryManager() 
    {
        // Private constructor to prevent instantiation
    }

    public static LibraryManager GetInstance()
    {
        lock (_lock)
        {
            if (instance == null)
            {
                instance = new LibraryManager();
            }
        }
        return instance;
    }

    public void AddBook(string book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book}' added.");
    }

    public void CreateUser(string user)
    {
        users.Add(user);
        Console.WriteLine($"User '{user}' created.");
    }

    
}

}

