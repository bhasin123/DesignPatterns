using AdaptorPattern.Adapters;
using AdaptorPattern.Implementations;

namespace AdaptorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are implementing adapter Pattern!");

            Console.WriteLine("Mallard duck In Action!");
            IDuck duck = new MallardDuck();
            duck.Quack();
            duck.Fly();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Pond duck In Action!");
            duck = new PondDuck();
            duck.Quack();
            duck.Fly();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Ostrich In Action!");
            duck = new OstrichAdapter(new Ostrich());
            duck.Quack();
            duck.Fly();
            Console.WriteLine("----------------------------");

        }
    }
}
