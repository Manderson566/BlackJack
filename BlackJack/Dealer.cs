using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack
{
    class Dealer: DeckBuilder
    {
        public string DealCard()
        {
            if (new FileInfo(@"..\..\Deck.txt").Length == 0)
            {
                DeckBuilder drawcard = new DeckBuilder();
                string newCard = drawcard.BuildDeck();
            }
            string pulledCard = File.ReadLines(@"..\..\Deck.txt").First();
            List<string> cardList = File.ReadAllLines(@"..\..\Deck.txt").ToList();
            string firstCard = cardList[0];
            cardList.RemoveAt(0);
            File.WriteAllLines(@"..\..\Deck.txt", cardList.ToArray());
          
                return firstCard;

            
        }
    }
}
