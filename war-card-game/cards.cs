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
        //public static int[] value = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public static string[] kind = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "j" };
        private static Random rand = new Random();

        /// <summary>
        /// Fill the cards for each player
        /// </summary>
        /// <algo>
        /// Generate a new array of cards with length cardAmnt
        /// 
        /// Loop over cardAmnt
        /// Generate an integer newCard that ejaculates a random number between 1 and 14
        /// Add newCard to position i of card
        /// 
        /// return card
        /// </algo>
        /// <returns></returns>
        internal static string[] make(int cardAmnt)
        {
            string[] card = new string[cardAmnt];
            for (int i = 0; i < cardAmnt; i++)
            {
                int newCard = rand.Next(0, 13);
                card[i] = kind[newCard];
            }
            return card;
        }

        /// <summary>
        /// Remove the used card from the player's deck
        /// </summary>
        /// <algo>
        /// Generate a new deck with the length of the orifginal deck - 1
        /// 
        /// loop over the original deck
        /// add each card from position 1 to the new deck at position i - 1
        /// 
        /// return the new deck
        /// </algo>
        /// <param name="cardPlayer1"></param>
        /// <returns></returns>
        internal static string[] removecard(string[] cardDeck)
        {
            string[] newDeck = new string[cardDeck.Length - 1];
            for (int i = 1; i < cardDeck.Length; i++)
            {
                newDeck[i - 1] = cardDeck[i];
            }
            return newDeck;
        }

        /// <summary>
        /// Add the cards won by a player to the deck of that player
        /// </summary>
        /// <algo>
        /// 
        /// </algo>
        /// <param name="deckPlayer1"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        internal static string[] addCardsToPlayer(string[] deckPlayer, string card1, string card2)
        {
            throw new NotImplementedException();
        }
    }
}
