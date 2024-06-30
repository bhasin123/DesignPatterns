using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Additives
{
    internal class WhipCream : AdditiveDecorator
    {
        public WhipCream(IBeverage _beverage) : base(_beverage) { }

        public override float GetCost() => base.GetCost() + 5.0f;

        public override string GetDescription() => base.GetDescription() + " with WhipCream, ";
    }
}
