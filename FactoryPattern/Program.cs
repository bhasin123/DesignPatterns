namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dish = string.Empty;
            Console.WriteLine("Hello to Factory Pattern World!");

            do
            {
                Console.WriteLine("Enter the dish you want to cook:");
                dish = Console.ReadLine();

                IFood food = DishFactory.GetDish(dish.ToLower());

                if (food != null)
                {
                    Console.WriteLine($"Cooking {food.Name}");
                    food.Cook();
                    Console.WriteLine($"Time to cook: {food.TimeToCook} minutes");
                    Console.WriteLine($"Recipie: {food.GetRecipie()}");
                }
                else
                {
                    Console.WriteLine("Invalid dish");
                } 
            } while (dish.ToLower() != "end");

            Console.ReadLine(); 
        }
    }
}
