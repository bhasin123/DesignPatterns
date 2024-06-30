using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SearchAlgorithms
{
    public class LinearSearch : ISearchStrategy
    {
        public int Search(int[] arrItems, int searchNumber)
        {
            Console.WriteLine("Implementing Search Using Linear Search Algorithm!");

            for (int i = 0; i < arrItems.Length; i++)
            {
                if (arrItems[i] == searchNumber)
                    return i;
            }

            return -1;
        }
    }
}
