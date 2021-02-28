using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventfulLib;

namespace EventfulTests
{
    [TestClass]
    public class AlbumTests
    {
        private bool eventFired;
        private Album album;

        [TestInitialize]
        public void Init()
        {
            album = new Album("Up");
            eventFired = false;
        }

        [TestMethod]
        public void Attach()
        {
            album.PlayEvent += OnPlay;
            album.Play();

            Assert.IsTrue(eventFired);
        }

        [TestMethod]
        public void DoNotAttach()
        {
            album.Play();
            Assert.IsFalse(eventFired);
        }

        private void OnPlay(object subject, EventArgs eventArgs)
        {
            eventFired = true;
        }
    }
}
