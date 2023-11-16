internal class Program
{
    // Client code
    private static void Main(string[] args)
    {
        // Create prototypes
        ICloneableVehicle carPrototype = new Car { Model = "Sedan" };
        ICloneableVehicle motorcyclePrototype = new Motorcycle { Model = "Sport" };

        // Clone objects
        ICloneableVehicle clonedCar = carPrototype.Clone();
        ICloneableVehicle clonedMotorcycle = motorcyclePrototype.Clone();

        // Use cloned objects
        clonedCar.Drive();
        clonedMotorcycle.Drive();
    }

    // Prototype interface
    interface ICloneableVehicle
    {
        ICloneableVehicle Clone();
        void Drive();
    }

    // Concrete Prototype 1
    class Car : ICloneableVehicle
    {
        public string Model { get; set; }

        public ICloneableVehicle Clone()
        {
            return new Car { Model = this.Model };
        }

        public void Drive()
        {
            Console.WriteLine($"Car {Model} is driving.");
        }
    }

    // Concrete Prototype 2
    class Motorcycle : ICloneableVehicle
    {
        public string Model { get; set; }

        public ICloneableVehicle Clone()
        {
            return new Motorcycle { Model = this.Model };
        }

        public void Drive()
        {
            Console.WriteLine($"Motorcycle {Model} is driving.");
        }
    }
}

