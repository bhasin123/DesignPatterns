using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class TrafficLightContext
    {
        public ITrafficLight TrafficLightState { get; set; }

        public TrafficLightContext(ITrafficLight trafficLight)
        {
            TrafficLightState = trafficLight;
        }

        public void Change()
        {
            TrafficLightState.Change(this);
        }

        public void DoChallan()
        {
            TrafficLightState.DoChallan();
        }

    }
}
