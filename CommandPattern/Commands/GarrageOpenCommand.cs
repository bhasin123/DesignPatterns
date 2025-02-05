using CommandPattern.Model;

namespace CommandPattern.Commands
{
    internal class GarrageOpenCommand : ICommand
    {
        private Garrage garrage;
        public GarrageOpenCommand(Garrage garrage)
        {
            this.garrage = garrage;
        }
        public void Execute()
        {
            garrage.DoorOpen();
            garrage.OfficeOpen();
        }

        public void Undo()
        {
            garrage.OfficeClose();
            garrage.DoorClose();
        }
    }
}
