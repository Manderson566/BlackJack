using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum CardValues
    {
        Queen = 10, King = 10, Jack = 10, Ace = 11, Ten = 10, Nine = 9, Eight = 8,
        Seven = 7, Six = 6, Five = 5, Four = 4, Three = 3, Two = 2

    }
    public enum suits
    { Spade, Heart, Diamond, Club
    }



    public class Card
    {

        //private static string[] suits = { "Spade", "Heart", "Diamond", "Club" };
        //public int[] rank = Enumerable.Range(1, 13).ToArray();
        //private string[] faceCards = { "Ace", "King", "Queen", "Jack" };
        //public int[] suitsInt = Array.ConvertAll(suits, int.Parse);

        public string suit;
        public int value;






        public Card(string _suit, int _value)
        {
            suit = _suit;
            value = _value;

        }

        public Card()
        {
        }

        public string GetSpade()
        {
            return suit;
        }
    }
}



