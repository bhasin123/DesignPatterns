using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class AdditiveDecorator : IBeverage
    {
        public IBeverage beverage;

        public AdditiveDecorator(IBeverage _beverage)
        {
            this.beverage = _beverage;
        }

        public virtual float GetCost() => beverage.GetCost();

        public virtual string GetDescription() => beverage.GetDescription();
    }
}
