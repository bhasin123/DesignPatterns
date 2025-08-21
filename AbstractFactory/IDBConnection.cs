using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IDBConnection
    {
        void OpenConnection();
        void CloseConnection();
        void ExecuteCommand();

    }

    interface IDBParameter
    {
        void AddParameters();
        void GetParameters();

    }
}
