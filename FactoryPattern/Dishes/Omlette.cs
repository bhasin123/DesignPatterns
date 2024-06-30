using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dishes
{
    internal class Omlette : IFood
    {
        public string Name => "Omlette";

        public double TimeToCook => 15.0;

        public void Cook()
        {
            Console.WriteLine("Cooking Omlette");
        }

        public string GetRecipie()
        {
           Console.WriteLine("Recipie for Omlette");
            return "Omlette Recipie";
        }
    }
}
