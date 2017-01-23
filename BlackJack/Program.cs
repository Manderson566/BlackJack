using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum State
    {
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        faceCard = 10,
        Ace = 11
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            State currentState;
            DeckBuilder drawcard = new DeckBuilder();
           
            string reshuffle = drawcard.BuildDeck();
            //^^ Resuffles Deck
            Console.WriteLine("Welcome To BlackJack");
            Console.WriteLine("Press 1 To Deal");
            string askDeal = Console.ReadLine();
            Player hand = new Player();
            Dealer dHand = new Dealer();
            Dealer deal = new Dealer();
            Card getValue = new Card();
            if (askDeal == "1")
            {
                
                string newCard3 = deal.DealCard();
                dHand.DealerHand.Add(newCard3);
                string newCard4 = deal.DealCard();
                dHand.DealerHand.Add(newCard4);

               
                string newCard = deal.DealCard();
                hand.Player1Hand.Add(newCard);
                string newCard2 = deal.DealCard();
                hand.Player1Hand.Add(newCard2);

            }
            List<string> displayHand = hand.Player1Hand;
            Console.WriteLine("Your Cards Are");
            Console.WriteLine(getValue.cardValue);
            foreach (var card in displayHand) 
            {
                Console.WriteLine(card);
            }
            // List<string> displayDhand = dHand.DealerHand;
            //Console.WriteLine("The Dealers Cards Are");
            //foreach (var card in displayDhand)
            // {
            //   Console.WriteLine(card);
            // }
            Console.WriteLine("Do You Want To Hit?");
            string askForHit = Console.ReadLine();
            while (askForHit.ToUpper() == "Y")
            {
                string newCard = deal.DealCard();
                hand.Player1Hand.Add(newCard);
                Console.WriteLine("Do You Want To Hit?");
                Console.WriteLine("Your Cards Are");
              
                foreach (var card in displayHand)
                {
                   
                    int value3;
                    int value4;

                    int count = card.Count(x => x == '2');
                    int value2;
                    if (count == 1)
                    value2 = 2
                    int count2 = card.Count(x => x == '3');
                    if (count2 == 1)
                        value3 = 3;
                    int count3 = card.Count(x => x == '4');
                    if (count3 == 1)
                        value3 = 4;

                    Console.WriteLine(card);
                    
                }
       
                askForHit = Console.ReadLine();
             

            }






        }

    }
}