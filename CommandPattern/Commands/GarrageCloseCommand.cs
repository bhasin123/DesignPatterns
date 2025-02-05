using CommandPattern.Model;

namespace CommandPattern.Commands
{
    internal class GarrageCloseCommand : ICommand
    {
        private Garrage garrage;

        public GarrageCloseCommand(Garrage garrage)
        {
            this.garrage = garrage;
        }
        public void Execute()
        {
            garrage.OfficeClose();
            garrage.DoorClose();
        }

        public void Undo()
        {
            garrage.DoorOpen();
            garrage.OfficeOpen();
        }
    }
}
