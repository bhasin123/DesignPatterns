using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Dishes
{
    internal class RajmaChawal : IFood
    {
        public string Name => "Rajma Chawal"; // "Rajma Chawal

        public double TimeToCook => 75.0; // 75 minutes

        public void Cook()
        {
            Console.WriteLine("Cooking Rajma Chawal");
        }

        public string GetRecipie()
        {
            Console.WriteLine("Recipie for Rajma Chawal");
            return "Rajma Chawal Recipie";
        }
    }
}
