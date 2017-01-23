using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    
    

    class Program
    {
        State currentState;

        static void Main(string[] args)
        {
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
                    Console.WriteLine(card);
                }
                askForHit = Console.ReadLine();
                
           

            }
           






        }

    }
}