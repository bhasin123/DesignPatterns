using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class SimpleRemoteControlInvoker
    {
        ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonPressed()
        {
            if (slot == null)
            {
                Console.WriteLine("No command assigned to this button");
                return;
            }

            slot.Execute();

        }
    }
}
