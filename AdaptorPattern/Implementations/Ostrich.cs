using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Implementations
{
    internal class Ostrich : IOstrich
    {
        public void MakeNoise()
        {
            Console.WriteLine("Ostrich is making noise");
        }

        public void Run()
        {
            Console.WriteLine("Ostrich can't fly. It is running");
        }
    }
}
