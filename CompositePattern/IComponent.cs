using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IComponent
    {
        string Description { get; set; }
        double Price { get; set; }
        void Add(IComponent component);
        void Remove(IComponent component);
        void Display(int depth);
    }
}
