using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    internal abstract class Cooking
    {
        public void Cook()
        {
            Prepare();
            CookFood();
            Eat();
            Drink();
        }

        protected virtual void Drink()
        {
            Console.WriteLine("Drinking Water...");
        }

        protected abstract void Prepare();
        protected abstract void CookFood();

        private void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
