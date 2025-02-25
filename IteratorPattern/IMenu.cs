using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal interface IMenu
    {
        public IEnumerable<string> CreateEnumerator();
    }
}
