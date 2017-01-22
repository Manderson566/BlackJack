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

            DeckBuilder test = new DeckBuilder();
            List<string> newCard = test.BuildDeck();
            foreach(var card in newCard)
            {
                Console.WriteLine(card);
            }
            



        }

    }
}