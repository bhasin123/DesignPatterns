namespace ProtoTypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are implementing Prototype Pattern!");

            var emp1 = new Employee
            {
                Name = "Rohit Bhasin",
                Age = 30,
                Designation = "Software Engineer",
                CurrentAddress = new Address
                {
                    Street = "123 Main St",
                    City = "Springfield",
                    State = "IL",
                    ZipCode = "62701"
                },
                PermanentAddress = new Address
                {
                    Street = "456 Elm St",
                    City = "Springfield",
                    State = "IL",
                    ZipCode = "62702"
                }
            };

            Console.WriteLine($"Original Employee: {emp1.ToString()}");

            // Cloning the employee
            var emp2 = emp1.Clone();

            Console.WriteLine(emp2.ToString());

            Console.WriteLine("Modifying the original employee's Address and cloning Name...");

            emp1.CurrentAddress.Street = "Crossing";
            emp1.CurrentAddress.City = "Noida";
            emp1.CurrentAddress.State = "UP";
            emp1.CurrentAddress.ZipCode = "201016";

            emp2.Name = "Reyansh Bhasin";

            emp2.PermanentAddress = emp1.CurrentAddress;

            Console.WriteLine($"Original Employee: {emp1.ToString()}");

            Console.WriteLine($"Cloned Employee: {emp2.ToString()}");

            Console.ReadKey();

        }
    }
}
