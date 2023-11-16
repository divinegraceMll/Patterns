internal class Program
{
    private static void Main(string[] args)
    {

        // Client code using the Decorator Pattern
        IComponent component = new ConcreteComponent();
        Console.WriteLine("Client: Basic component:");
        component.Operation();

        // Decorate the component with ConcreteDecoratorA
        IComponent decoratedComponentA = new ConcreteDecoratorA(component);
        Console.WriteLine("\nClient: Decorated component with ConcreteDecoratorA:");
        decoratedComponentA.Operation();

        // Decorate the component with ConcreteDecoratorB
        IComponent decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);
        Console.WriteLine("\nClient: Decorated component with ConcreteDecoratorB:");
        decoratedComponentB.Operation();
    }


    // Component interface
    interface IComponent
    {
        void Operation();
    }

    // Concrete component
    class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent: Performing operation.");
        }
    }

    // Base decorator class
    abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // Concrete decorator 1
    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA: Added behavior.");
        }
    }

    // Concrete decorator 2
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB: Added different behavior.");
        }
    }
}