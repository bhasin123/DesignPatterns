using AbstractFactory.DBImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class OracleFactory : IDBFactory
    {
        public IDBHelper GetDBHelper()
        {
            return new OracleHelper();
        }

        public IDBParameter GetDBParameters()
        {
            return new OracleParameterHelper();
        }
    }
}
