using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class o_Beverage : IBeverage
    {
        public string GetDescription() => "Beverage";

        public float GetCost()
        {
            return 20.0f;
        }

    }
}
