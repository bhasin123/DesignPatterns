using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkTypes
{
    internal class HotCoffee : IBeverage
    {
        public float GetCost() => 20.0f;

        public string GetDescription() => "Hot Addictive Coffee, ";
    }
}
