using System.Text;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is old fashioned way.");
            OldWay();

            Console.WriteLine("This is Builder way.");
            NewWay();

            Console.ReadKey();


        }

        private static void NewWay()
        {
            var builder = new HTMLBuilder("ul");
            builder.Addchild("li", "Hello")
                   .Addchild("li", "World");

            Console.WriteLine(builder.ToString());


        }

        private static void OldWay()
        {
            var msg = "Hello, World!";

            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(msg);
            sb.Append("</p>");

            Console.WriteLine(sb.ToString());
        }
    }
}