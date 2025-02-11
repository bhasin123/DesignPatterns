using FacadePattern.Implementations;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, we are implementing Facade Pattern!");

            Console.WriteLine("We are running a computer system. Instead of indic=vidualy running all subclasses, we use facade pattern to simplify it");

            Bios bios = new Bios();
            GraphicCard graphicCard = new GraphicCard();
            MouseTrack mouseTrack = new MouseTrack();
            Windows windows = new Windows();

            ComputerSystemFacade computerSystemFacade = new ComputerSystemFacade(graphicCard, bios, mouseTrack, windows);

            Console.WriteLine("Starting computer system...");
            computerSystemFacade.Start();

            Console.WriteLine("Stopping computer system...");
            computerSystemFacade.Stop();
        }
    }
}
