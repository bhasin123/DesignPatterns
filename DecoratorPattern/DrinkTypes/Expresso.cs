using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkTypes
{
    internal class Expresso : IBeverage
    {
        public float GetCost() => 30.0f;

        public string GetDescription() => "Mind Opening Expresso Shot, ";
    }
}
