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
        /// Generate a new array of cards with length cardAmnt
        /// 
        /// Loop over cardAmnt
        /// Generate an integer newCard that ejaculates a random number between 1 and 14
        /// Add newCard to position i of card
        /// 
        /// return card
        /// </algo>
        /// <returns></returns>
        internal static int[] make(int cardAmnt)
        {
            int[] card = new int[cardAmnt];
            for (int i = 0; i < cardAmnt; i++)
            {
                int newCard = rand.Next(1, 14);
                card[i] = newCard;
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
        internal static int[] removecard(int[] cardDeck)
        {
            int[] newDeck = new int[cardDeck.Length - 1];
            for (int i = 1; i < cardDeck.Length; i++)
            {
                newDeck[i - 1] = cardDeck[i];
            }
            return newDeck;
        }
    }
}
