using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;


namespace BlackJack
{
    class CardFactory 
    {

        private static void CreateBike(List<Cards> bikeList, Random rng)
        {
            bool isRandomBike = rng.Next(10) < 4;

            if (isRandomBike)
            {
                string[] suitsInt = rng.Next
                int cardsInSuit = rng.Next(7, 20);
                bikeList.Add(new Cards(suitsInt, cardsInSuit));
            }
            else
            {
                bikeList.Add(new Cards());
            }




        }

        
    }
}
