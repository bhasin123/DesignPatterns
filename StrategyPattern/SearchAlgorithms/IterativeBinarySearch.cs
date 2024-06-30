using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SearchAlgorithms
{
    public class IterativeBinarySearch : ISearchStrategy
    {
        /// <summary>
        /// In Binary Search, arrItems should be sorted
        /// </summary>
        /// <param name="arrItems">arrItems should be sorted</param>
        /// <param name="searchNumber"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Search(int[] arrItems, int searchNumber)
        {
            Console.WriteLine("Implementing Search Using Iterative Binary Search Algorithm!");

            int first = 0;
            int last = arrItems.Length - 1;
            int mid;

            while(first <= last)
            {
                mid = (first + last) / 2;

                if (searchNumber == arrItems[mid])
                    return mid;

                if (searchNumber < arrItems[mid])
                {
                    last = mid - 1;
                }
                else if(searchNumber > arrItems[mid])
                {
                    first = mid + 1;
                }
            }

            return -1;
        }
    }
}
