﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;
using System.IO;


namespace BlackJack
{
    public class DeckBuilder : Card
    {
        public List<string> BuildDeck()
        {
            
            Card newCard = new Card();
            int dynamicValue = 2;
            var deck = new List<String>();
            for (int i = 1; i < 15; i++)               
            {
                newCard.cardValue = dynamicValue.ToString();
                if (dynamicValue < 10)
                { //2-9
                    dynamicValue++;
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[3]} ");

                }
                else if (dynamicValue == 10 && i == 10)
                { //10s
                    dynamicValue = 10;
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.cardValue} of {newCard.suit[3]} ");

                }
                else if (dynamicValue == 10 && i == 11)
                { //Jacks
                    dynamicValue = 10;
                    deck.Add($"The {newCard.face[0]} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.face[0]} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.face[0]} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.face[0]} of {newCard.suit[3]} ");
                }
                else if (dynamicValue == 10 && i == 12)
                { //Queens
                    dynamicValue = 10;
                    deck.Add($"The {newCard.face[1]} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.face[1]} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.face[1]} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.face[1]} of {newCard.suit[3]} ");
                }
                else if (dynamicValue == 10 && i == 13)
                { //Kings
                    dynamicValue = 10;
                    deck.Add($"The {newCard.face[2]} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.face[2]} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.face[2]} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.face[2]} of {newCard.suit[3]} ");
                }
                else if (dynamicValue == 10 && i == 14)
                { //Ace
                    dynamicValue = 11;
                    deck.Add($"The {newCard.face[3]} of {newCard.suit[0]} ");
                    deck.Add($"The {newCard.face[3]} of {newCard.suit[1]} ");
                    deck.Add($"The {newCard.face[3]} of {newCard.suit[2]} ");
                    deck.Add($"The {newCard.face[3]} of {newCard.suit[3]} ");
                }
                
                
            }
            string deckfile = (@"..\..\Deck.txt");
            File.WriteAllLines(deckfile, deck);
            return deck;


        }
        public string rndObject;
      

        public string RandomCard()
        {
            
            string[] pulledWordArray = File.ReadAllLines(@"..\\..\\Deck.txt");
            List<string> pulledWordList = pulledWordArray.ToList<string>();
            var rng = new Random();
            int randomThing = rng.Next(pulledWordList.Count);
            string randomObject = pulledWordList[randomThing];
            rndObject = randomObject;
            return rndObject;
        }
       



    }


}








