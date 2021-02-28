using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class VolumeUpCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeUpCommand(Radio radio)
        {
            this.radio = radio;
        }

        public void Execute()
        {
            radio.VolumeUp();
        }
    }
}
