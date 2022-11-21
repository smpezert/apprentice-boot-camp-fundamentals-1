using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck
    {
        public PlayingCardDeck() 
        {
            var cards = new List<PlayingCard>();
            var deck = new int[52][];

            var suits = Enum.GetValues<Suit>();

            foreach (var suit in suits)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    var card = new PlayingCard(suit, faceValue);
                    cards.Add(card);
                }
            }

            _cards = cards.ToArray();
        }

        private PlayingCard[] _cards;

        public IEnumerable<object> GetCards()
        {
           return _cards;
        }
    }
}
