using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dishes
{
    internal class ChickenBiryani : IFood
    {
        public string Name => "Chicken Biryani";

        public double TimeToCook => 60.0;

        public void Cook()
        {
            Console.WriteLine("Cooking Chicken Biryani");
        }

        public string GetRecipie()
        {
            Console.WriteLine("Recipie for Chicken Biryani");
            return "Chicken Biryani Recipie";
        }
    }
}
