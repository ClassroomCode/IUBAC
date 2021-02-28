using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventfulLib
{
    public class Album
    {
        private String name;

        public event EventHandler PlayEvent;

        public Album(String name)
        { 
            this.name = name; 
        }

        public void Play()
        {
            Notify();

            // code to play the album
        }

        private void Notify()
        {
            if (PlayEvent != null)
            {
                PlayEvent(this, EventArgs.Empty);
            }
        }

        public String Name
        {
            get { return name; }
        }
    }
}
