using DecoratorPattern.Additives;
using DecoratorPattern.DrinkTypes;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We will look into Decorator Pattern!");

            Console.WriteLine("************************************");

            Console.WriteLine("************************************");
            Console.WriteLine("Ordering Cold Coffee with Whip cream");
            Console.WriteLine("************************************");

            IBeverage beverage1 = new ColdCoffee(); 
            beverage1 = new WhipCream(beverage1);
            PrintDetails(beverage1);

            Console.WriteLine("************************************");

            Console.WriteLine("************************************");
            Console.WriteLine("Ordering Hot Coffee with Milk and Whip cream and Decorate it with Flower Print");
            Console.WriteLine("************************************");

            IBeverage beverage2 = new HotCoffee();
            beverage2 = new Milk(beverage2);
            beverage2 = new WhipCream(beverage2);
            beverage2 = new FlowerDecoratePrint(beverage2);
            PrintDetails(beverage2);

            Console.WriteLine("************************************");

            Console.WriteLine("************************************");
            Console.WriteLine("Ordering Expresso with Mocha and Whip cream");
            Console.WriteLine("************************************");

            IBeverage beverage3 = new Expresso();
            beverage3 = new Mocha(beverage3);
            beverage3 = new WhipCream(beverage3);
            PrintDetails(beverage3);

            Console.WriteLine("************************************");

            Console.WriteLine("************************************");
            Console.WriteLine("Ordering Summer Cool Orange with Flower Decorate Print");
            Console.WriteLine("************************************");

            IBeverage beverage4 = new SummerCool();
            beverage4 = new Orange(beverage4);
            beverage4 = new FlowerDecoratePrint(beverage4);
            PrintDetails(beverage4);

            Console.WriteLine("************************************");


            Console.WriteLine("************************************");
            Console.WriteLine("Ordering Summer Cool BlueBerry");
            Console.WriteLine("************************************");

            IBeverage beverage5 = new SummerCool();
            beverage5 = new BlueBerry(beverage5);
            beverage5 = new FlowerDecoratePrint(beverage5);
            PrintDetails(beverage5);

            Console.WriteLine("************************************");

            Console.ReadLine();

        }

        private static void PrintDetails(IBeverage beverage1)
        {
            Console.WriteLine("Your Order Details:");

            Console.WriteLine($"Description: {OmmitLastComma(beverage1.GetDescription())}, Cost: {beverage1.GetCost()}");

        }

        private static object OmmitLastComma(string description) => description.Substring(0, description.LastIndexOf(',') - 1);

    }
}
