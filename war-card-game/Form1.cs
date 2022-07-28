using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace war_card_game
{
    public partial class Form1 : Form
    {
        private static string[] deckPlayer1;
        private static string[] deckPlayer2;
        private static bool player1CardSet = false;
        private static bool player2CardSet = false;
        public static int cardAmnt = 2;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the game by triggering a function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            loadGame();
        }

        /// <summary>
        /// Load the game
        /// </summary>
        /// <algo>
        /// Check if one of the play buttons are disabled, if so
        /// enable both play buttons and disbale the new game button
        /// 
        /// make an array deckPlayer1 to put the cards in
        /// make cardsLeftCount1 it's text the amount of added cards
        /// 
        /// make an array deckPlayer2 to put the cards in
        /// make cardsLeftCount2 it's text the amount of added cards
        /// </algo>
        private void loadGame()
        {
            if (playCard1.Enabled == false)
            {
                playCard1.Enabled = true;
                playCard2.Enabled = true;
                newGame.Enabled = false;
            }
            deckPlayer1 = cards.make(cardAmnt);
            cardsLeftCount1.Text = deckPlayer1.Length.ToString();

            deckPlayer2 = cards.make(cardAmnt);
            cardsLeftCount2.Text = deckPlayer2.Length.ToString();

            lbl_status.Text = "New game started, let's play!!!";
        }

        /// <summary>
        /// Put the card from player 1 in the game
        /// </summary>
        /// <algo>
        /// When the playCard1 is clicked
        /// put the first card from deckPlayer1
        /// remove that same card from the player's deck
        /// show how many cards the player has left
        /// 
        /// tell the computer that the player put a card with a boolean
        /// 
        /// find the card's value in findCards()
        /// </algo>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playCard1_Click(object sender, EventArgs e)
        {
            cards1.Text = deckPlayer1[0];
            deckPlayer1 = cards.removecard(deckPlayer1);
            cardsLeftCount1.Text = deckPlayer1.Length.ToString();

            player1CardSet = true;

            findCards();
        }

        /// <summary>
        /// put the card from player 2 in the game
        /// </summary>
        /// <algo>
        /// When the playCard2 is clicked
        /// put the first card from deckPlayer2
        /// remove that same card from the player's deck
        /// show how many cards the player has left
        /// 
        /// tell the computer that the player put a card with a boolean
        /// 
        /// find the card's value in findCards()
        /// </algo>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playCard2_Click(object sender, EventArgs e)
        {
            cards2.Text = deckPlayer2[0];
            deckPlayer2 = cards.removecard(deckPlayer2);
            cardsLeftCount2.Text = deckPlayer2.Length.ToString();

            player2CardSet = true;

            findCards();
        }

        /// <summary>
        /// Check if both players have set a card. if so, find eaches card index position
        /// </summary>
        /// <algo>
        /// If player one AND player two have placed a card, do the following:
        /// 
        /// loop over the length of the kinds of cards
        /// if cards1.text is equal to the i position of the kind of cards
        /// 
        /// then run another loop to loop over the length of the kinds of cards
        /// if cards2.Text is equal to the j position of the kinds of cards
        /// 
        /// then compare the cards in another function
        /// 
        /// set both booleans of the players setted cards to false.
        /// </algo>
        private void findCards()
        {
            if (player1CardSet && player2CardSet)
            {
                for (int i = 0; i < cards.kind.Length; i++)
                {
                    if (cards1.Text == cards.kind[i])
                    {
                        for (int j = 0; j < cards.kind.Length; j++)
                        {
                            if (cards2.Text == cards.kind[j])
                            {
                                compareCards(i, j);
                            }
                        }
                    }
                }
                player1CardSet = false;
                player2CardSet = false;
            }
            else
            {
                if (deckPlayer1.Length == 0 || deckPlayer2.Length == 0)
                {
                    playCard1.Enabled = false;
                    playCard2.Enabled = false;
                    newGame.Enabled = true;
                    lbl_status.Text = "What de fuck bro!";
                }
            }
        }

        /// <summary>
        /// Compare the cards by taking the indexnumbers from indexPosPlayer1 and indexPosPlayer2
        /// </summary>
        /// <algo>
        /// If indexPosplayer1 is equal to indexPosPlayer2,
        /// Try again
        /// 
        /// Else
        /// If indexPosplayer1 is greater than indexPosPlayer2,
        /// Player 1 wins and gets the cards
        /// Check if the deck of player 2 is empty. if so,
        /// Enable newGame button, disable the player's buttons
        /// And give a message that player 1 won the game
        /// 
        /// Else
        /// player 2 gets the cards
        /// Check if the deck of player 1 is empty. if so,
        /// Enable newGame button, disable the player's buttons
        /// And give a message that player 2 won the game
        /// </algo>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        private void compareCards(int indexPosPlayer1, int indexPosPlayer2)
        {
            if (indexPosPlayer1 == indexPosPlayer2)
            {
                lbl_status.Text = "Oh same cards, try again fellas";
            }
            else
            {
                if (indexPosPlayer1 > indexPosPlayer2)
                {
                    lbl_status.Text = "Player 1 won the cards!";
                    deckPlayer1 = cards.addCardsToPlayer(deckPlayer1, cards1.Text, cards2.Text);
                    cardsLeftCount1.Text = deckPlayer1.Length.ToString();
                    if (deckPlayer2.Length == 0)
                    {
                        newGame.Enabled = true;
                        playCard1.Enabled = false;
                        playCard2.Enabled = false;
                        lbl_status.Text = "Player 1 won the game. Thank you for playing.";
                    }
                }
                else
                {
                    lbl_status.Text = "Player 2 won the cards!";
                    deckPlayer2 = cards.addCardsToPlayer(deckPlayer2, cards1.Text, cards2.Text);
                    cardsLeftCount2.Text = deckPlayer2.Length.ToString();
                    if (deckPlayer1.Length == 0)
                    {
                        newGame.Enabled = true;
                        playCard1.Enabled = false;
                        playCard2.Enabled = false;
                        lbl_status.Text = "Player 2 won the game. Thank you for playing.";
                    }
                }
            }
        }

        /// <summary>
        /// Load a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGame_Click(object sender, EventArgs e)
        {
            loadGame();
        }
    }
}
