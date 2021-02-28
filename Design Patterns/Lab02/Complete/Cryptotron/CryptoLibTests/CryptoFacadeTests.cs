using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoLib;

namespace CryptoLibTests
{
    [TestClass]
    public class CryptoFacadeTests
    {
        [TestMethod]
        public void ReversibleEncryption()
        {
            // Arrange
            var cf = new CryptoFacade();
            string str = "This is a test";
            string result;

            // Act
            result = cf.Encrypt(str);
            result = cf.Decrypt(result);

            // Assert
            Assert.AreEqual(str, result);
        }
    }
}
