using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.IteratorAggregators
{
    internal class CNumberItems : IEnumerable<string>, IMenu
    {
        public string[] NumItems;

        public CNumberItems()
        {
            NumItems = new string[]
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five"
            };
        }

        public IEnumerable<string> CreateEnumerator()
        {
            return NumItems;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in NumItems)
            {
                yield return item;
               
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
