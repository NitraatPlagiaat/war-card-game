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
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// fill up the players cards
        /// </summary>
        /// <algo>
        /// parse the text from cardsLeftCount 1 and 2 to an int
        /// 
        /// make an array cardPlayer1 to put the cards in
        /// make cardsLeftCount1 it's text the amount of added cards
        /// 
        /// make an array cardPlayer2 to put the cards in
        /// make cardsLeftCount2 it's text the amount of added cards
        /// </algo>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            int cardsPlayer1 = Int32.Parse(cardsLeftCount1.Text);
            int cardsPlayer2 = Int32.Parse(cardsLeftCount2.Text);

            int[] cardPlayer1 = cards.make();
            cardsLeftCount1.Text = cards.addcards(cardPlayer1, cardsPlayer1);

            int[] cardPlayer2 = cards.make();
            cardsLeftCount2.Text = cards.addcards(cardPlayer2, cardsPlayer2);
        }
    }
}
