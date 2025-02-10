using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Implementations
{
    internal class PondDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Pond Duck is flying");
        }

        public void Quack()
        {
            Console.WriteLine("Pond Duck is quacking");
        }
    }
}
