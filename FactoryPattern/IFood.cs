using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IFood
    {
        string Name { get; }
        double TimeToCook { get; }

        void Cook();
        string GetRecipie();
    }
}
