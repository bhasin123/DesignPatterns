using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DBImplementations
{
    internal class PostgreSQLHelper : IDBHelper
    {
        public void CloseConnection()
        {
            Console.WriteLine("PostgreSQL Connection Closed");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("PostgreSQL Command Executed");
        }

        public void OpenConnection()
        {
            Console.WriteLine("PostgreSQL Connection Opened");
        }
    }

    internal class PostgreSQLParameterHelper : IDBParameter
    {
        public void AddParameters()
        {
            Console.WriteLine("PostgreSQL Parameters Added");
        }

        public void GetParameters()
        {
            Console.WriteLine("PostgreSQL Parameters Fetched");
        }
    }
}
