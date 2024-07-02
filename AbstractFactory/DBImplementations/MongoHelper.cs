using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DBImplementations
{
    internal class MongoHelper : IDBHelper
    {
        public void CloseConnection()
        {
            Console.WriteLine("Mongo Connection Closed");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Mongo Command Executed");
        }

        public void OpenConnection()
        {
            Console.WriteLine("Mongo Connection Opened");
        }
    }

    internal class MongoParameterHelper : IDBParameter
    {
        public void AddParameters()
        {
            Console.WriteLine("Mongo Parameters Added");
        }

        public void GetParameters()
        {
            Console.WriteLine("Mongo Parameters Fetched");
        }
    }
}
