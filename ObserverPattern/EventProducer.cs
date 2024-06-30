using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class EventProducer : IProducer
    {
        private List<INotifier> observers = new List<INotifier>();

        public void AddObserver(INotifier observer)
        {
            if (!observers.Any(x => x.Id == observer.Id))
                observers.Add(observer);
        }

        public void NotifyAll(object data)
        {
            if(observers.Count <= 0)
                Console.WriteLine("No observers to notify");

            foreach (var observer in observers)
            {
                observer.Notify(data);
            }
        }

        //write a function to generate random number
        

        public void RemoveObserver(INotifier observer)
        {
            if (observers.Any(x => x.Id == observer.Id))
                observers.Remove(observer);
        }
    }
}
