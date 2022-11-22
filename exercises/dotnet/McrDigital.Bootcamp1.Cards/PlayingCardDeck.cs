using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck :Deck
    {
        public PlayingCardDeck() 
        {
            var cards = new List<Card>();

            var suits = Enum.GetValues<Suit>();

            foreach (var suit in suits)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    var card = new PlayingCard(suit, faceValue);
                    cards.Add(card);
                }
            }

            Cards = cards.ToList();
        }
    }
}
