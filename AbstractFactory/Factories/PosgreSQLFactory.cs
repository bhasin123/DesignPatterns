using AbstractFactory.DBImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class PosgreSQLFactory : IDBFactory
    {
        public IDBHelper GetDBHelper()
        {
            return new PostgreSQLHelper();
        }

        public IDBParameter GetDBParameters()
        {
            return new PostgreSQLParameterHelper();
        }
    }
}
