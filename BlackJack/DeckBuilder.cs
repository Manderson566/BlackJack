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
        public static List<Card> CreateCardValues()
        {
            List<CardValues> CardList = new List<CardValues>()
        { CardValues.Queen, CardValues.King, CardValues.Jack, CardValues.Ace,
          CardValues.Ten, CardValues.Nine, CardValues.Eight, CardValues.Seven,
          CardValues.Six, CardValues.Five, CardValues.Four, CardValues.Three, CardValues.Two };

            List<suits> CardSuits = new List<suits>()
        {suits.Club, suits.Diamond, suits.Diamond, suits.Heart, suits.Spade};

             List<Card> CardDeck = new List<Card>();
            for (int numbOfSuits = 0; numbOfSuits < 4; numbOfSuits++)
            {
                for (int numbOfFaces = 0; numbOfFaces < 13; numbOfFaces++)
                {
                    CardDeck.Add(new Card(CardSuits[numbOfSuits], CardList[numbOfFaces], (int)CardList[numbOfFaces]));
                }
           
            }

            return CardDeck;





        }
      
             
            

          
        }
        
    }






