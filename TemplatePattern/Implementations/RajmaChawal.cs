using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Implementations
{
    internal class RajmaChawal : Cooking
    {
        protected override void CookFood()
        {
            Console.WriteLine("Cooking Rajma Chawal...");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Preparing Rajma Chawal...");
        }

        protected override void Drink()
        {
            Console.WriteLine("Drinking Lassi...");
        }
    }
}
