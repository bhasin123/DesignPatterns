using CommandPattern.Commands;
using CommandPattern.Model;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are going to Implement Command Pattern!");

            // Simple Remote Control Invoker
            SimpleRemoteControlInvoked();

            // Remote Control Invoker
            RemoteControlInvokerInvoked();

        }

        private static void RemoteControlInvokerInvoked()
        {
            RemoteControlInvoker remoteControl = new RemoteControlInvoker();

            Light light = new Light("Living Room");
            LightOnCommand livingRoomlightOnCommand = new LightOnCommand(light);

            LightOffCommand livingRooomlightOffCommand = new LightOffCommand(light);

            light = new Light("Kitchen");
            LightOnCommand kitchenlightOnCommand = new LightOnCommand(light);

            LightOffCommand kitchenlightOffCommand = new LightOffCommand(light);

            Garrage garrage = new Garrage();

            GarrageOpenCommand garrageOpenCommand = new GarrageOpenCommand(garrage);
            GarrageCloseCommand garrageCloseCommand = new GarrageCloseCommand(garrage);

            remoteControl.SetCommand(0, livingRoomlightOnCommand, livingRooomlightOffCommand);

            remoteControl.SetCommand(1, kitchenlightOnCommand, kitchenlightOffCommand);

            remoteControl.SetCommand(2, garrageOpenCommand, garrageCloseCommand);

            Console.WriteLine(remoteControl.ToString());

            Console.WriteLine("----------Living Room-----------");
            remoteControl.OnButtonPressed(0);
            remoteControl.OffButtonPressed(0);

            Console.WriteLine("----------Kitchen-----------");
            remoteControl.OnButtonPressed(1);
            remoteControl.OffButtonPressed(1);

            Console.WriteLine("----------Garrage-----------");
            remoteControl.OnButtonPressed(2);
            remoteControl.OffButtonPressed(2);

            Console.WriteLine("----------Undo Last-----------");
            remoteControl.UndoButtonPressed();

        }

        private static void SimpleRemoteControlInvoked()
        {
            SimpleRemoteControlInvoker remoteControl = new SimpleRemoteControlInvoker();

            Console.WriteLine("Command - LightOn!");
            LightOnCommand lightOn = new LightOnCommand(new Light("Living Room"));
            remoteControl.SetCommand(lightOn);
            remoteControl.ButtonPressed();

            Console.WriteLine("Command - LightOn - Done!");

            Console.WriteLine("Command - Lightff!");

            LightOffCommand lightOff = new LightOffCommand(new Light("Living Room"));
            remoteControl.SetCommand(lightOff);
            remoteControl.ButtonPressed();

            Console.WriteLine("Command - LightOff - Done!");
        }
    }
}
