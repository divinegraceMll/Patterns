internal class Program
{
    private static void Main(string[] args)
    {
        // Access the singleton instance
        Singleton singletonInstance1 = Singleton.Instance;
        Singleton singletonInstance2 = Singleton.Instance;

        // Both instances should be the same
        Console.WriteLine($"Are instances equal? {singletonInstance1 == singletonInstance2}");

        // Call a method on the singleton instance
        singletonInstance1.SomeMethod();
    }


    // Singleton class
    public sealed class Singleton
    {
        // Private static instance of the class
        private static Singleton instance;

        // Private constructor to prevent instantiation from outside the class
        private Singleton()
        {
            Console.WriteLine("Singleton instance created.");
        }

        // Public method to access the singleton instance
        public static Singleton Instance
        {
            get
            {
                // If the instance is not created, create it
                if (instance == null)
                {
                    instance = new Singleton();
                }

                // Return the instance
                return instance;
            }
        }

        // Other methods of the singleton class
        public void SomeMethod()
        {
            Console.WriteLine("Singleton method called.");
        }
    }
}