using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Deck
    {
        public List<Card> Cards { get; set; }
        public string[] GetCards()
        {
            var result = new string[Cards.Count];
            for (var index = 0; index < Cards.Count; index++)
            {
                var card = Cards[index];
                result[index] = card.ToString();
            }

            return result;
        }

        public void Shuffle()
        {
            Cards.KnuthShuffle();
        }

        public Card Deal()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}
