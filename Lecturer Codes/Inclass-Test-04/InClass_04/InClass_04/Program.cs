namespace InClass_04
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager manager = LibraryManager.GetInstance();

            manager.AddBook("1984 by George Orwell");
            manager.CreateUser("John Doe");
        }
    }
}