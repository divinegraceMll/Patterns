internal class Program
{
    private static void Main(string[] args)
    {
        // Using the Facade to simplify interactions with the subsystem
        Facade facade = new Facade();

        // Client code interacts with the subsystem through the facade
        facade.OperationA();
        facade.OperationB();
    }

    // Subsystem 1
    class Subsystem1
    {
        public void Operation1()
        {
            Console.WriteLine("Subsystem1: Operation1");
        }

        public void Operation2()
        {
            Console.WriteLine("Subsystem1: Operation2");
        }
    }

    // Subsystem 2
    class Subsystem2
    {
        public void Operation3()
        {
            Console.WriteLine("Subsystem2: Operation3");
        }

        public void Operation4()
        {
            Console.WriteLine("Subsystem2: Operation4");
        }
    }

    // Facade
    class Facade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();
        }

        // Facade methods that simplify the interactions with the subsystem
        public void OperationA()
        {
            Console.WriteLine("Facade: OperationA");
            subsystem1.Operation1();
            subsystem2.Operation3();
        }

        public void OperationB()
        {
            Console.WriteLine("Facade: OperationB");
            subsystem1.Operation2();
            subsystem2.Operation4();
        }
    }

}