using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dishes
{
    internal class VegPizza : IFood
    {
        public string Name => "Veg Pizza"; // "Veg Pizza

        public double TimeToCook => 45.0; // 45 minutes

        public void Cook()
        {
            Console.WriteLine("Cooking Veg Pizza");
        }

        public string GetRecipie()
        {
            Console.WriteLine("Recipie for Veg Pizza");
            return "Veg Pizza Recipie";
        }
    }
}
