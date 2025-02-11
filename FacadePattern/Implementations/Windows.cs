using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Implementations
{
    internal class Windows
    {
        public void Start()
        {
            Console.WriteLine("Windows starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Windows stopping...");
        }
    }
}
