using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class LeafNode : IComponent
    {
        public LeafNode(string description, double price)
        {
            Description = description;
            Price = price;
        }

        public string Description { get; set; }
        public double Price { get; set; }

        public void Add(IComponent component)
        {
            throw new NotImplementedException("Can not add on Leaf Node!");
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Description + " " + Price);
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException("Can not remove on Leaf Node!");
        }
    }
}
