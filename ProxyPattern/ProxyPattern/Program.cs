internal class Program
{
    private static void Main(string[] args)
    {
        // Using the Proxy to interact with the RealObject
        IRealObject proxy = new Proxy();
        proxy.Request();
    }
// Subject interface
interface IRealObject
    {
        void Request();
    }

    // RealObject (the real object that the proxy represents)
    class RealObject : IRealObject
    {
        public void Request()
        {
            Console.WriteLine("RealObject: Handling request.");
        }
    }

    // Proxy class
    class Proxy : IRealObject
    {
        private RealObject realObject;

        public void Request()
        {
            // Lazy initialization: Instantiate the RealObject only when it is actually needed
            if (realObject == null)
            {
                Console.WriteLine("Proxy: Creating RealObject instance.");
                realObject = new RealObject();
            }

            // Additional logic before forwarding the request to the RealObject
            Console.WriteLine("Proxy: Logging request.");

            // Forward the request to the RealObject
            realObject.Request();

            // Additional logic after the RealObject has handled the request
            Console.WriteLine("Proxy: Request handled.");
        }
    }


    }


