using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Counter
    {
        public static int Count { get; private set; }

        private static Counter _instance;
        private static object lockObj = new object();

        private Counter()
        {
        }

        public static Counter Initialize()
        {
            if(_instance == null)
            {
                lock(lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new Counter();
                        Count = 0;
                    }
                }
            }

            return _instance;
        }

        public Counter GetInstance()
        {
            return _instance;
        }


        public void Increment()
        {
            Count++;
            Console.WriteLine($"Count is now {Count}, ThreadId - {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
