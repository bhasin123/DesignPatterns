using StrategyPattern.SearchAlgorithms;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var searchArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var notoFind = 5;

            var foundAt = -1;

            Console.WriteLine("Implementing Different Search Strategies using Strategy Pattern!");

            Console.WriteLine("Using Linear Search Strategy");
            var searchEngine = new SearchEngineContext(new LinearSearch());
            foundAt = searchEngine.Search(searchArray, notoFind);
            Console.WriteLine(foundAt == -1 ? "Not Found" : $"Found at Index: {foundAt}");

            foundAt = -1;

            Console.WriteLine("Using Binary Search Strategy");
            searchEngine.SetStrategy(new IterativeBinarySearch());
            foundAt = searchEngine.Search(searchArray, notoFind);
            Console.WriteLine(foundAt == -1 ? "Not Found" : $"Found at Index: {foundAt}");

            foundAt = -1;

            Console.WriteLine("Using Recursive Binary Strategy");
            searchEngine.SetStrategy(new RecursiveBinarySearch());
            foundAt = searchEngine.Search(searchArray, notoFind);
            Console.WriteLine(foundAt == -1 ? "Not Found" : $"Found at Index: {foundAt}");

            Console.WriteLine("END!");
            Console.ReadLine();


        }
    }
}