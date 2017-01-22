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

            Dealer test = new Dealer();
            string newCard = test.DealCard();
            Console.WriteLine(newCard);
          
            



        }

    }
}