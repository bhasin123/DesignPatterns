﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal interface ITrafficLight
    {
        void Change(TrafficLightContext context);

        void DoChallan();
    }
}
