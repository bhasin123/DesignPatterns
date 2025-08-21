using AbstractFactory.DBImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class CassandraFactory : IDBFactory
    {
        public IDBConnection GetDBConnection()
        {
            return new CassandraConnection();
        }

        public IDBParameter GetDBParameters()
        {
            return new CassandraParameters();
        }
    }
}
