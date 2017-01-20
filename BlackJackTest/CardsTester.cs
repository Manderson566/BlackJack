using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackTest;
using BlackJack;

namespace BlackJackTest
{
    [TestClass]
    public class CardsTester
    {
        [TestMethod]
        public void TestSuitReturns()
        {
            var sut = new Cards();
            Assert.AreEqual("Spade", sut.GetSpade());
            Assert.AreEqual("Heart", sut.GetHeart());
            Assert.AreEqual("Diamond", sut.GetDiamond());
            Assert.AreEqual("Club", sut.GetClub());

        }
        [TestMethod]
        public void CheckCardsPerSuit()
        {
            
        }
    }
}
