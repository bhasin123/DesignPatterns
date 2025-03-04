using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementations
{
    internal class GreenLight : ITrafficLight
    {
        public void Change(TrafficLightContext context)
        {
            Console.WriteLine("Green Light: Cars can go.");
            context.TrafficLightState = new YellowLight();
        }

        public void DoChallan()
        {
            Console.WriteLine("Green Light: If car moves in wrong direction, challan issued.");
        }
    }
}
