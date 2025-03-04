using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Implementations
{
    internal class RedLight : ITrafficLight
    {
        public void Change(TrafficLightContext context)
        {
            Console.WriteLine("Red Light: Cars must stop.");
            context.TrafficLightState = new GreenLight();
        }

        public void DoChallan()
        {
            Console.WriteLine("Red Light: If cars passes, challan issued.");
        }
    }
}
