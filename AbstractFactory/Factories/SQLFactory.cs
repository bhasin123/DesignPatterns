using AbstractFactory.DBImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class SQLFactory : IDBFactory
    {
        public IDBHelper GetDBHelper()
        {
            return new SQLHelper();
        }

        public IDBParameter GetDBParameters()
        {
            return new SQLParameterHelper();
        }
    }
}
