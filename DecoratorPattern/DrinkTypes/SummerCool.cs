using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkTypes
{
    internal class SummerCool : IBeverage
    {
        public float GetCost() => 50.0f;

        public string GetDescription() => "Refreshing Cool drink for Summer, ";
    }
}
