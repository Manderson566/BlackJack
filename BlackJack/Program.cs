﻿using System;
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
            
            foreach(string tests in test.BuildDeck())
            {
                Console.WriteLine(tests);
            }
           


        }   
         
    }
}
