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
            DeckBuilder test = new DeckBuilder();

            foreach (string tests in test.BuildDeck())
            {                
                Assert.ReferenceEquals("The 2 of Spades", "The 3 of Spades", "The 4 of Spades", "The 5 of Spades",
                    "The 6 of Spades", "The 7 of Spades", "The 8 of Spades", "The 9 of Spades", "The 10 of Spades",
                    "The Jack of Spades", "The Queen of Spades", "The King of Spades", "The Ace of Spades", tests);
            }




        }
        [TestMethod]
        public void CheckCardsPerSuit()
        {
            
        }
    }
}
