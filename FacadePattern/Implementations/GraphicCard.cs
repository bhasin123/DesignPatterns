using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Implementations
{
    internal class GraphicCard
    {
        public void Start()
        {
            Console.WriteLine("Graphic card starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Graphic card stopping...");
        }
    }
}
