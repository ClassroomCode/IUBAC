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

        public double CalcuateTotalPrice(IProposalPriceCalculator ppc = null)
        {
            if (ppc == null) ppc = new StandardProposalPriceCalculator();
            return ppc.CalculateTotalPrice(this);
        }
    }
}
