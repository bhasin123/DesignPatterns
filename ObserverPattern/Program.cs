using ObserverPattern.Observers;
using System.Text.Json;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Watching Observer Pattern in Action!");

            EventProducer producer = new EventProducer();
            var webAppObserver = new WebAppObserver();
            var tabletObserver = new TabletObserver();
            var mobileObserver = new MobileObserver();
            var iotObserver = new IOTObserver();

            producer.AddObserver(webAppObserver);
            producer.AddObserver(tabletObserver);
            producer.AddObserver(mobileObserver);
            producer.AddObserver(iotObserver);

            Console.WriteLine("Attached 4 Observers");
            NotifyAllObservers(producer);

            Console.WriteLine("************************************");

            Console.WriteLine("Detaching Observer - IOT");
            producer.RemoveObserver(iotObserver);
            NotifyAllObservers(producer);

            Console.WriteLine("************************************");

            Console.WriteLine("Detaching Observer - Tablet");
            producer.RemoveObserver(tabletObserver);
            NotifyAllObservers(producer);

            Console.WriteLine("************************************");

            Console.WriteLine("Detaching Observer - Mobile");
            producer.RemoveObserver(mobileObserver);
            NotifyAllObservers(producer);

            Console.WriteLine("************************************");

            Console.WriteLine("Detaching Observer - WebApp");
            producer.RemoveObserver(webAppObserver);
            NotifyAllObservers(producer);

            Console.ReadLine();
        }

        private static void NotifyAllObservers(EventProducer producer)
        {
            for (int i = 0; i < 5; i++)
            {
                producer.NotifyAll(GenerateRandomNumber());
                Thread.Sleep(2000);
            }
        }

        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
    }
}