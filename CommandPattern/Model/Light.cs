namespace CommandPattern.Model
{
    internal class Light
    {
        string description;

        public Light(string description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine($"{description} Light is on!");
        }

        public void Off()
        {
            Console.WriteLine($"{description} Light is off!");
        }
    }
}
