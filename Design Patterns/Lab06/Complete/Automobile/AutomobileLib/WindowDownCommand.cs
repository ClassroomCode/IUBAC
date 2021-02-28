using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class WindowDownCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowDownCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public void Execute()
        {
            window.OpenWindow();
        }
    }
}
