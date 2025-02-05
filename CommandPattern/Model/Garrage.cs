namespace CommandPattern.Model
{
    internal class Garrage
    {
        public void DoorOpen() => Console.WriteLine("Garrage Door is open");
        public void DoorClose() => Console.WriteLine("Garrage Dooe is closed"); 

        public void OfficeOpen() => Console.WriteLine("Garrage Office is open");
        public void OfficeClose() => Console.WriteLine("Garrage Office is closed");

    }
}
