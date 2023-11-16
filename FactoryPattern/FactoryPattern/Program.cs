using FactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
            // Using the factory to create a Car
            IVehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateVehicle();
            car.Drive();

            // Using the factory to create a Motorcycle
            IVehicleFactory motorcycleFactory = new MotorcycleFactory();
            IVehicle motorcycle = motorcycleFactory.CreateVehicle();
            motorcycle.Drive();
        
    }
}