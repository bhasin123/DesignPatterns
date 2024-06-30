using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal interface IBeverage
    {
        public string GetDescription();

        public float GetCost();
    }
}
