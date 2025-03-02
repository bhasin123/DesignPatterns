using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class CompositeNode : IComponent
    {
        public CompositeNode(string description, double price)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
        }

        public string Description { get; set; }
        public double Price { get; set; }

        public List<IComponent> Components = new List<IComponent>();

        public void Add(IComponent component)
        {
            Components.Add(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Description);

            var totalPrice = Price;
            foreach (var component in Components)
            {
                component.Display(depth + 2);
                totalPrice += component.Price;
            }

            Console.WriteLine(new string('-', depth) + $" Total Price of {Description} - " + totalPrice);
        }

        public void Remove(IComponent component)
        {
            Components.Remove(component);
        }
    }
}
