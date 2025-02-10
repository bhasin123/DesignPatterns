using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Implementations
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Mallard Duck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Duck is quacking");
        }
    }
}
