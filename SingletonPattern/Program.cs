namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Counter counter;

            Parallel.For(0, 100, i =>
            {
                counter = Counter.Initialize();
                Parallel.For(0, 10, j =>
                {
                    counter.Increment();
                });
            });
        }

    }
}
