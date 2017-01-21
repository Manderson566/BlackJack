using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;


namespace BlackJack
{
    public class DeckBuilder : Card
    {
        public List<string> BuildDeck()
        {
            Card newCard = new Card();
            int dynamicValue = 2;
            string cardDescription;
            var deck = new List<String>();
            for (int i = 1; i < 15; i++)
               
            {
                newCard.cardSuit = "Spades";
                newCard.jack = "Jack";
                newCard.queen = "Queen";
                newCard.king = "King";
                newCard.ace = "Ace";
                newCard.cardValue = dynamicValue.ToString();
                if (dynamicValue < 10)
                {
                    dynamicValue++;
                    deck.Add($"The {newCard.cardValue} of {newCard.cardSuit} ");
                }
                else if (dynamicValue == 10 && i == 10)
                {
                    dynamicValue = 10;
                    deck.Add($"The {newCard.cardValue} of {newCard.cardSuit} ");

                }
                else if (dynamicValue == 10 && i == 11)
                {
                    dynamicValue = 10;
                    deck.Add($"The {newCard.jack} of {newCard.cardSuit} ");
                }
                else if (dynamicValue == 10 && i == 12)
                {
                    dynamicValue = 10;
                    deck.Add($"The {newCard.queen} of {newCard.cardSuit} ");
                }
                else if (dynamicValue == 10 && i == 13)
                {
                    dynamicValue = 10;
                    deck.Add($"The {newCard.king} of {newCard.cardSuit} ");
                }
                else if (dynamicValue == 10 && i == 14)
                {
                    dynamicValue = 11;
                    deck.Add($"The {newCard.ace} of {newCard.cardSuit} ");
                }

            }
            return deck;      
        }
           


    }


}








