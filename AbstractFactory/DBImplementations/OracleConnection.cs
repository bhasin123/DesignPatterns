using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DBImplementations
{
    internal class OracleConnection : IDBConnection
    {
        public void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Oracle Command Executed");
        }

        public void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Opened");
        }
    }

    internal class OracleParameters : IDBParameter
    {
        public void AddParameters()
        {
            Console.WriteLine("Oracle Parameters Added");
        }

        public void GetParameters()
        {
            Console.WriteLine("Oracle Parameters Fetched");
        }
    }
}
