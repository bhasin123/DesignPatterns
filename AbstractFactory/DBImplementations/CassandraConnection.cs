using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DBImplementations
{
    internal class CassandraConnection : IDBConnection
    {
        public void CloseConnection()
        {
            Console.WriteLine("Cassandra Connection Closed");
        }

        public void ExecuteCommand()
        {
            Console.WriteLine("Cassandra Command Executed");
        }

        public void OpenConnection()
        {
            Console.WriteLine("Cassandra Connection Opened");
        }
    }

    internal class CassandraParameters : IDBParameter
    {
        public void AddParameters()
        {
            Console.WriteLine("Cassandra Parameters Added");
        }

        public void GetParameters()
        {
            Console.WriteLine("Cassandra Parameters Fetched");
        }
    }
}
