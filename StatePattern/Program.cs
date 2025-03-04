using StatePattern.Implementations;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We will look into State Design Pattern!");

            // Create a new context
            TrafficLightContext context = new TrafficLightContext(new RedLight());

            // Change the state of the context

            for (int i = 0; i < 5; i++)
            {
                context.DoChallan();
                context.Change();
            }

            Console.ReadLine();

        }
    }
}
