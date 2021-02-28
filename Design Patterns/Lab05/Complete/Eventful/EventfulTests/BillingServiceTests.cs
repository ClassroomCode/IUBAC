using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventfulLib;

namespace EventfulTests
{
    [TestClass]
    public class BillingServiceTests
    {
        [TestMethod]
        public void AlbumChargeTest()
        {
            BillingService billing = new BillingService();
            Album album = new Album("Up");

            //album.AddObserver(billing);

            album.Play();

            Assert.Inconclusive("Need a way to check that charge has taken place");
        }
    }
}
