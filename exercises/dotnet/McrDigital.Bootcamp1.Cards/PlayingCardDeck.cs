using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck :IDeck
    {
        public PlayingCardDeck() 
        {
            var cards = new List<ICard>();
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

            _cards = cards.ToList();
        }

        private List<ICard> _cards;

        public IEnumerable<object> GetCards()
        {
           return _cards;
        }

        public ICard Deal()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        string[] IDeck.GetCards()
        {
            var result = new string[_cards.Count];
            for (var index = 0; index < _cards.Count; index++)
            {
                var card = _cards[index];
                result[index] = card.ToString();
            }

            return result;
        }

        public void Shuffle()
        {
            _cards.KnuthShuffle();
        }
    }
}
