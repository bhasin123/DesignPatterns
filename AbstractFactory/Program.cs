using AbstractFactory.Factories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Today we will check Implementation of Abstract Factory Pattern!");

            string input = string.Empty;
            do
            {
                Console.WriteLine("Enter which factory you need to configure:");
                Console.WriteLine("1. SQL");
                Console.WriteLine("2. Oracle");
                Console.WriteLine("3. Mongo");
                Console.WriteLine("4. Cassandra");
                Console.WriteLine("5. Postgres");
                Console.WriteLine("6. Exit");

                input = Console.ReadLine();
                var factory = GetFactory(input);

                if(factory != null)
                {
                    factory.GetDBConnection().OpenConnection();
                    factory.GetDBParameters().AddParameters();
                    factory.GetDBConnection().ExecuteCommand();
                    factory.GetDBParameters().GetParameters();
                    factory.GetDBConnection().CloseConnection();
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            } while (input != "6");

        }

        private static IDBFactory GetFactory(string input)
        {
            IDBFactory factory = null;

            switch (input)
            {
                case "1":
                    factory = new SQLFactory();
                    break;
                case "2":
                    factory = new OracleFactory();
                    break;
                case "3":
                    factory = new MongoFactory();
                    break;
                case "4":
                    factory = new CassandraFactory();
                    break;
                case "5":
                    factory = new PosgreSQLFactory();
                    break;
                case "6":
                    factory = null;
                    break;
            }

            return factory;
        }
    }
}
