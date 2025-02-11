using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Implementations
{
    internal class Bios
    {
        public void Start()
        {
            Console.WriteLine("Bios starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Bios stopping...");
        }
    }
}
