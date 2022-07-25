using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace war_card_game
{
    class cards
    {
        private static Random rand = new Random();

        /// <summary>
        /// Fill the cards for each player
        /// </summary>
        /// <algo>
        /// 
        /// </algo>
        /// <param name="cardsLeftCount1"></param>
        /// <returns></returns>
        internal static int[] make()
        {
            int[] card = new int[26];
            for (int i = 0; i < 26; i++)
            {
                int newCard = rand.Next(1, 14);
                card[i] = newCard;
            }
            return card;
        }

        internal static string addcards(int[] cardPlayer, int cardsPlayerAmount)
        {
            cardsPlayerAmount = cardPlayer.Length;
            return cardsPlayerAmount.ToString();
        }
    }
}
