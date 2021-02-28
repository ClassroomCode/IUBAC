using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public class StandardProposalPriceCalculator : IProposalPriceCalculator
    {
        public double CalculateTotalPrice(Proposal proposal)
        {
            double totalPrice = proposal.Course.BasePrice;
            int additionalAttendees = Math.Max(0, proposal.Attendees - 3);
            totalPrice += (additionalAttendees * proposal.Course.PersonPrice);
            return totalPrice;
        }
    }
}
