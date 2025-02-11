using FacadePattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class ComputerSystemFacade
    {
        private readonly GraphicCard _graphicCard;
        private readonly Bios _bios;
        private readonly MouseTrack _mouseTrack;
        private readonly Windows _windows;

        public ComputerSystemFacade(GraphicCard graphicCard, Bios bios, MouseTrack mouseTrack, Windows windows)
        {
            _graphicCard = graphicCard;
            _bios = bios;
            _mouseTrack = mouseTrack;
            _windows = windows;
        }

        public void Start()
        {
            _graphicCard.Start();
            _bios.Start();
            _mouseTrack.Start();
            _windows.Start();
        }

        public void Stop()
        {
            _windows.Stop();
            _mouseTrack.Stop();
            _graphicCard.Stop();
            _bios.Stop();
        }
    }
}
