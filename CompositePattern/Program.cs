namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are implementing Composite Design Pattern!");

            //Composite Objects
            IComponent computer = new CompositeNode("Computer", 0.0);
            IComponent cabinet = new CompositeNode("Cabinet", 0.0);
            IComponent peripheral = new CompositeNode("peripheral", 0.0);

            //Leaf Objects
            IComponent cpu = new LeafNode("CPU", 10000.0);
            IComponent ram = new LeafNode("RAM", 5000.0);
            IComponent hdd = new LeafNode("HDD", 3000.0);
            IComponent monitor = new LeafNode("Monitor", 6000.0);
            IComponent mouse = new LeafNode("Mouse", 100.0);
            IComponent keyboard = new LeafNode("Keyboard", 300.0);

            //Assemble the computer
            computer.Add(cabinet);
            computer.Add(peripheral);

            cabinet.Add(cpu);
            cabinet.Add(ram);
            cabinet.Add(hdd);

            peripheral.Add(monitor);
            peripheral.Add(mouse);
            peripheral.Add(keyboard);

            //Display the computer
            Console.WriteLine("Displaying the computer components:");
            computer.Display(1);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Displaying the cabinet components:");
            cabinet.Display(2);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Displaying the peripheral components:");
            peripheral.Display(3);

            Console.ReadLine();
        }
    }
}
