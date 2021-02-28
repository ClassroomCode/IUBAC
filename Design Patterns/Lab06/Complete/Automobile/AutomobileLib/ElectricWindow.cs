using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomobileLib
{
    public class ElectricWindow
    {
        private bool isOpen;

        public ElectricWindow()
        {
            isOpen = false;
        }

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public bool IsClosed
        {
            get { return !isOpen; }
        }

        public void OpenWindow()
        {
            if (IsClosed)
            {
                isOpen = true;
                Console.WriteLine("Window is now open");
            }
        }

        public void CloseWindow()
        {
            if (IsOpen)
            {
                isOpen = false;
                Console.WriteLine("Window is now closed");
            }
        }
    }
}
