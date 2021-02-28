using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public class GsaProposalPriceCalculator : IProposalPriceCalculator
    {
        public double CalculateTotalPrice(Proposal proposal)
        {
            double totalPrice = proposal.Course.BasePrice;
            totalPrice += (7 * proposal.Course.PersonPrice);
            totalPrice -= (totalPrice * 0.10);
            return totalPrice;
        }
    }
}
