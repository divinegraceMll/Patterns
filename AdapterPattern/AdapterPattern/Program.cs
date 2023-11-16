internal class Program
{
    private static void Main(string[] args)
    {
        // The existing class (Adaptee)
        Adaptee adaptee = new Adaptee();

        // The client uses the Adapter to make a request to the Target interface
        ITarget adapter = new Adapter(adaptee);
        Client client = new Client();
        client.MakeRequest(adapter);
    }


    // Target interface (the interface we want to use)
    interface ITarget
    {
        void Request();
    }

    // Adaptee (an existing class with a different interface)
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee: SpecificRequest");
        }
    }

    // Adapter class (adapts Adaptee to ITarget)
    class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    class Client
    {
        public void MakeRequest(ITarget target)
        {
            target.Request();
        }
    }
}