using IteratorPattern.IteratorAggregators;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are Implementing Iterator Pattern!");

            IMenu numberItems = new CNumberItems();
            IMenu menuItems = new CMenuItems();

            Console.WriteLine("Number Items:");
            IterateCollection(numberItems);

            Console.WriteLine("Menu Items:");
            IterateCollection(menuItems);

            Console.ReadLine();


        }

        private static void IterateCollection(IMenu items)
        {
            foreach (var item in (IEnumerable<string>)items ?? Enumerable.Empty<string>())
            {
                Console.WriteLine(item);
            }   
        }
    }
}
