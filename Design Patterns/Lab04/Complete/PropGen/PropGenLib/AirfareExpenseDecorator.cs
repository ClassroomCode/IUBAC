using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public class AirfareExpenseDecorator : ExpenseDecorator
    {
        public AirfareExpenseDecorator(IProposalPriceCalculator ppc)
            : base(ppc) { }

        protected override double AddExpense(Proposal proposal, double totalPrice)
        {
            return totalPrice + 500.00;
        }
    }
}
