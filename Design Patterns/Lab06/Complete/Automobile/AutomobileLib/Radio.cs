using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class Radio
    {
        public const int MinVolume = 0;
        public const int MaxVolume = 10;
        public const int DefaultVolume = 5;

        private bool switchedOn;
        private int volume;

        public Radio()
        {
            switchedOn = false;
            volume = DefaultVolume;
        }

        public bool IsOn
        {
            get { return switchedOn; }
        }

        public int Volume
        {
            get { return volume; }
        }

        public void SwitchOn()
        {
            switchedOn = true;
            Console.WriteLine("Radio now on, volume level {0}", Volume);
        }

        public void SwitchOff()
        {
            switchedOn = false;
            Console.WriteLine("Radio is now off");
        }

        public void VolumeUp()
        {
            if (IsOn)
            {
                if (Volume < MaxVolume)
                {
                    volume++;
                    Console.WriteLine("Volume turned up to level {0}", Volume);
                }
            }
        }

        public void VolumeDown()
        {
            if (IsOn)
            {
                if (Volume > MinVolume)
                {
                    volume--;
                    Console.WriteLine("Volume turned down to level {0}", Volume);
                }
            }
        }
    }
}
