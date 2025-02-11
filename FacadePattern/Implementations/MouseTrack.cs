using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Implementations
{
    internal class MouseTrack
    {
        public void Start()
        {
            Console.WriteLine("MouseTrack starting...");
        }

        public void Stop()
        {
            Console.WriteLine("MouseTrack stopping...");
        }
    }
}
