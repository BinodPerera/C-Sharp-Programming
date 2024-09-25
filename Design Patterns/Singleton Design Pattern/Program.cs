
namespace Singleton_Design_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LibraryManager manager = LibraryManager.getInstance(); // creating object using instance 
            manager.AddBook();  // calling methods inside class
            manager.CreateUser();
        }
    }
}
