using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementations
{
    internal class YellowLight : ITrafficLight
    {
        public void Change(TrafficLightContext context)
        {
            Console.WriteLine("Yellow Light: Prepare to stop.");
            context.TrafficLightState = new RedLight();
        }

        public void DoChallan()
        {
            Console.WriteLine("YellowLight: Nothing to do.");
        }
    }
}
