using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public interface IProposalPriceCalculator
    {
        double CalculateTotalPrice(Proposal proposal);
    }
}
