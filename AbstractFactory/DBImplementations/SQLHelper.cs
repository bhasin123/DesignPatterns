using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DBImplementations
{
    internal class SQLHelper : IDBHelper
    {
        public void CloseConnection()
        {
            Console.WriteLine("SQL Connection Closed");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("SQL Command Executed");
        }

        public void OpenConnection()
        {
            Console.WriteLine("SQL Connection Opened");
        }
    }

    internal class SQLParameterHelper : IDBParameter
    {
        public void AddParameters()
        {
            Console.WriteLine("SQL Parameters Added");
        }

        public void GetParameters()
        {
            Console.WriteLine("SQL Parameters Fetched");
        }
    }
}
