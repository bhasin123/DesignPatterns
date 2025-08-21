using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LazyCounter
    {
        private static int counter;

        private static Lazy<LazyCounter> instance = new Lazy<LazyCounter>(() => new LazyCounter());

        public static readonly LazyCounter Instance = instance.Value;

        public LazyCounter()
        {
            Console.WriteLine("LazyCounter instance created.");
        }

        public void Increment()
        {
            System.Threading.Interlocked.Increment(ref counter);
            Console.WriteLine($"Counter - {counter}, ThreadId - {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
