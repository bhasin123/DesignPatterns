namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Counter counter;
            LazyCounter counter;


            Parallel.For(0, 100, i =>
            {
                //counter = Counter.Initialize();
                counter = LazyCounter.Instance;

                Parallel.For(0, 10, j =>
                {
                    counter.Increment();
                });
            });
        }

    }
}
