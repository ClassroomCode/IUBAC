using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PropGenLib;

namespace PropGenTests
{
    [TestClass]
    public class PricingTests
    {
        private Course testCourse;

        [TestInitialize]
        public void CreateTestCourse()
        {
            testCourse = new Course()
            {
                Title = "Test Course",
                Duration = 3.0,
                BasePrice = 1000.00,
                PersonPrice = 100.00
            };
        }

        [TestMethod]
        public void SmallClass()
        {
            // Arrange
            Proposal proposal = new Proposal()
            {
                Course = testCourse,
                Attendees = 2
            };

            // Act
            double totalPrice = proposal.CalcuateTotalPrice();

            // Assert
            Assert.IsTrue(totalPrice == 1000.00);
        }

        [TestMethod]
        public void LargeClass()
        {
            // Arrange
            Proposal proposal = new Proposal()
            {
                Course = testCourse,
                Attendees = 15
            };

            // Act
            double totalPrice = proposal.CalcuateTotalPrice();

            // Assert
            Assert.IsTrue(totalPrice == 2200.00);
        }

        [TestMethod]
        public void LargeGsaClass()
        {
            // Arrange
            Proposal proposal = new Proposal()
            {
                Course = testCourse,
                Attendees = 15
            };
            IProposalPriceCalculator ppc = new GsaProposalPriceCalculator();

            // Act
            double totalPrice = proposal.CalcuateTotalPrice(ppc);

            // Assert
            Assert.IsTrue(totalPrice == 1530.00);
        }
    }
}
