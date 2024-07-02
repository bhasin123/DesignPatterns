using AbstractFactory.DBImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class MongoFactory : IDBFactory
    {
        public IDBHelper GetDBHelper()
        {
            return new MongoHelper();
        }

        public IDBParameter GetDBParameters()
        {
            return new MongoParameterHelper();
        }
    }
}
