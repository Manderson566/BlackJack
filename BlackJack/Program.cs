using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    
    

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
                int counter = 0;
                int totalValue = 0;
                string newCard = deal.DealCard();
                Console.WriteLine("Do You Want To Hit?");
                Console.WriteLine("Your Cards Are");
                foreach (var card in displayHand)
                {
                    counter = 0;
                    Console.WriteLine(card);
                    if (card.Contains('2'))
                    {
                        counter = 2;
                    }
                    else if (card.Contains('3'))
                    {
                        counter = 3;
                    }
                    else if (card.Contains('4'))
                    {
                        counter = 4;
                    }
                    else if (card.Contains('5'))
                    {
                        counter = 5;
                    }
                    else if (card.Contains('6'))
                    {
                        counter = 6;
                    }
                    else if (card.Contains('7'))
                    {
                        counter = 7;
                    }
                    else if (card.Contains('8'))
                    {
                        counter = 8;
                    }
                    else if (card.Contains('9'))
                    {
                        counter = 9;
                    }
                    else if (card.Contains('1'))
                    {
                        counter = 10;
                    }
                    else if (card.Contains('J'))
                    {
                        counter = 10;
                    }
                    else if (card.Contains('A'))
                    {
                        counter = 10;
                    }
                    for (int i = 0; i < counter; i++)
                    {
                        totalValue++;
                    }
                }                               
                askForHit = Console.ReadLine();
                Console.Clear();
                hand.Player1Hand.Add(newCard);
               
                
           

            }
           






        }

    }
}