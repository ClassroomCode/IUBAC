using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public class SalesTaxExpenseDecorator : ExpenseDecorator
    {
        public SalesTaxExpenseDecorator(IProposalPriceCalculator ppc)
            : base(ppc) { }

        protected override double AddExpense(Proposal proposal, double totalPrice)
        {
            return totalPrice + (totalPrice * 0.05);
        }
    }
}
