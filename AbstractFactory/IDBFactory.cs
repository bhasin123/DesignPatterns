using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IDBFactory
    {
        IDBConnection GetDBConnection();
        IDBParameter GetDBParameters();
    }
}
