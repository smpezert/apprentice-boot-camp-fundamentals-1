namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class AnimalDeck : IDeck
    {
        private readonly List<ICard> _cards;

        public AnimalDeck()
        {
            _cards = new List<ICard>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                _cards.Add(new AnimalCard(animal));
                _cards.Add(new AnimalCard(animal));
            }
        }

        public ICard Deal()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public string[] GetCards()
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