using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventfulLib
{
    public class Album : Subject
    {
        private String name;

        public Album(String name)
        { 
            this.name = name; 
        }

        public void Play()
        {
            Notify();

            // code to play the album
        }

        public String Name
        {
            get { return name; }
        }
    }
}
