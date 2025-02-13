﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class SearchEngineContext
    {
        private ISearchStrategy _searchStrategy;

        public SearchEngineContext(ISearchStrategy searchStrategy)
        {
            this._searchStrategy = searchStrategy;
        }

        public void SetStrategy(ISearchStrategy searchStrategy)
        {
            this._searchStrategy = searchStrategy;
        }

        public int Search(int[] arrItems, int searchNumber)
        {
            return _searchStrategy.Search(arrItems, searchNumber);
        }
    }
}
