using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public class Proposal
    {
        public Course Course { get; set; }
        public int Attendees { get; set; }

        public double CalculateTotalPrice()
        {
            double retVal = Course.BasePrice;
            int additionalAttendees = Math.Max(0, Attendees - 3);
            retVal += (additionalAttendees * Course.PersonPrice);
            return retVal;
        }
    }
}
