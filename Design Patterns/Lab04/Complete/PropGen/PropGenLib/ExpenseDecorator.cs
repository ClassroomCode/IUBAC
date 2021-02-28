using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropGenLib
{
    public abstract class ExpenseDecorator : IProposalPriceCalculator
    {
        private IProposalPriceCalculator component;

        public ExpenseDecorator(IProposalPriceCalculator ppc)
        {
            component = ppc;
        }

        public double CalculateTotalPrice(Proposal proposal)
        {
            double totalPrice = component.CalculateTotalPrice(proposal);
            totalPrice = AddExpense(proposal, totalPrice);
            return totalPrice;
        }

        protected abstract double AddExpense(Proposal proposal, double totalPrice);
    }
}
