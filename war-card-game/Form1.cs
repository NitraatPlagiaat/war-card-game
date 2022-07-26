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
        private static Random rand = new Random();
        private static int[] deckPlayer1;
        private static int[] deckPlayer2;
        private static bool player1CardSet = false;
        private static bool player2CardSet = false;
        public static int cardAmnt = 26;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fill up the players cards
        /// </summary>
        /// <algo>
        /// make an array deckPlayer1 to put the cards in
        /// make cardsLeftCount1 it's text the amount of added cards
        /// 
        /// make an array deckPlayer2 to put the cards in
        /// make cardsLeftCount2 it's text the amount of added cards
        /// </algo>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            deckPlayer1 = cards.make(cardAmnt);
            cardsLeftCount1.Text = deckPlayer1.Length.ToString();

            deckPlayer2 = cards.make(cardAmnt);
            cardsLeftCount2.Text = deckPlayer2.Length.ToString();
        }
        /// <summary>
        /// Put the card from player 1 in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playCard1_Click(object sender, EventArgs e)
        {
            switch (deckPlayer1[0])
            {
                case 1:
                    cards1.Text = "A"; //Ace
                    break;
                case 11:
                    cards1.Text = "J"; //Jack
                    break;
                case 12:
                    cards1.Text = "Q"; //Queen
                    break;
                case 13:
                    cards1.Text = "K"; //King
                    break;
                case 14:
                    cards1.Text = "j"; //Joker
                    break;
                default:
                    cards1.Text = deckPlayer1[0].ToString();
                    break;
            }
            deckPlayer1 = cards.removecard(deckPlayer1);
            cardsLeftCount1.Text = deckPlayer1.Length.ToString();
        }

        /// <summary>
        /// put the card from player 2 in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playCard2_Click(object sender, EventArgs e)
        {
            switch (deckPlayer2[0])
            {
                case 1:
                    cards2.Text = "A"; //Ace
                    break;
                case 11:
                    cards2.Text = "J"; //Jack
                    break;
                case 12:
                    cards2.Text = "Q"; //Queen
                    break;
                case 13:
                    cards2.Text = "K"; //King
                    break;
                case 14:
                    cards2.Text = "j"; //Joker
                    break;
                default:
                    cards2.Text = deckPlayer2[0].ToString();
                    break;
            }
            deckPlayer2 = cards.removecard(deckPlayer2);
            cardsLeftCount2.Text = deckPlayer2.Length.ToString();

            player1CardSet = true;

            compareCards(player1CardSet);
        }

        /// <summary>
        /// Check if both players have set a card. if so, compare both cards
        /// </summary>
        private void compareCards(bool playerCardSet)
        {
            if (player1CardSet && player2CardSet)
            {
                playerCardSet = false;
            }
        }
    }
}
