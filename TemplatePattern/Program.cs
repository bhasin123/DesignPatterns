using TemplatePattern.Implementations;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, we are implementing Template Pattern!");

            Console.WriteLine("Cooking Biryani...");
            var biryani = new Biryani();
            biryani.Cook();
            Console.WriteLine("Ending Biryani");

            Console.WriteLine("Cooking Oats...");
            var oats = new Oats();
            oats.Cook();
            Console.WriteLine("Ending Oats");

            Console.WriteLine("Cooking Rajma Chawal...");
            var rajmaChawal = new RajmaChawal();
            rajmaChawal.Cook();
            Console.WriteLine("Ending Rajma Chawal");
        }
    }
}
