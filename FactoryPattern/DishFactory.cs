using FactoryPattern.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class DishFactory
    {
        private static IFood Create<T>() where T : IFood, new()
        {
            return new T();
        }
        public static IFood GetDish(string dishName)
        {
            switch (dishName)
            {
                case "rajmachawal":
                    return Create<RajmaChawal>();
                case "chickenbiryani":
                    return Create<ChickenBiryani>();
                case "omlette":
                    return Create<Omlette>();
                case "vegpizza":
                    return Create<VegPizza>();
                default:
                    Console.WriteLine("Invalid dish name");
                    return null;
            }
        }
    }
}
