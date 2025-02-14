using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Implementations
{
    internal class Oats : Cooking
    {
        protected override void CookFood()
        {
            Console.WriteLine("Cooking Oats...");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Preparing Oats...");
        }

    }
}
