using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Additives
{
    internal class FlowerDecoratePrint : AdditiveDecorator
    {
        public FlowerDecoratePrint(IBeverage _beverage) : base(_beverage) { }

        public override float GetCost() => base.GetCost() + 10.0f;

        public override string GetDescription() => base.GetDescription() + " with beautiful Flower Decoration, ";
    }
}
