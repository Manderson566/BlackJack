using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{

    public class Cards
    {

       private static string[] suits = { "Spade", "Heart", "Diamond", "Club" };
       public int[] rank = Enumerable.Range(1, 13).ToArray();
       //private string[] faceCards = { "Ace", "King", "Queen", "Jack" };
       public int[] suitsInt = Array.ConvertAll(suits, int.Parse);

        


        public Cards(int[] _suit, int[] _rank)
        {
           suitsInt = _suit;
            rank = _rank;            
        }

        public string GetSuit()
        {
            return ;
        }
        public string GetSpade()
        { 
            return suits[0];  
        }
        public string GetHeart()
        {
            return suits[1];
        }
        public string GetDiamond()
        {
            return suits[2];
        }
        public string GetClub()
        {
            return suits[3];
        }
        public Tuple<int, int> GetSuits()
        {
            return Tuple.cardsInSuit(1, 2);
        }


    }
}




