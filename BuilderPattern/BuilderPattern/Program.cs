internal class Program
{
    private static void Main(string[] args)
    {

        // Client code using the Builder Pattern
        IBuilder builder = new ConcreteBuilder();
        Director director = new Director();

        // Construct the product using the director and the builder
        director.Construct(builder);
        Product product = builder.GetResult();

        // Display the constructed product
        product.ShowInfo();
    }


    // Product class (the complex object being constructed)
    class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Part1: {Part1}");
            Console.WriteLine($"Part2: {Part2}");
            Console.WriteLine($"Part3: {Part3}");
        }
    }

    // Builder interface
    interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetResult();
    }

    // Concrete Builder
    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void BuildPart1()
        {
            product.Part1 = "Builder Part 1";
        }

        public void BuildPart2()
        {
            product.Part2 = "Builder Part 2";
        }

        public void BuildPart3()
        {
            product.Part3 = "Builder Part 3";
        }

        public Product GetResult()
        {
            return product;
        }
    }

    // Director class
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }
    }
}