using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SearchAlgorithms
{
    public class RecursiveBinarySearch : ISearchStrategy
    {
        public int Search(int[] arrItems, int searchNumber)
        {
            Console.WriteLine("Implementing Search Using Recursive Binary Search Algorithm!");

            int first = 0;
            int last = arrItems.Length - 1;

            return SearchRec(arrItems, searchNumber, first, last);
        }

        private int SearchRec(int[] arrItems, int searchNumber, int first, int last)
        {
            int mid;

            if (first == last)
                return -1;

            mid = (first + last) / 2;

            if (searchNumber == arrItems[mid])
                return mid;

            if (searchNumber < arrItems[mid])
            {
                last = mid - 1;
            }
            else if (searchNumber > arrItems[mid])
            {
                first = mid + 1;
            }

            return SearchRec(arrItems, searchNumber, first, last);
        }
    }
}
