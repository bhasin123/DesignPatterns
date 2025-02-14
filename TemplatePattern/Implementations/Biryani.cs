using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Implementations
{
    internal class Biryani : Cooking
    {
        protected override void CookFood()
        {
            Console.WriteLine("Cooking Biryani...");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Preparing Biryani...");
        }

        protected override void Drink()
        {
            Console.WriteLine("Drinking Coke...");
        }
    }
}
