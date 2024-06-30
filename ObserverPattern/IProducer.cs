using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface IProducer
    {
        public void AddObserver(INotifier observer);
        public void RemoveObserver(INotifier observer);
        public void NotifyAll(object data);
    }
}
