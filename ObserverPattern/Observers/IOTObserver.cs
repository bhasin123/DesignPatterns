using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    internal class IOTObserver : INotifier
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public void Notify(object data)
        {
            Console.WriteLine($"IOT Device {Id} received data: {data}");
        }
    } 
}
