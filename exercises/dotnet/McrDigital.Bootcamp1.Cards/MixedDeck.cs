using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McrDigital.Bootcamp1.Cards
{
    public class MixedDeck : Deck
    {
        public MixedDeck()
        {
            Cards = new List<Card>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                Cards.Add(new AnimalCard(animal));
                Cards.Add(new AnimalCard(animal));
            }

            var suits = Enum.GetValues<Suit>();

            foreach (var suit in suits)
            {
                for (var faceValue = 0; faceValue < 13; faceValue++)
                {
                    var card = new PlayingCard(suit, faceValue);
                    Cards.Add(card);
                }
            }
        }
    }
}
