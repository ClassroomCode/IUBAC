using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class VolumeDownCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeDownCommand(Radio radio)
        {
            this.radio = radio;
        }

        public void Execute()
        {
            radio.VolumeDown();
        }
    }
}
