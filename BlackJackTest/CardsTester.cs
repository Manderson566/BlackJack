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
            var sut = new DeckBuilder();
            Assert.AreEqual(1, 5, sut.());
            Assert.AreEqual("Spade", sut.CreateDeck());
           

        }
        [TestMethod]
        public void CheckCardsPerSuit()
        {
            
        }
    }
}
