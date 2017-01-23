using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {   bool retry = true;
            while (retry == true)
            {
                DeckBuilder drawcard = new DeckBuilder();
                string reshuffle = drawcard.BuildDeck();
                //^^ Resuffles Deck
                Console.WriteLine("Welcome To BlackJack");
                Console.WriteLine("Press Enter To Play");
                
                Player hand = new Player();
                Dealer dHand = new Dealer();
                Dealer deal = new Dealer();
                Card getValue = new Card();

                string askDeal = Console.ReadLine();
                                 
                    string newCard3 = deal.DealCard();
                    dHand.DealerHand.Add(newCard3);
                    string newCard4 = deal.DealCard();
                    dHand.DealerHand.Add(newCard4);

                    string newCard = deal.DealCard();
                    hand.Player1Hand.Add(newCard);
                    string newCard2 = deal.DealCard();
                    hand.Player1Hand.Add(newCard2);
                                
                int counter = 0;
                int totalValueDealer = 0;
                int totalValue = 0;

                List<string> displayHand = hand.Player1Hand;
                Console.WriteLine("Your Cards Are");

                foreach (var card in displayHand)
                {
                    counter = 0;
                    Console.WriteLine(card);
                    if (card.Contains('2'))
                        counter = 2;
                    if (card.Contains('3'))
                        counter = 3;
                    if (card.Contains('4'))
                        counter = 4;
                    if (card.Contains('5'))
                        counter = 5;
                    if (card.Contains('6'))
                        counter = 6;
                    if (card.Contains('7'))
                        counter = 7;
                    if (card.Contains('8'))
                        counter = 8;
                    if (card.Contains('9'))
                        counter = 9;
                    if (card.Contains('1'))
                        counter = 10;
                    if (card.Contains('K'))
                        counter = 10;
                    if (card.Contains('J'))
                        counter = 10;
                    if (card.Contains('A'))
                        counter = 10;
                    for (int i = 0; i < counter; i++)
                        totalValue++;

                }
                Console.WriteLine("");
                Console.WriteLine($"A Total Value Of {totalValue}");
                Console.WriteLine("");

                List<string> displayDhand = dHand.DealerHand;
                Console.WriteLine("The Dealers Cards Are");
                Console.WriteLine("");
                totalValue = 0;

                foreach (var card in displayDhand)
                {
                    counter = 0;
                    Console.WriteLine(card);
                    if (card.Contains('2'))
                        counter = 2;
                    if (card.Contains('3'))
                        counter = 3;
                    if (card.Contains('4'))
                        counter = 4;
                    if (card.Contains('5'))
                        counter = 5;
                    if (card.Contains('6'))
                        counter = 6;
                    if (card.Contains('7'))
                        counter = 7;
                    if (card.Contains('8'))
                        counter = 8;
                    if (card.Contains('9'))
                        counter = 9;
                    if (card.Contains('1'))
                        counter = 10;
                    if (card.Contains('K'))
                        counter = 10;
                    if (card.Contains('J'))
                        counter = 10;
                    if (card.Contains('A'))
                        counter = 10;
                    for (int i = 0; i < counter; i++)
                        totalValue++;
                }
                Console.WriteLine("");
                Console.WriteLine($"A Total Value Of {totalValue}");

                Console.WriteLine("");
                Console.WriteLine("Enter Y To Hit, Or Any Other Key To Stand");
                string askForHit;
                bool hitCK = true;
                while (hitCK)
                {
                    askForHit = Console.ReadLine();
                    if (askForHit.ToUpper() == "Y")
                        hitCK = true;
                    else
                    {
                        hitCK = false;
                    }
                    string newCard6 = deal.DealCard();
                    hand.Player1Hand.Add(newCard6);
                    totalValue = 0;

                    Console.Clear();
                    Console.WriteLine("Do You Want To Hit?");
                    Console.WriteLine("Your Cards Are");
                    totalValue = 0;

                    foreach (var card in displayHand)
                    {
                        counter = 0;
                        Console.WriteLine(card);
                        if (card.Contains('2'))
                            counter = 2;
                        if (card.Contains('3'))
                            counter = 3;
                        if (card.Contains('4'))
                            counter = 4;
                        if (card.Contains('5'))
                            counter = 5;
                        if (card.Contains('6'))
                            counter = 6;
                        if (card.Contains('7'))
                            counter = 7;
                        if (card.Contains('8'))
                            counter = 8;
                        if (card.Contains('9'))
                            counter = 9;
                        if (card.Contains('1'))
                            counter = 10;
                        if (card.Contains('K'))
                            counter = 10;
                        if (card.Contains('J'))
                            counter = 10;
                        if (card.Contains('A'))
                            counter = 10;
                        for (int i = 0; i < counter; i++)
                            totalValue++;
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"A Total Value Of {totalValue}");

                    if (totalValue > 21)
                    {
                        Console.WriteLine("You Bust");
                        string keepPlaying = Console.ReadLine();
                        Console.WriteLine("Press Y To Keep Drawing");
                        if (keepPlaying.ToUpper() == "Y")
                            hitCK = true;
                        else
                            hitCK = false;
                    }
                }
                //dealers turn
                bool dHitCK = true;
                while (dHitCK == true)
                {
                    Console.Clear();
                    Console.WriteLine("The Dealers Cards Are");
                    Console.WriteLine("");
                    totalValueDealer = 0;

                    foreach (var card in displayDhand)
                    {
                        counter = 0;
                        Console.WriteLine(card);
                        if (card.Contains('2'))
                            counter = 2;
                        if (card.Contains('3'))
                            counter = 3;
                        if (card.Contains('4'))
                            counter = 4;
                        if (card.Contains('5'))
                            counter = 5;
                        if (card.Contains('6'))
                            counter = 6;
                        if (card.Contains('7'))
                            counter = 7;
                        if (card.Contains('8'))
                            counter = 8;
                        if (card.Contains('9'))
                            counter = 9;
                        if (card.Contains('1'))
                            counter = 10;
                        if (card.Contains('K'))
                            counter = 10;
                        if (card.Contains('J'))
                            counter = 10;
                        if (card.Contains('A'))
                            counter = 10;
                        for (int i = 0; i < counter; i++)
                            totalValueDealer++;
                    }
                    if (totalValueDealer < 18)
                    {
                        string newCard7 = deal.DealCard();
                        dHand.DealerHand.Add(newCard7);
                        dHitCK = true;
                    }
                    else
                        dHitCK = false;
                    Console.WriteLine("");
                    Console.WriteLine($"A Total Value Of {totalValueDealer}");
                }
                Console.WriteLine("");
                Console.WriteLine("Your Cards Are");

                foreach (var card in displayHand)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("");
                Console.WriteLine($"A Total Value Of {totalValue}");

                if (totalValue > totalValueDealer && totalValue < 22)
                    Console.WriteLine("Winner!");
                else if (totalValueDealer < 22 && totalValueDealer > totalValue)
                    Console.WriteLine("Dealer Wins");
                else
                    Console.WriteLine("Nobody Wins");
                string playAgain = Console.ReadLine();
                Console.WriteLine("Enter Y To Play Again");
                if (playAgain.ToUpper() == "Y")
                {
                    retry = true;
                }
                else
                {
                    retry = false;
                }
            }
        }
    }
}